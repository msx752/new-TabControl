using System;
using System.Windows.Forms;

namespace newTabControl
{
    public partial class TabControlTest : Form
    {
        public TabControlTest()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            msaTabControl1.AddPage(
                new MSATabPage(new TextBox()
                {
                    Multiline = true,
                    Name = "textbox" + count,
                    Text = count.ToString()
                },
                    "Testing" + count)
                );
            count++;
        }
    }
}