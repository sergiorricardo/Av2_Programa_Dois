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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsim_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
        }

        private void btnnao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
