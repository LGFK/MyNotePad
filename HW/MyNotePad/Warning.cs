﻿using System;
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
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void bttnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void bttnNo_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.No;
        }
    }
}
