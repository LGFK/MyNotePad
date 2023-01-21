using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class FindForm : Form
    {
        RichTextBox mainRef;
        
        public FindForm(RichTextBox rTB)
        {
            InitializeComponent();
            mainRef = rTB;
        }

        private void bttnFOk_Click(object sender, EventArgs e)
        {
           int pos = mainRef.Find(textBox1.Text);
            if(pos > -1)
            {
                mainRef.Select(pos, textBox1.Text.Length);
                mainRef.Focus();
            }
          
            
        }

        private void bttnFCanc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
