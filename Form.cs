using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HelpMe
{
    public partial class Form : System.Windows.Forms.Form
    {
        ArrayList OrderList = new ArrayList();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // do nothing
        }

        private void btnDBCheck_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SQL.CONSTRING))
                {
                    con.Open();
                    MessageBox.Show("성공", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error.\n" + SQL.CONSTRING, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMango1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.DELETE_MANGO01;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Mango01 아이디가 초기화 되었습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMango2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.DELETE_MANGO02;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Mango02 아이디가 초기화 되었습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNoTerminal_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add("망고 주문번호");
            dt.Columns.Add("주소1");
            dt.Columns.Add("주소2");

            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.SELECT_NO_TERMINAL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = ++i;
                            dr[1] = (reader["ExternOrderKey"] == null) ? "" : reader["ExternOrderKey"].ToString();
                            dr[2] = (reader["C_Address2"] == null) ? "" : reader["C_Address2"].ToString();
                            dr[3] = (reader["C_Address3"] == null) ? "" : reader["C_Address3"].ToString();
                            dt.Rows.Add(dr);
                        }
                    }
                }
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean IsOrderExist(String orderID)
        {
            Boolean result = false;
            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.SELECT_ORDER;
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = (reader["orderkey"] == null) ? false : true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check order key
            if(String.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("망고 오더 아이디를 입력하세요.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // check address
            if (txtBoxAddress2.TextLength == 0)
            {
                MessageBox.Show("주소를 입력해 주세요.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // check address length
            if (txtBoxAddress2.TextLength > 45 || txtBoxAddress3.TextLength > 45)
            {
                MessageBox.Show("최대 45글자까지 입력할수 있습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // check order key
            if (!IsOrderExist(txtOrderID.Text))
            {
                MessageBox.Show("망고 주문 아이디가 존재하지 않습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // update transmitlog2
            Update_C_Address2();
            Update_C_Address3();
            Update_Transmitlog2(Select_OrderKey());
            MessageBox.Show("주소가 변경되었습니다. CJ에서 터미널 코드를 받아오는데 3분정도 소요됩니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset input field
            txtOrderID.Text = "";
            txtBoxAddress2.Text = "";
            txtBoxAddress3.Text = "";

            // Update Datagrid view
            UpdateDataGridView();
        }

        private void Update_C_Address2()
        {
            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.UPDATE_C_Address2;
                    cmd.Parameters.AddWithValue("@C_Address2", txtBoxAddress2.Text);
                    cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_C_Address3()
        {
            if(string.IsNullOrEmpty(txtBoxAddress3.Text))
                return;
            
            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.UPDATE_C_Address3;
                    cmd.Parameters.AddWithValue("@C_Address3", txtBoxAddress3.Text);
                    cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Transmitlog2(string orderKey)
        {
            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.UPDATE_TRANSMITLOG2;
                    cmd.Parameters.AddWithValue("@orderKey", orderKey);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Select_OrderKey()
        {
            string result = string.Empty;
            try
            {
                using (var conn = new SqlConnection(SQL.CONSTRING))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL.SELECT_ORDER;
                    cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader["orderkey"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
