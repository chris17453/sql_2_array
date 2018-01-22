using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_2_ARRAY.Forms {
    public partial class database_properties : UserControl {
        public database_properties() {
            InitializeComponent();
            load();
        }

        private void load(){
            string [] types=dm.db.getDatabaseTypes();
            foreach(string type in types){
                dbType.Items.Add(type);
            }

            this.name.Text=Program.activePackage.name;
            this.ip.Text=Program.activePackage.ip;
            this.user.Text=Program.activePackage.user;
            this.pass.Text=Program.activePackage.password;
            
            foreach(string type in types){                                                      //pogramatically add db types...
                if(type.ToLower()==Program.activePackage.type.ToLower()) {
                    dbType.SelectedItem=type; 
                    break; 
                }
            }

        }

        private void back_Click(object sender, EventArgs e) {
            Program.p.packages();
        }

        private void next_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(this.name.Text))        { MessageBox.Show("No Session Name");  return; }
            if(String.IsNullOrEmpty(this.ip.Text))          { MessageBox.Show("No Server IP");     return; }
            if(String.IsNullOrEmpty(this.user.Text))        { MessageBox.Show("No User name");     return; }
            if(String.IsNullOrEmpty(this.pass.Text))        { MessageBox.Show("No Password");      return; }
            if(String.IsNullOrEmpty(this.dbType.Text))      { MessageBox.Show("Select a DB Type"); return; }
            
            Program.activePackage.ip            =this.ip.Text;
            Program.activePackage.user          =this.user.Text;
            Program.activePackage.password      =this.pass.Text;
            Program.activePackage.type          =this.dbType.Text;
            Program.activePackage.name          =this.name.Text;

            
            dm.db.mode=dbType.Text.ToLower();
            if(dm.db.isConnected()) {
                dm.db.close();
            }


            dm.db.connect(Program.activePackage.ip,Program.activePackage.user,Program.activePackage.password);
            if(!dm.db.isConnected()) {
                MessageBox.Show("Bad Credentials. Try Again");
            } else {
                Program.p.destination();
            }
        }

        private void database_properties_Load(object sender, EventArgs e) {

        }

        private void database_properties_Load_1(object sender, EventArgs e) {

        }

        private void dbType_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
