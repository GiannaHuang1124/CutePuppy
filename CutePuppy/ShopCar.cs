using customerlist;
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
using System.Xml.Linq;

namespace CutePuppy
{
    public partial class ShopCar : Form
    {
        public int PID = 0;
        string strCutePuppyDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        public string 會員姓名 = "";
        //public int lblsellPrice2 = 0;

     
        public ShopCar()
        {
            InitializeComponent();
        }

        private void ShopCar_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cutePuppyDataSet.products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.cutePuppyDataSet.products);
            // TODO: 這行程式碼會將資料載入 'cutePuppyDataSet.Orderlist' 資料表。您可以視需要進行移動或移除。
            //this.orderlistTableAdapter.Fill(this.cutePuppyDataSet.Orderlist);
            // TODO: 這行程式碼會將資料載入 'cutePuppyDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            //this.customerTableAdapter.Fill(this.cutePuppyDataSet.Customer);

            lbl會員姓名.Text = $"{GlobalVar.str會員帳號} {GlobalVar.str會員姓名} ";



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

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "CutePuppy";
            scsb.IntegratedSecurity = true;
            strCutePuppyDBConnectionString = scsb.ToString();

            顯示商品詳細資訊();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cutePuppyDataSet);

        }

        void 顯示商品詳細資訊()
        {
            SqlConnection con = new SqlConnection(strCutePuppyDBConnectionString);
            con.Open();
            string strSQL = "select * from products where pid = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", PID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                lblPID.Text = reader["pid"].ToString();
                lblpname.Text = reader["pname"].ToString();
                lblsellPrice.Text = reader["sellingPrice"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }

        private void btn我要購買_Click(object sender, EventArgs e)
        {
            //新增資料
            //orderlistBindingSource.AddNew();
            if ((txtConName.Text != "") && (txtConPhone.Text != "") && (txtConAddress.Text != ""))
            {
                SqlConnection chkcon = new SqlConnection(strCutePuppyDBConnectionString);
                chkcon.Open();

                string strSQL2 = "select CustomerID from Orderlist where 會員姓名=@New會員姓名;";
                SqlCommand chk = new SqlCommand(strSQL2, chkcon);
                chk.Parameters.AddWithValue("@New會員姓名", 會員姓名);
                SqlDataReader reader = chk.ExecuteReader();

                int CustomerID = 0;

                //總計金額 = Int32.Parse(lblsellPrice.Text);

                //打開Orderlist
                SqlConnection con = new SqlConnection(strCutePuppyDBConnectionString);
                con.Open();


                if (reader.Read())
                {
                    CustomerID = (int)reader["CustomerID"];
                }


                string strSQL = "insert into Orderlist values (@NewCustomerID,@NewName,@NewConName,@NewConPhone,@NewAddress,@New出貨進度,@New商品名稱,@New取貨方式,@New付款方式,@New出貨日期,@New總計金額);";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewCustomerID", lblID.Text);
                cmd.Parameters.AddWithValue("@NewName", lbl會員姓名.Text);
                cmd.Parameters.AddWithValue("@NewConName", txtConName.Text);
                cmd.Parameters.AddWithValue("@NewConPhone", txtConPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtConAddress.Text);
                cmd.Parameters.AddWithValue("@New出貨進度", cbox出貨進度.Text);
                cmd.Parameters.AddWithValue("@New商品名稱", lblpname.Text);
                cmd.Parameters.AddWithValue("@New取貨方式", cbox取貨方式.Text);
                cmd.Parameters.AddWithValue("@New付款方式", cbox付款方式.Text);
                cmd.Parameters.AddWithValue("@New出貨日期", dtp出貨日期.Text);
                cmd.Parameters.AddWithValue("@New總計金額", lblsellPrice.Text);




                int rows = cmd.ExecuteNonQuery();
                reader.Close();
                con.Close();
               
                //MessageBox.Show($"({rows}個資料列受到影響)");

                MessageBox.Show("感謝購買，歡迎下次再來!!");
            }
        }

        private void brn清除重填_Click(object sender, EventArgs e)
        {

        }
    }
}
