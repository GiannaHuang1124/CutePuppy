using customerlist;
using Orderlist;
using Productlist;
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
    public partial class 後台管理Form : Form
    {

        private void 後台管理_Load(object sender, EventArgs e)
        {
            //FormLogin myLoginForm = new FormLogin();
            //myLoginForm.ShowDialog();
        }

        public 後台管理Form()
        {
            InitializeComponent();
        }

        private void btn顧客資料維護系統_Click(object sender, EventArgs e)
        {
            FormMember myFormMember = new FormMember();
            myFormMember.ShowDialog();
        }

        private void 訂單維護系統_Click(object sender, EventArgs e)
        {
            FormOrderlist myOrderlist = new FormOrderlist();
            myOrderlist.ShowDialog();
        }

        private void btn商品管理系統_Click(object sender, EventArgs e)
        {
            Product myProduct = new Product();
            myProduct.ShowDialog();
        }

        private void 後台管理Form_Load(object sender, EventArgs e)
        {

        }
    }
}
