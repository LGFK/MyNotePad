namespace MyNotePad
{
    partial class Warning
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
            this.lbWarning = new System.Windows.Forms.Label();
            this.bttnYes = new System.Windows.Forms.Button();
            this.bttnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWarning
            // 
            this.lbWarning.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWarning.Location = new System.Drawing.Point(38, 23);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(248, 83);
            this.lbWarning.TabIndex = 0;
            this.lbWarning.Text = "Would you like to save changes?";
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnYes
            // 
            this.bttnYes.Location = new System.Drawing.Point(38, 120);
            this.bttnYes.Name = "bttnYes";
            this.bttnYes.Size = new System.Drawing.Size(81, 43);
            this.bttnYes.TabIndex = 1;
            this.bttnYes.Text = "Yes";
            this.bttnYes.UseVisualStyleBackColor = true;
            this.bttnYes.Click += new System.EventHandler(this.bttnYes_Click);
            // 
            // bttnNo
            // 
            this.bttnNo.Location = new System.Drawing.Point(205, 120);
            this.bttnNo.Name = "bttnNo";
            this.bttnNo.Size = new System.Drawing.Size(81, 43);
            this.bttnNo.TabIndex = 2;
            this.bttnNo.Text = "No";
            this.bttnNo.UseVisualStyleBackColor = true;
            this.bttnNo.Click += new System.EventHandler(this.bttnNo_Click);
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 175);
            this.Controls.Add(this.bttnNo);
            this.Controls.Add(this.bttnYes);
            this.Controls.Add(this.lbWarning);
            this.Name = "Warning";
            this.Text = "Warning";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbWarning;
        private Button bttnYes;
        private Button bttnNo;
    }
}