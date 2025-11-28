using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRISHIN_PR08_GIT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#00FA9A");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#00FA9A");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#00FA9A");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }
    }
}
