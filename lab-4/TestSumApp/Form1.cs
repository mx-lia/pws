using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSumApp.ServiceReference;

namespace TestSumApp
{
    public partial class Form1 : Form
    {
        SimplexSoapClient client = new SimplexSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            float.TryParse(f1.Text, out float f1Val);
            float.TryParse(f2.Text, out float f2Val);
            A result = client.Sum(new A { k = (int)k1.Value, f = f1Val, s = s1.Text }, new A { k = (int)k2.Value, f = f2Val, s = s2.Text });
            k.Text = result.k.ToString();
            s.Text = result.s;
            f.Text = result.f.ToString();
        }
    }
}
