using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_2_ARRAY{
    partial class dbTransformFactory{
        public class tables{
            public List<table> items=new List<table>();
        
            public tables(){
            }

            public void addTable(string database,string table,bool include){
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                        return;
                    }
                }//q loop
                items.Add(new table(database,table,include));
            }

            public void addTable(string database,string table){
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                        return;
                    }
                }//q loop
                items.Add(new table(database,table));
            }

            public void addTable(table table){
                foreach(table q in items) {
                    if(q.name==table.name && q.database==table.database) {
                        return;
                    }
                }//q loop
                items.Add(table);
            }

            public table findTable(string database,string table) {
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      return q;
                    }
                }
                addTable(database,table);
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      return q;
                    }
                }
                 return new table("","");
            }

            public void addField(string database,string table,string field,string name,bool include){
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      q.addField(field,name,include);
                      return;
                    }
                }
                addTable(database,table);
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      q.addField(field,name,include);
                      return;
                    }
                }
          }//end add field


            public void updateField(string database,string table,string field,string name,bool include){
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                        q.updateField(field,name,include);
                        return;
                    }
                }
                addTable(database,table);
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                        q.updateField(field,name,include);
                        return;
                    }
                }
            }//end add field


            public void addTop(string database,string table,int top){
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                        q.top=top;
                        return;
                    }
                }
                addTable(database,table);
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                        q.top=top;
                        return;
                    }
                }
            }//end add top

            public void addWhere(string database,string table,string where){
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      q.where=where;
                      return;
                    }
                }
                addTable(database,table);
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      q.where=where;
                      return;
                    }
                }
          }//end add field

          public void setInclude(string database,string table,bool include){
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      q.include=include;
                      return;
                    }
                }
                addTable(database,table);
                foreach(table q in items) {
                    if(q.name==table && q.database==database) {
                      q.include=include;
                      return;
                    }
                }
          }//end add field


        }//end queries (multiple)
    }
}
