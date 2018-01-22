using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SQL_2_ARRAY.Forms {
    public partial class packages : UserControl {
        public packages() {
            InitializeComponent();
            populatePackages();
        }

        public void populatePackages(){
            string [] packages=Program.activePackage.getPackages();
            packageList.Items.Clear();
            foreach(string path in packages){
                dbTransformFactory p=new dbTransformFactory(path);
                packageList.Items.Add(p.name);
            }

        }

        private void new_package_Click(object sender, EventArgs e) {
            Program.activePackage=new dbTransformFactory();
            Program.p.source();
        }

        private void Edit_Click(object sender, EventArgs e) {

        }

        private void rename_Click(object sender, EventArgs e) {

        }

        private void delete_package_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(packageList.Text)) {
                 if (MessageBox.Show("Really delete, like forever yo?","Defcon 1! Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes) {
    
                    File.Delete(Program.homePath+packageList.Text+".dm_sql_pkg");
                    Program.p.packages();
                 }
            } else {
                MessageBox.Show("No file selected.","Come on, Get with the program player!");
            }


        }

        private void close_Click(object sender, EventArgs e) {
            Program.p.Close();
        }

        private void about_Click(object sender, EventArgs e) {
            Program.p.about();
        }

        private void open_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(packageList.Text)) {
                Program.activePackage=new dbTransformFactory(Program.homePath+packageList.Text+".dm_sql_pkg");
                Program.p.wizard();
            } else {
                MessageBox.Show("No file selected.","Really my man?");
            }
        }

        private void packageList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void packageList_DoubleClick(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(packageList.Text)) {
                Program.activePackage=new dbTransformFactory(Program.homePath+packageList.Text+".dm_sql_pkg");
                Program.p.wizard();
            } else {
                MessageBox.Show("No file selected.","Seriously!!!! WTF MATE?");
            }
        }

        }
}
