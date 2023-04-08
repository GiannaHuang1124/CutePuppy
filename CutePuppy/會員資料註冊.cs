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
    public partial class 會員資料註冊 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strCutePuppyConnectString = "";
        List<int> SearchIDs = new List<int>(); //進階搜尋結果

        public string 會員姓名 = "";
        //public string 會員姓名 = $"{GlobalVar.str會員姓名}";

        public 會員資料註冊()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cutePuppyDataSet);

        }

        private void 會員資料註冊_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cutePuppyDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            //this.customerTableAdapter.Fill(this.cutePuppyDataSet.Customer);
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "CutePuppy"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strCutePuppyConnectString = scsb.ToString();

            cBox性別.Items.Add("男");
            cBox性別.Items.Add("女");
            cBox性別.Items.Add("自訂");
            cBox性別.SelectedIndex = 0;

        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPassword.Text != "") && (cBox性別.Text != "") && (txtPhone.Text != "") && (txtAddress.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "insert into Customer values (@NewName,@NewPassword,@NewGender,@NewBirth,@NewPhone,@NewAddress,@NewEmail);";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@NewGender", cBox性別.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);



                int rows = cmd.ExecuteNonQuery();
                con.Close();
                
            }
            else
            {
                MessageBox.Show("請輸入所有欄位");
            }

            MessageBox.Show("註冊成功!!歡迎光臨CutePuppy!!!");

            PuppyStoreForm myPuppyStore = new PuppyStoreForm();
            //myPuppyStore.會員姓名 = $"{GlobalVar.str會員姓名}";
            //myPuppyStore.會員姓名 = this.會員姓名;
            myPuppyStore.ShowDialog();
            Close();

        }
    }
}
