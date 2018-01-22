using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using VistaDB;
using System.Security.Cryptography;

namespace dm{
    
    public static class vistadb{
        
         public static VistaDB.Provider.VistaDBConnection conn;
         public static string connString ="";
          //public static string connString = @"Driver= {MicrosoftAccessDriver(*.mdb)};DBQ=C:\shipWrecked\shipWrecked-JADVDATA.mdf;Uid=;Pwd=";

        public static string columnEnclosingLeft="[";
        public static string columnEnclosingRight="]";
        
        public static bool nonQuery(string query)
        {
            try{
                if (conn == null || conn.State == System.Data.ConnectionState.Closed) vistadb.connect();
                VistaDB.Provider.VistaDBCommand command = new VistaDB.Provider.VistaDBCommand(query,conn);
                command.ExecuteNonQuery();
            }catch (Exception e){
                log.error("db.query", e.Message);
            }

            return false;
        }

        public static void closeReader(VistaDB.Provider.VistaDBDataReader reader){
            if(null!=reader) reader.Close();
        }

        public static void disposeReader(VistaDB.Provider.VistaDBDataReader reader){
            if(null!=reader) reader.Dispose();
        }

        public static void connect(){
            try{
                conn=new VistaDB.Provider.VistaDBConnection(connString);
                conn.Open();
            }catch (Exception e){
                log.error("DB::connect",e.ToString());
            }
        }

        public static void connect(string folderPath,string databaseName,string  password,bool isPooled){
            connString=CreateConnectionString(folderPath,databaseName, password,isPooled);
            connect();
        }

        private static string _databasePath;
        private const string ConnectionString = "Data Source={0}; Open Mode=SharedReadOnly ; Password={1};Min Pool Size=10; Max Pool Size=100; Persist Security Info=False; Pooling={2};";
        private const string DatabaseFilename = "{0}.vdb3";
        public const string VistaDBProviderName = "VistaDB.NET20";

        public static string CreateConnectionString(string folderPath, string databaseName, string password, bool isPooled){
            _databasePath = Path.Combine(folderPath, string.Format("{0}.vdb3", databaseName));
            if (!String.IsNullOrEmpty(password)){
                return string.Format("Data Source={0}; Open Mode=SharedReadOnly ; Password={1};Min Pool Size=10; Max Pool Size=100; Persist Security Info=False; Pooling={2};", _databasePath, password, false);
            } 
            return string.Format("Data Source={0}; Open Mode=SharedReadOnly ; Password={1};Min Pool Size=10; Max Pool Size=100; Persist Security Info=False; Pooling={2};", _databasePath, string.Empty, false);
        }

        public static void close(){
            if(conn!=null) {
                conn.Close();
            }
        }

        public static bool isConnected(){
            if(conn==null) return false;
            //if(conn.State==null) return false;
            switch(conn.State){
                case System.Data.ConnectionState.Broken: return false;
                case System.Data.ConnectionState.Closed: return false;
                case System.Data.ConnectionState.Connecting: return true;
                case System.Data.ConnectionState.Executing: return true;
                case System.Data.ConnectionState.Open: return true;
                case System.Data.ConnectionState.Fetching: return true;
            }
            return false;
        }
        
        public static string escapeString(string data){
            return data;//.Replace("_", "\\_").Replace("%", "\\%");
        }

        public static VistaDB.Provider.VistaDBDataReader query(string query) {
            VistaDB.Provider.VistaDBDataReader reader;
                VistaDB.Provider.VistaDBCommand command;
                try{
                
                if (conn == null || conn.State == System.Data.ConnectionState.Closed) vistadb.connect();
                
                command = new VistaDB.Provider.VistaDBCommand(query,conn);
                reader = command.ExecuteReader();
                command.Dispose();
                return reader;
                            
            }catch (Exception e){
                log.error("DB::query",e.ToString());
            }
            return null;
        }

        public static Hashtable fetchSingle(VistaDB.Provider.VistaDBDataReader reader){
            if(null==reader) return null;
            if(reader.IsClosed) { 
                reader.Close();
                reader.Dispose();
                return null;
            }
            Hashtable results = new Hashtable();
            
            if(!reader.Read()) {
                reader.Close();
                reader.Dispose();
                return null;
            }

            if (reader.HasRows){
                for (int i = 0; i < reader.FieldCount; i++){
                    string data="";
                    if(null!=reader[i]) data=reader[i].ToString().Trim();
                    string column=reader.GetName(i);
                    results[column] =data;
                }
            } else {
                reader.Close();
                reader.Dispose();
                return null;
            }
            return results;
        }

        public static Hashtable fetch(string query) {
            Hashtable results = new Hashtable();
            try{
                if (conn == null || conn.State == System.Data.ConnectionState.Closed) vistadb.connect();
                VistaDB.Provider.VistaDBDataReader reader = null;
                VistaDB.Provider.VistaDBCommand command = new VistaDB.Provider.VistaDBCommand(query,conn);
                reader = command.ExecuteReader();
                command.Dispose();

                if(!reader.Read()) {
                    reader.Close();
                    reader.Dispose();
                    return null;
                }

                if (reader.HasRows){
                    for (int i = 0; i < reader.FieldCount; i++){
                        results[reader.GetName(i)] = reader[i].ToString().Trim();
                    }
                }
                reader.Close();
                reader.Dispose();
            }catch (Exception e){
                log.error("DB::query",e.ToString());
            }
            return results;
        }

        public static List<Hashtable> fetchAll(string query){
            List <Hashtable> results=new List <Hashtable>();

            try{
                if (conn == null || conn.State == System.Data.ConnectionState.Closed) vistadb.connect();
                VistaDB.Provider.VistaDBDataReader reader = null;
                VistaDB.Provider.VistaDBCommand command = new VistaDB.Provider.VistaDBCommand(query,conn);
                reader = command.ExecuteReader();
                command.Dispose();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        Hashtable result = new Hashtable();
                        for (int i = 0; i < reader.FieldCount; i++) {
                            string data="";
                            if(null!=reader[i]) data=reader[i].ToString().Trim();
                            string column  =reader.GetName(i);
                            result[column] =data;
                            
                        }
                        results.Add(result);
                    }
                }
                reader.Close();
                reader.Dispose();
                command.Dispose();
            }
            catch (Exception e)
            {
                log.error("DB::query", e.ToString());
            }
            return results;
        }

        public static List<Hashtable> getTables(){
            List<Hashtable> results=new List<Hashtable>();
            
            List<Hashtable> tableData=vistadb.fetchAll("SELECT name FROM [database schema] WHERE typeid=1");
            
            foreach(Hashtable tableRow in tableData){
                Hashtable table=new Hashtable();
                table["name"]=tableRow["name"].ToString();
                results.Add(table);
            }
            return results;
        }

        public static List<Hashtable> getColumns(string tableName){
            List<Hashtable> results=new List<Hashtable>();
            
            VistaDB.DDA.IVistaDBTableSchema schema=conn.GetTableSchema(tableName);
            foreach (VistaDB.DDA.IVistaDBColumnAttributes col in schema){
                Hashtable t=new Hashtable();
                t["column"]=col.Name.ToString();
                t["type"]  =col.Type.ToString().ToLower();
                results.Add(t);
            }
            return results;
        }


    }

}
