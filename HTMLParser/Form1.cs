using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTMLParser.Core;
using HTMLParser.Core.Parser;

namespace HTMLParser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser=new ParserWorker<string[]>(new Parser());

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("Worked");
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
           listTitles.Items.AddRange(arg2);
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            parser.ParserSettings=new Settings((int) numericStart.Value,(int)numericEnd.Value);
            parser.Start();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            parser.Stop();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
