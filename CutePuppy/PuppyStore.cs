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

namespace CutePuppy
{
    public partial class PuppyStoreForm : Form
    {
        string strCutePuppyDBConnectionString = "";
        SqlConnectionStringBuilder scsb;
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPID = new List<int>();
        //public string 會員帳號 = $"{GlobalVar.str會員帳號}";
        //public string 會員姓名 = $"{GlobalVar.str會員姓名}"; 
        public string 會員姓名 = "";

        public PuppyStoreForm()
        {
            InitializeComponent();
        }

        private void PuppyStoreForm_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "CutePuppy";
            scsb.IntegratedSecurity = true;
            strCutePuppyDBConnectionString = scsb.ToString();

            lbl會員姓名.Text = 會員姓名;
            讀取資料庫();
            展示listView商品圖片模式();


            //lbl會員姓名.Text = $"ID:{GlobalVar.str會員帳號} {GlobalVar.str會員姓名} ";
        }

        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strCutePuppyDBConnectionString);
            con.Open();
            string strSQL = "select * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\"; //圖檔目錄
            string image_name = ""; //圖檔名稱
            int i = 0;

            while (reader.Read())
            {
                listPID.Add((int)reader["pid"]);
                listPname.Add(reader["pname"].ToString());
                //int a = (int)reader["sellingPrice"];
                listPrice.Add((int)reader["sellingPrice"]);
                image_name = reader["pimage"].ToString();
                Image myProductImage = Image.FromFile(image_dir + image_name);
                imageList產品圖檔.Images.Add(myProductImage);
                i += 1;
            }
            
            reader.Close();
            con.Close();
        }

        void 展示listView商品圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile
            imageList產品圖檔.ImageSize = new Size(240, 240);
            listView商品展示.LargeImageList = imageList產品圖檔; //LargeIcon, Tile
            listView商品展示.SmallImageList = imageList產品圖檔; //SmallIcon, List

            for (int i = 0; i < imageList產品圖檔.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listPname[i] + " " + listPrice[i] + "元";
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            ShopCar myShopCar = new ShopCar();
            //myShopCar.會員姓名 = $"{GlobalVar.str會員姓名}";
            myShopCar.會員姓名 = this.會員姓名;
            myShopCar.PID = (int)listView商品展示.SelectedItems[0].Tag;
            myShopCar.ShowDialog();
        }

        private void btn登入會員_Click(object sender, EventArgs e)
        {
            //會員登入 my會員登入Form = new 會員登入();
            //my會員登入Form.ShowDialog();

        }

        private void btn註冊會員_Click(object sender, EventArgs e)
        {
            //會員資料註冊 my會員資料註冊 = new 會員資料註冊();
            //my會員資料註冊.ShowDialog();
        }
    }
}
