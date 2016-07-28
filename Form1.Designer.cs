namespace SwapMouse
{
    partial class frmSwapMouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoRight = new System.Windows.Forms.RadioButton();
            this.rdoLeft = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoRight
            // 
            this.rdoRight.AutoSize = true;
            this.rdoRight.Checked = true;
            this.rdoRight.Location = new System.Drawing.Point(25, 58);
            this.rdoRight.Name = "rdoRight";
            this.rdoRight.Size = new System.Drawing.Size(93, 29);
            this.rdoRight.TabIndex = 0;
            this.rdoRight.TabStop = true;
            this.rdoRight.Text = "Right";
            this.rdoRight.UseVisualStyleBackColor = true;
            this.rdoRight.CheckedChanged += new System.EventHandler(this.FlipMouse);
            // 
            // rdoLeft
            // 
            this.rdoLeft.AutoSize = true;
            this.rdoLeft.Location = new System.Drawing.Point(164, 58);
            this.rdoLeft.Name = "rdoLeft";
            this.rdoLeft.Size = new System.Drawing.Size(79, 29);
            this.rdoLeft.TabIndex = 1;
            this.rdoLeft.Text = "Left";
            this.rdoLeft.UseVisualStyleBackColor = true;
            this.rdoLeft.CheckedChanged += new System.EventHandler(this.FlipMouse);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoRight);
            this.groupBox1.Controls.Add(this.rdoLeft);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set mouse to";
            // 
            // frmSwapMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 169);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSwapMouse";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Swap";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FocussedForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoRight;
        private System.Windows.Forms.RadioButton rdoLeft;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

