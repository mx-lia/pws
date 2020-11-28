using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWebFormApp.ASMX_Server;

namespace TestWebFormApp
{
    public partial class _Default : Page
    {
        private SimplexImpl client;

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new SimplexImpl();
        }

        protected void sum_Click(object sender, EventArgs e)
        {
            int val1, val2;
            if (int.TryParse(x.Text.ToString(), out val1) && int.TryParse(y.Text.ToString(), out val2))
            {
                result.Text = client.Add(val1, val2).ToString();
            }
            else
            {
                result.Text = "Error!";
            }
        }
    }
}