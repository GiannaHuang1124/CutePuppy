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
    public partial class 會員登入 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strCutePuppyConnectString = "";

        bool is認證成功 = false;
        //public string 會員姓名 = "";
        //public string 會員帳號 = $"{GlobalVar.str會員帳號}";
        public string 會員姓名 = $"{GlobalVar.str會員姓名}";

        public 會員登入()
        {
            InitializeComponent();
        }

        private void 會員登入_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "CutePuppy"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strCutePuppyConnectString = scsb.ToString();
        }

        private void txtMember_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtMember.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "select * from Customer where Phone=@SearchPhone and Password=@SearchPassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchPhone", txtMember.Text);
                cmd.Parameters.AddWithValue("@SearchPassword", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                is認證成功 = true;


                if (reader.Read() == true)
                {
                    if (is認證成功)
                    {
                        會員姓名 = reader["Name"].ToString();
                        MessageBox.Show("登入成功!!");

                        //GlobalVar.str會員帳號 = strMember;


                        PuppyStoreForm myPuppyStore = new PuppyStoreForm();
                        //myPuppyStore.會員姓名 = this.會員姓名;
                        myPuppyStore.會員姓名 = $"{GlobalVar.str會員姓名}";
                        myPuppyStore.ShowDialog();

                        Close();

                    }
                    else
                    {
                        MessageBox.Show("登入失敗!!");
                    }
                }
                else
                {
                    MessageBox.Show("帳號密碼錯誤!!");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼!");
            }
        }

        void 清空欄位()
        {
            txtMember.Clear();
            txtPassword.Clear();
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            會員資料註冊 my註冊 = new 會員資料註冊();
            my註冊.ShowDialog();
            Close();
        }

        //private void 會員登入_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (is認證成功)
        //    {
        //        e.Cancel = false;
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}
