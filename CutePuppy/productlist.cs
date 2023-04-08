using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using customerlist;
using Orderlist;

namespace Productlist
{
    public partial class Product : Form
    {

        public int PID = 0;
        string strCutePuppyConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;

        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {


            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "CutePuppy";
            scsb.IntegratedSecurity = true;
            strCutePuppyConnectionString = scsb.ToString();



            //if (PID > 0)
            //{
            //    //修改模式
            //    groupBox新增.Visible = false;
            //    groupBox修改.Visible = true;
            //    顯示商品詳細資訊();
            //}
            //else
            //{
            //    //新增模式 
            //    groupBox新增.Visible = true;
            //    groupBox修改.Visible = false;
            //}
        }


        

        void 顯示商品詳細資訊()
        {
            SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
            con.Open();
            string strSQL = "select * from products where pid = @SearchPID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchPID", PID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                lblPID.Text = reader["pid"].ToString();
                txtPName.Text = reader["pname"].ToString();
                txtSellPrice.Text = reader["sellingPrice"].ToString();
                txtBuyPrice.Text = reader["buyPrice"].ToString();
                txt商品描述.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"查詢 {i} 筆資料.");
        }

        private void btn選取商品圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string fileExtension = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExtension;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txtPName.Text != "") && (txtSellPrice.Text != "") && (txtBuyPrice.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
                con.Open();
                string strSQL = "update products set pname=@NewPname, sellingPrice=@NewSellingPrice, buyPrice=@NewBuyPrice, pdesc=@NewPDesc, pimage=@NewPimage where pid=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", PID);
                cmd.Parameters.AddWithValue("@NewPname", txtPName.Text);
                int intSellPrice = 0;
                Int32.TryParse(txtSellPrice.Text, out intSellPrice);
                cmd.Parameters.AddWithValue("@NewSellingPrice", intSellPrice);
                int intBuyPrice = 0;
                Int32.TryParse(txtBuyPrice.Text, out intBuyPrice);
                cmd.Parameters.AddWithValue("@NewBuyPrice", intBuyPrice);
                cmd.Parameters.AddWithValue("@NewPDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"產品儲存修改成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填 !!");
            }
        }

        void 清空欄位()
        {
            lblPID.Text = "";
            txtPName.Clear();
            txtSellPrice.Clear();
            txtBuyPrice.Clear();
            txt商品描述.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txtPName.Text != "") && (txtSellPrice.Text != "") && (txtBuyPrice.Text !="") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
                con.Open();
                string strSQL = "Insert into products values(@NewPname, @NewSellingPrice, @NewBuyPrice, @NewPDesc, @NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txtPName.Text);
                int intSellPrice = 0;
                Int32.TryParse(txtSellPrice.Text, out intSellPrice);
                cmd.Parameters.AddWithValue("@NewSellingPrice", intSellPrice);
                int intBuyPrice = 0;
                Int32.TryParse(txtBuyPrice.Text, out intBuyPrice);
                cmd.Parameters.AddWithValue("@NewBuyPrice", intBuyPrice);
                cmd.Parameters.AddWithValue("@NewPDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"產品上架成功, 影響{rows}筆資料");


            }
            else
            {
                MessageBox.Show("所有欄位必填 !!");
            }
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txtPName.Text != "")
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
                con.Open();
                string strSQL = "select * from products where pname like @SearchPname;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchPname", "%" + txtPName.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                

                if (reader.Read() == true)
                {
                    lblPID.Text = reader["pid"].ToString();
                    txtPName.Text = reader["pname"].ToString();
                    txtSellPrice.Text = reader["sellingPrice"].ToString();
                    txtBuyPrice.Text = reader["buyPrice"].ToString();
                    txt商品描述.Text = reader["pdesc"].ToString();
                    image_name = reader["pimage"].ToString();
                    pictureBox商品圖檔.Image = Image.FromFile($"{image_dir}{image_name}");

                }
                else
                {
                    MessageBox.Show("查無此商品，請輸入正確資訊");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入產品名稱搜尋關鍵字");
            }

        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intPID = 0;
            Int32.TryParse(lblPID.Text, out intPID);

            if (intPID > 0)
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
                con.Open();
                string strSQL = "delete from products where pid = @DeletePID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeletePID", intPID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"({rows}個產品項目受到影響)");
            }
        }

        private void btn訂單維護系統_Click(object sender, EventArgs e)
        {
            FormOrderlist myOrderlist = new FormOrderlist();
            myOrderlist.ShowDialog();
        }

        private void btn顧客資料維護系統_Click(object sender, EventArgs e)
        {
            FormMember myFormMember = new FormMember();
            myFormMember.ShowDialog();
        }
    }
}

