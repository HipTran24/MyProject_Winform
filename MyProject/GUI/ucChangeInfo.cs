using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyProject.GUI
{
    public partial class ucChangeInfo : UserControl
    {
        public ucChangeInfo()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSex.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ucChangeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
