using customerlist;
using Productlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orderlist
{
    public partial class FormOrderlist : Form
    {
        
        
        public FormOrderlist()
        {
            InitializeComponent();
        }

        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderlistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cutePuppyDataSet2);

        }

        private void FormOrderlist_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cutePuppyDataSet2.Orderlist' 資料表。您可以視需要進行移動或移除。
            this.orderlistTableAdapter.Fill(this.cutePuppyDataSet2.Orderlist);
            // TODO: 這行程式碼會將資料載入 'cutePuppyDataSet1.Orderlist' 資料表。您可以視需要進行移動或移除。
            this.orderlistTableAdapter.Fill(this.cutePuppyDataSet2.Orderlist);

            cbox出貨進度.Items.Add("未出貨");
            cbox出貨進度.Items.Add("出貨中");
            cbox出貨進度.Items.Add("已送達");
            cbox出貨進度.SelectedIndex = 0;

            cbox取貨方式.Items.Add("宅配");
            cbox取貨方式.Items.Add("超商取貨");
            cbox取貨方式.SelectedIndex = 0;

            cbox付款方式.Items.Add("信用卡");
            cbox付款方式.Items.Add("ATM轉帳");
            cbox付款方式.SelectedIndex = 0;

            cbox進階欄位名稱.Items.Add("會員姓名");
            cbox進階欄位名稱.Items.Add("收件姓名");
            cbox進階欄位名稱.Items.Add("連絡電話");
            cbox進階欄位名稱.Items.Add("出貨進度");
            cbox進階欄位名稱.Items.Add("商品名稱");



            顯示筆數統計();

        }

        void 顯示筆數統計()
        {
            int 目前第幾筆 = orderlistBindingSource.Position + 1;
            int 目前總共有幾筆 = orderlistBindingSource.Count;

            lbl筆數資訊.Text = string.Format("第{0}筆/共{1}筆", 目前第幾筆, 目前總共有幾筆);
        }

        

        private void btn回復資料_Click(object sender, EventArgs e)
        {
            orderlistBindingSource.EndEdit();
            int 目前索引值 = orderlistBindingSource.Position;
            orderlistTableAdapter.Fill(cutePuppyDataSet2.Orderlist);
            orderlistBindingSource.Position = 目前索引值;
            顯示筆數統計();
            MessageBox.Show("資料回復成功");
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            Validate();
            orderlistBindingSource.EndEdit();
            //tableAdapterManager.UpdateAll(mydbDataSet);
            orderlistTableAdapter.Update(cutePuppyDataSet2.Orderlist);
            顯示筆數統計();
            MessageBox.Show("資料儲存成功");
        }


        private void btn第一筆_Click(object sender, EventArgs e)
        {
            orderlistBindingSource.MoveFirst();
            顯示筆數統計();
        }

        private void btn最後一筆_Click(object sender, EventArgs e)
        {
            orderlistBindingSource.MoveLast();
            顯示筆數統計();
        }

        private void btn上一筆_Click(object sender, EventArgs e)
        {
            orderlistBindingSource.MovePrevious();
            顯示筆數統計();
        }

        private void btn下一筆_Click(object sender, EventArgs e)
        {
            orderlistBindingSource.MoveNext();
            顯示筆數統計();
        }

        private void btn進階搜尋_Click(object sender, EventArgs e)
        {
            if (txt欄位關鍵字.Text != "")
            {
                string str欄位關鍵字 = txt欄位關鍵字.Text;
                string str進階欄位名稱 = cbox進階欄位名稱.SelectedItem.ToString();
                orderlistBindingSource.Filter = $"{str進階欄位名稱} like '%{str欄位關鍵字}%'";

                顯示筆數統計();
            }
            else
            {
                MessageBox.Show("請輸入Filter關鍵字");
            }
        }

        private void listBox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listbox搜尋結果.SelectedIndex >= 0)
            //{
            //    int intSelectedID = SearchIDs[listbox搜尋結果.SelectedIndex];

            //    SqlConnection con = new SqlConnection(strCutePuppyConnectString);
            //    con.Open();
            //    string strSQL = "select * from Orderlist where CustomerID = @SearchID;";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read() == true)
            //    {
            //        lblID.Text = reader["CustomerID"].ToString();
            //        txtName.Text = reader["Name"].ToString();
            //        txtPassword.Text = reader["Password"].ToString();
            //        txtName.Text = reader["Gender"].ToString();
            //        txtPhone.Text = reader["Phone"].ToString();
            //        txtAddress.Text = reader["Address"].ToString();
            //        txtEmail.Text = reader["Email"].ToString();
            //        dtpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
            //    }
            //    else
            //    {
            //        MessageBox.Show("查無此人");
            //        清空欄位();
            //    }
            //    reader.Close();
            //    con.Close();
            //}

            //顯示筆數統計();
        }

        private void orderlistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderlistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cutePuppyDataSet2);

        }

        private void btn顧客資料維護系統_Click(object sender, EventArgs e)
        {
            FormMember myFormMember = new FormMember();
            myFormMember.ShowDialog();
            Close();
        }

        private void btn商品管理系統_Click(object sender, EventArgs e)
        {
            Product myProduct = new Product();
            myProduct.ShowDialog();
        }

        
    }
}
