using customerlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CutePuppy
{
    public partial class 身分切換入口 : Form
    {
        public 身分切換入口()
        {
            InitializeComponent();
        }

        private void 身分切換入口_Load(object sender, EventArgs e)
        {

        }

        private void btn我是員工_Click(object sender, EventArgs e)
        {
            員工登入 my員工 = new 員工登入();
            my員工.ShowDialog();
            //Close();
        }

        private void btn我是顧客_Click(object sender, EventArgs e)
        {
            會員登入 my會員 = new 會員登入();
            my會員.ShowDialog();
            //Close();
        }
    }
}
