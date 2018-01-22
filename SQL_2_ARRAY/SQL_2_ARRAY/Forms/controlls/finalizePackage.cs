using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_2_ARRAY.Forms {
    public partial class finalizePackage : UserControl {
        public finalizePackage() {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e) {
            Program.p.wizard();
        }

        private void savePackage_Click(object sender, EventArgs e) {
            Program.activePackage.save();
        }

        private void runPackage_Click(object sender, EventArgs e) {
            Program.p.running();
        }

        private void saveRun_Click(object sender, EventArgs e) {
            Program.activePackage.save();
            Program.p.running();
        }

    }
}
