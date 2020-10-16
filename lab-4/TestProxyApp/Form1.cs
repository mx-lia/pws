using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProxyApp
{
    public partial class Form1 : Form
    {
        Simplex client = new Simplex();

        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            result.Text = client.Add((int)x.Value, (int)y.Value).ToString();
        }
    }
}
