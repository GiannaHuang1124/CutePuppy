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

namespace PuppyStore
{
    public partial class ShopCar : Form
    {
        public int PID = 0;
        public int OID = 0;
        string strCutePuppyConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        //bool is已修改圖檔 = false;

        public ShopCar()
        {
            InitializeComponent();
        }

        

        private void ShopCar_Load(object sender, EventArgs e)
        {
   
            cbox取貨方式.Items.Add("宅配");
            cbox取貨方式.Items.Add("超商取貨");
            cbox取貨方式.SelectedIndex = 0;

            cbox付款方式.Items.Add("信用卡");
            cbox付款方式.Items.Add("ATM轉帳");
            cbox付款方式.SelectedIndex = 0;

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            strCutePuppyConnectionString = scsb.ToString();

        }

        void 顯示商品詳細資訊()
        {
            SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
            con.Open();
            string strSQL = "select * from products where pid = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", PID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                lblPID.Text = reader["pid"].ToString();
                txt商品名稱.Text = reader["pname"].ToString();
                txt總計金額.Text = reader["sellingPrice"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }

        private void btn確定_Click(object sender, EventArgs e)
        {
            //    if ((cbox取貨方式.Text != "") && (cbox付款方式.Text != ""))
            //    {
            //        if (is已修改圖檔 == true)
            //        {
            //            pictureBox商品圖檔.Image.Save(image_dir + image_name);
            //            is已修改圖檔 = false;
            //        }

            //        SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
            //        con.Open();
            //        string strSQL = "update Orderlist set 取貨方式=@NewPDeliver, 付款方式=@NewPay where OID=@SearchID;";
            //        SqlCommand cmd = new SqlCommand(strSQL, con);
            //        cmd.Parameters.AddWithValue("@SearchID", OID);
            //        cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
            //        int intPrice = 0;
            //        Int32.TryParse(txt商品價格.Text, out intPrice);
            //        cmd.Parameters.AddWithValue("@NewPrice", intPrice);
            //        cmd.Parameters.AddWithValue("@NewPDesc", txt商品描述.Text);
            //        cmd.Parameters.AddWithValue("@NewPimage", image_name);
            //        int rows = cmd.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show($"資料儲存成功, 影響{rows}筆資料");
            //    }
            //    else
            //    {
            //        MessageBox.Show("請選擇取貨方式及付款方式 !!");
            //    }



            //Delivery myDelivery = new Delivery();
            //myDelivery.ShowDialog();


        }
    }
}
