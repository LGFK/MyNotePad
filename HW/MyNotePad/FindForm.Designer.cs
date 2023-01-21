namespace MyNotePad
{
    partial class FindForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnFOk = new System.Windows.Forms.Button();
            this.bttnFCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 81);
            this.textBox1.TabIndex = 0;
            // 
            // bttnFOk
            // 
            this.bttnFOk.Location = new System.Drawing.Point(12, 106);
            this.bttnFOk.Name = "bttnFOk";
            this.bttnFOk.Size = new System.Drawing.Size(75, 23);
            this.bttnFOk.TabIndex = 1;
            this.bttnFOk.Text = "OK";
            this.bttnFOk.UseVisualStyleBackColor = true;
            this.bttnFOk.Click += new System.EventHandler(this.bttnFOk_Click);
            // 
            // bttnFCanc
            // 
            this.bttnFCanc.Location = new System.Drawing.Point(220, 106);
            this.bttnFCanc.Name = "bttnFCanc";
            this.bttnFCanc.Size = new System.Drawing.Size(75, 23);
            this.bttnFCanc.TabIndex = 2;
            this.bttnFCanc.Text = "Cancel";
            this.bttnFCanc.UseVisualStyleBackColor = true;
            this.bttnFCanc.Click += new System.EventHandler(this.bttnFCanc_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 141);
            this.Controls.Add(this.bttnFCanc);
            this.Controls.Add(this.bttnFOk);
            this.Controls.Add(this.textBox1);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button bttnFOk;
        private Button bttnFCanc;
    }
}