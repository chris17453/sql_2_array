using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_2_ARRAY.Forms {
    public partial class destination : UserControl {
        public destination() {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e) {
            Program.activePackage.destination=location.Text;
            if(String.IsNullOrEmpty(Program.activePackage.destination) ) {
                MessageBox.Show("No output location specified.","Yo, my brother. Heads up!");
                return;
            } 
            Program.p.wizard();
        }

        private void back_Click(object sender, EventArgs e) {
            Program.p.source();
        }

        private void destination_Load(object sender, EventArgs e) {
            location.Text=Program.activePackage.destination;
        }

        private void browse_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Destination Output Text File";
            saveFileDialog1.ShowDialog();

            if(saveFileDialog1.FileName != ""){
                Program.activePackage.destination=saveFileDialog1.FileName;
                location.Text=Program.activePackage.destination;
            }        
        }//end func
    }
}
