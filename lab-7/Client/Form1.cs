using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XmlReader xmlReader = XmlReader.Create("http://localhost:8080/SyndicationServiceLibrary/NotesFeed/");
            SyndicationFeed feed = SyndicationFeed.Load(xmlReader);
            foreach (SyndicationItem item in feed.Items)
            {
                richTextBox1.Text += item.Summary.Text + " ---> ";
                richTextBox1.Text += item.Title.Text + "\n";
            }
        }
    }
}
