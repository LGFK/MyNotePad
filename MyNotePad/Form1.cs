

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        private string path;
        private bool isSaved = false;
        private string lastSaved;

        public RichTextBox getRTB
        {
            get { return richTextBox1; }
        }
        public Form1()
        {
            InitializeComponent();
            path = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT (*.txt)|*txt";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sr = File.OpenText(fileDialog.FileName))
                {
                    path = fileDialog.FileName;
                    richTextBox1.Text = sr.ReadToEnd();
                    lastSaved = richTextBox1.Text;
                    isSaved = true;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path!="")
            {
                using(var sw = File.CreateText(path))
                {
                    sw.Write(richTextBox1.Text);
                    lastSaved = richTextBox1.Text;
                    isSaved = true;
                }
                
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "TXT (*.txt)|*.txt";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sw = File.CreateText(fileDialog.FileName))
                {
                    sw.Write(richTextBox1.Text);
                    path = fileDialog.FileName;
                    lastSaved = richTextBox1.Text;
                    isSaved = true;
                }

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved == true)
            {
                Close();
                return;
            }
            else
            {
                Warning warn = new Warning();
                warn.ShowDialog();
                if (warn.DialogResult == DialogResult.Yes && path != "")
                {
                    saveToolStripMenuItem.PerformClick();
                }
                else if(warn.DialogResult == DialogResult.Yes && path=="")
                {
                    saveAsToolStripMenuItem.PerformClick();
                }
                Close();
            }
        }
        

        private void t1_Tick(object sender, EventArgs e)
        {
            if(lastSaved!=richTextBox1.Text)
            {
                isSaved = false;
                Text = "MyNotePad*";
            }
            else
            {
                Text = "MyNotePad";
            }
            toolStripStatusLabel1.Text = $"Raw:{getStats().Item1}    |    Col:{getStats().Item2}";



        }

        private (int , int) getStats()
        {

            int raw = 1;
            int col = 0;
            string cursPos = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart);
            foreach(var a in cursPos)
            {
                if (a == '\n')
                { 
                    raw++;
                    col = 0;
                }
                else
                {
                    col++;
                }


            }
            return (raw, col);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved == true)
            {
                path = "";
                richTextBox1.Text = "";
                lastSaved = null ;
                return;
            }
            else
            {
                Warning warn = new Warning();
                warn.ShowDialog();
                if (warn.DialogResult == DialogResult.Yes && path != "")
                {
                    saveToolStripMenuItem.PerformClick();
                }
                else if (warn.DialogResult == DialogResult.Yes && path == "")
                {
                    saveAsToolStripMenuItem.PerformClick();
                }
                path = "";
                richTextBox1.Text = "";
                lastSaved = null;
                return;

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.Remove(0);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.Font = richTextBox1.SelectionFont;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = statusBarToolStripMenuItem.Checked = true;
            richTextBox1.WordWrap = wordWrapToolStripMenuItem.Checked = true;
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"That's my own notepad");
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new FindForm(richTextBox1); 
            myForm.Show();
            
        }
    }
}