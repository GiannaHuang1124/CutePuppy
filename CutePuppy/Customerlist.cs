using Orderlist;
using Productlist;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace customerlist
{
    public partial class FormMember : Form
    {
        SqlConnectionStringBuilder scsb;
        string strCutePuppyConnectString = "";
        List<int> SearchIDs = new List<int>(); //進階搜尋結果

        
        

        public FormMember()
        {
            InitializeComponent();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            //FormLogin myLoginForm = new FormLogin();
            //myLoginForm.ShowDialog();
            lblLoginInfo.Text = $"ID:{GlobalVar.str員工姓名} {GlobalVar.str員工帳號}";

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "CutePuppy"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strCutePuppyConnectString = scsb.ToString();

            cbox欄位名稱.Items.Add("Name");
            cbox欄位名稱.Items.Add("Gender");
            cbox欄位名稱.Items.Add("Phone");
            cbox欄位名稱.Items.Add("Address");
            cbox欄位名稱.Items.Add("Email");
            cbox欄位名稱.SelectedIndex = 0;

            cBoxGender.Items.Add("男");
            cBoxGender.Items.Add("女");
            cBoxGender.Items.Add("自訂");
            cBoxGender.SelectedIndex = 0;



            產生會員資料列表();

            //lblLoginInfo.Text = $"登入資訊 ID:{GlobalVar.memberID} Name:{GlobalVar.strLoginName} ";
        }

        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(strCutePuppyConnectString);
            con.Open();
            string strSQL = "select CustomerID as 會員編號, Name as 姓名, Gender as 性別, Birthday as 生日, Phone as 電話, Address as 地址, Email as 電子郵件 from Customer";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv會員資料預覽.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCutePuppyConnectString);
            con.Open();
            string strSQL = "select * from Customer";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int count = 0;

            while (reader.Read() == true)
            {
                int CustomerID = (int)reader["CustomerID"];
                string Name = reader["Name"].ToString();
                //string Gender = reader["Gender"].ToString();
                string Phone = reader["Phone"].ToString();
                string Email = reader["Email"].ToString();

                strMsg += $"{CustomerID} {Name}  {Phone} {Email} \n";
                count += 1;
            }

            strMsg += "資料筆數:" + count;
            reader.Close();
            con.Close();
            MessageBox.Show(strMsg);
        }

        //姓名搜尋
        private void btn資料搜尋_Click(object sender, EventArgs e)   
        {
            if (txtName.Text != "")
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "select * from Customer where Name like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txtName.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["CustomerID"].ToString();
                    txtName.Text = reader["Name"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    cBoxGender.Text = reader["Gender"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    dtpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋關鍵字");
            }
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txtName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            dtpBirthday.Value = DateTime.Now;
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {

            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txtName.Text != "") && (txtPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "update Customer set Name=@NewName, Password=@NewPassword, Gender=@NewGender, Phone=@NewPhone, Address=@NewAddress, Email=@NewEmail, Birthday=@NewBirth where CustomerID=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtName.Text);
                cmd.Parameters.AddWithValue("@NewGender", cBoxGender.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"({rows}個資料列受到影響)");
            }
        }


        //新增資料錯誤
        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "insert into Customer values (@NewName,@NewPassword,@NewGender,@NewBirth,@NewPhone,@NewAddress,@NewEmail);";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtName.Text);
                cmd.Parameters.AddWithValue("@NewGender", cBoxGender.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"({rows}個資料列受到影響)");
            }

        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {

                int intID = 0;
                Int32.TryParse(lblID.Text, out intID);

                if (intID > 0)
                {
                    SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                    con.Open();
                    string strSQL = "delete from Customer where CustomerID = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    清空欄位();
                    MessageBox.Show($"({rows}個資料列受到影響)");
                }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
                清空欄位();
        }
        
        
        //進階搜尋
        private void btn搜尋_Click(object sender, EventArgs e)
        {
            
            listbox搜尋結果.Items.Clear();
            SearchIDs.Clear();
            string 欄位名稱 = cbox欄位名稱.SelectedItem.ToString();

            if (txt欄位關鍵字.Text != "")
            {
                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "select * from Customer where " + 欄位名稱 + " like @SearchKeyword and Birthday <= @BirthEnd and Birthday >= @BirthStart " ;
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", "%" + txt欄位關鍵字.Text + "%");
                cmd.Parameters.AddWithValue("@BirthEnd", dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@BirthStart", dtp開始時間.Value);
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    SearchIDs.Add((int)reader["CustomerID"]);
                    listbox搜尋結果.Items.Add($"{(int)reader["CustomerID"]} {reader["Name"].ToString()} {reader["Gender"].ToString()}{reader["Phone"].ToString()}");
                    count += 1;
                }

                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入, 欄位查詢關鍵字");
            }

        }

        private void listbox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbox搜尋結果.SelectedIndex >= 0)
            {
                int intSelectedID = SearchIDs[listbox搜尋結果.SelectedIndex];

                SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                con.Open();
                string strSQL = "select * from Customer where CustomerID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["CustomerID"].ToString();
                    txtName.Text = reader["Name"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    txtName.Text = reader["Gender"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    dtpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }

        private void dgv會員資料預覽_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv會員資料預覽.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strCutePuppyConnectString);
                    con.Open();
                    string strSQL = "select * from Customer where CustomerID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblID.Text = reader["CustomerID"].ToString();
                        txtName.Text = reader["Name"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        cBoxGender.Text = reader["Gender"].ToString();
                        txtPhone.Text = reader["Phone"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        dtpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btn商品管理系統_Click(object sender, EventArgs e)
        {
            Product myProduct = new Product();
            myProduct.ShowDialog();
        }
        private void btn訂單維護系統_Click(
            object sender, EventArgs e)
        {
            FormOrderlist myOrderlist = new FormOrderlist();
            myOrderlist.ShowDialog();
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            //txtName.Clear();
            //txtPassword.Clear();
            //txtPhone.Clear();
            //txtAddress.Clear();
            //txtEmail.Clear();

            //讀取資料庫();
        }
    
    }
}
