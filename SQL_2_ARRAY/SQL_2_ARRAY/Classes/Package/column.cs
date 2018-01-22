using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_2_ARRAY {
    partial class dbTransformFactory{
        public class column {
            public string name="";
            public string newName="";
            public bool include=false;
        
            public column(){
            }
            public column(string name,string newName,bool include){
                this.name=name;
                this.newName=newName;
                this.include=include;
            }
        }
    }
}

