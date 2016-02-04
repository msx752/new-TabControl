using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newTabControl
{
    public partial class TabControlTest : Form
    {
        public TabControlTest()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            msaTabControl1.AddPage(
                new MSATabPage(new TextBox()
                {
                    Multiline = true, Name = "textbox" + count, Text = count.ToString() },
                    "Testing" + count)
                );
            count++;
        }
    }
}
