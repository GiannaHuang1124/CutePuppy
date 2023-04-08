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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PuppyStore
{
    public partial class PuppyStore : Form
    {

        string strCutePuppyConnectionString = "";
        List<string> listPname = new List<string>();
        List<string> listPdesc = new List<string>();
        List<int> listSellPrice = new List<int>();
        List<int> listPID = new List<int>();

        public PuppyStore()
        {
            InitializeComponent();
        }

        private void PuppyStore_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "CutePuppy";
            scsb.IntegratedSecurity = true;
            strCutePuppyConnectionString = scsb.ToString();

            讀取資料庫();
            展示listView商品();
        }

        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strCutePuppyConnectionString);
            con.Open();
            string strSQL = "select * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"D:\期中專題\CutePuppy\Products\bin\Debug\images\"; //圖檔目錄
            string image_name = ""; //圖檔名稱
            int i = 0;

            while (reader.Read())
            {
                listPID.Add((int)reader["pid"]);
                listPname.Add(reader["pname"].ToString());
                listSellPrice.Add((int)reader["sellingPrice"]);
                listPdesc.Add(reader["pdesc"].ToString());
                image_name = reader["pimage"].ToString();
                Image myProductImage = Image.FromFile(image_dir + image_name);
                imageList產品圖檔.Images.Add(myProductImage);
                i += 1;
            }
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();

            //結帳畫面 my結帳畫面 = new 結帳畫面();
            //my結帳畫面.ShowDialog();
        }

        void 展示listView商品()
        {
            listView商品.Clear();
            listView商品.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile
            imageList產品圖檔.ImageSize = new Size(80, 80);
            listView商品.LargeImageList = imageList產品圖檔; //LargeIcon, Tile
            listView商品.SmallImageList = imageList產品圖檔; //SmallIcon, List

            for (int i = 0; i < imageList產品圖檔.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listPname[i] + " " + listSellPrice[i] + "元";
                item.Tag = listPID[i];
                listView商品.Items.Add(item);
            }
        }
    }
}



