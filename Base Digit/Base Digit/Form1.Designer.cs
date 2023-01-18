namespace Base_Digit
{
    partial class Form1
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
            this.btnBin = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.txtDigit10 = new System.Windows.Forms.TextBox();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBin
            // 
            this.btnBin.Location = new System.Drawing.Point(85, 213);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(75, 23);
            this.btnBin.TabIndex = 0;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnOct
            // 
            this.btnOct.Location = new System.Drawing.Point(166, 213);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(75, 23);
            this.btnOct.TabIndex = 1;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(247, 213);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(75, 23);
            this.btnHex.TabIndex = 2;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // txtDigit10
            // 
            this.txtDigit10.Location = new System.Drawing.Point(85, 50);
            this.txtDigit10.Name = "txtDigit10";
            this.txtDigit10.Size = new System.Drawing.Size(143, 20);
            this.txtDigit10.TabIndex = 3;
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Location = new System.Drawing.Point(82, 329);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(52, 13);
            this.lblBin.TabIndex = 4;
            this.lblBin.Text = "bin empty";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.Location = new System.Drawing.Point(163, 329);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(53, 13);
            this.lblOct.TabIndex = 5;
            this.lblOct.Text = "oct empty";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(244, 329);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(55, 13);
            this.lblHex.TabIndex = 6;
            this.lblHex.Text = "hex empty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblOct);
            this.Controls.Add(this.lblBin);
            this.Controls.Add(this.txtDigit10);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnBin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.TextBox txtDigit10;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblHex;
    }
}

