using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paylocity_Challenge
{
    public partial class NameForm : Form
    {
    public string PersonName { get; private set; }
        public NameForm(string nametype)
        {
            InitializeComponent();
            label1.Text = nametype + " name:";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PersonName = textBox1.Text;
        }
    }
}
