using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_2_ARRAY.Forms {
    public partial class about : UserControl {
        public about() {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e) {
            Program.p.packages();
        }
    }
}
