using CutePuppy;
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

namespace customerlist
{
    public partial class 員工登入 : Form
    {

        SqlConnectionStringBuilder scsb;
        string strCutePuppyConnectString = "";

        bool isLoginOK = false;



        public 員工登入()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "CutePuppy"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strCutePuppyConnectString = scsb.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtMember.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "select * from Staff where Account=@SearchAccount and Password=@SearchPassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchAccount", txtMember.Text);
                cmd.Parameters.AddWithValue("@SearchPassword", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                isLoginOK = true;

                if (reader.Read() == true)
                {
                    //lblID.Text = reader["CustomerID"].ToString();
                    txtMember.Text = reader["Account"].ToString();
                    txtPassword.Text = reader["Password"].ToString();

                    string strMember = txtMember.Text;


                    if (isLoginOK)
                    {
                        MessageBox.Show("登入成功!!");

                        GlobalVar.str員工帳號 = strMember;

                        FormMember my會員資料維護系統 = new FormMember();
                        my會員資料維護系統.ShowDialog();

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
                    //清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼!");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoginOK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
