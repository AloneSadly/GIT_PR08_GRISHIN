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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            button1.BackColor = ColorTranslator.FromHtml("#7FFF00");
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");

        }
    }
}
