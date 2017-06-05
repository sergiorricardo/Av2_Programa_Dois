using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro.CSharp
{
    public partial class Primeira : Form
    {
        public Primeira()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "arquivo de texto | *txt";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK && saveFileDialog1.FileName.Length>0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            Enabled = false;
            Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("acabou o tempo");
            Application.Exit();
        
        }
        
    }
}
