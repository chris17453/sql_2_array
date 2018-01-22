namespace SQL_2_ARRAY.Forms {
    partial class finalizePackage {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.back = new System.Windows.Forms.Button();
            this.savePackage = new System.Windows.Forms.Button();
            this.runPackage = new System.Windows.Forms.Button();
            this.saveRun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(17, 307);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // savePackage
            // 
            this.savePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePackage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.savePackage.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePackage.Location = new System.Drawing.Point(98, 307);
            this.savePackage.Name = "savePackage";
            this.savePackage.Size = new System.Drawing.Size(75, 23);
            this.savePackage.TabIndex = 2;
            this.savePackage.Text = "Save";
            this.savePackage.UseVisualStyleBackColor = false;
            this.savePackage.Click += new System.EventHandler(this.savePackage_Click);
            // 
            // runPackage
            // 
            this.runPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runPackage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.runPackage.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runPackage.Location = new System.Drawing.Point(260, 307);
            this.runPackage.Name = "runPackage";
            this.runPackage.Size = new System.Drawing.Size(75, 23);
            this.runPackage.TabIndex = 0;
            this.runPackage.Text = "Run";
            this.runPackage.UseVisualStyleBackColor = false;
            this.runPackage.Click += new System.EventHandler(this.runPackage_Click);
            // 
            // saveRun
            // 
            this.saveRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveRun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveRun.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRun.Location = new System.Drawing.Point(179, 307);
            this.saveRun.Name = "saveRun";
            this.saveRun.Size = new System.Drawing.Size(75, 23);
            this.saveRun.TabIndex = 1;
            this.saveRun.Text = "Save/Run";
            this.saveRun.UseVisualStyleBackColor = false;
            this.saveRun.Click += new System.EventHandler(this.saveRun_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 44);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Save, Run or Cancel this package.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Finalize Package";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "This app is computationally and resource intensive. You are warned.";
            // 
            // finalizePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveRun);
            this.Controls.Add(this.runPackage);
            this.Controls.Add(this.savePackage);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(336, 224);
            this.Name = "finalizePackage";
            this.Size = new System.Drawing.Size(336, 330);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button savePackage;
        private System.Windows.Forms.Button runPackage;
        private System.Windows.Forms.Button saveRun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
