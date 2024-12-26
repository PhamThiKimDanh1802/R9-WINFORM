using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace MYAPP
{
    public partial class FrmDoUong : Form


    {
        SqlConnection con;
        SqlDataAdapter adapter;
        DataSet ds;
        string connectionString = "Server=DESKTOP-D6GG4N0;Database=Banhang;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public FrmDoUong()
        {
            InitializeComponent();
        }
        private void ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection Successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection Failed: {ex.Message}");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TenDoUong_Click(object sender, EventArgs e)
        {

        }

        private void FormDoUong_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sQuery = "SELECT * FROM DoUong";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "DoUong");

                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = ds.Tables["DoUong"];
                    }
                    else
                    {
                        MessageBox.Show("DataGridView chưa được khởi tạo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void FormDoUong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Tạm Biệt! Hẹn Gặp Lại Lần sau!", "Thông Báo!!!");
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sMaDoUong = txtMaDoUong.Text.Trim();
                    string sTenDoUong = txtTenDoUong.Text.Trim();
                    string sGia = txtGia.Text.Trim();
                    string sKichCo = txtKichCo.Text.Trim();

                    if (string.IsNullOrWhiteSpace(sMaDoUong) || string.IsNullOrWhiteSpace(sTenDoUong) ||
                        string.IsNullOrWhiteSpace(sGia) || string.IsNullOrWhiteSpace(sKichCo))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return;
                    }

                    if (!decimal.TryParse(sGia, out decimal gia))
                    {
                        MessageBox.Show("Giá phải là một số hợp lệ.");
                        return;
                    }

                    string checkQuery = "SELECT COUNT(*) FROM DoUong WHERE MaDoUong = @MaDoUong";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@MaDoUong", sMaDoUong);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Mã đồ uống đã tồn tại.");
                        return;
                    }

                    string sQuery = "INSERT INTO DoUong (MaDoUong, TenDoUong, Gia, KichCo) VALUES (@MaDoUong, @TenDoUong, @Gia, @KichCo)";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@MaDoUong", sMaDoUong);
                    cmd.Parameters.AddWithValue("@TenDoUong", sTenDoUong);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@KichCo", sKichCo);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xảy ra lỗi trong quá trình thêm mới: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) 
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtMaDoUong.Text = row.Cells["MaDoUong"].Value.ToString();
                    txtTenDoUong.Text = row.Cells["TenDoUong"].Value.ToString();
                    txtGia.Text = row.Cells["Gia"].Value.ToString();
                    txtKichCo.Text = row.Cells["KichCo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi: {ex.Message}");
            }
            txtMaDoUong.Enabled = false;
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sMaDoUong = txtMaDoUong.Text.Trim();
                    string sTenDoUong = txtTenDoUong.Text.Trim();
                    string sGia = txtGia.Text.Trim();
                    string sKichCo = txtKichCo.Text.Trim();

                    if (string.IsNullOrWhiteSpace(sTenDoUong) || string.IsNullOrWhiteSpace(sGia) || string.IsNullOrWhiteSpace(sKichCo))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin (trừ Mã Đồ Uống).");
                        return;
                    }

                    if (!decimal.TryParse(sGia, out decimal gia))
                    {
                        MessageBox.Show("Giá phải là một số hợp lệ.");
                        return;
                    }

                    string sQuery = "UPDATE DoUong SET TenDoUong = @TenDoUong, Gia = @Gia, KichCo = @KichCo WHERE MaDoUong = @OriginalMaDoUong";
                    SqlCommand cmd = new SqlCommand(sQuery, con);

                    cmd.Parameters.AddWithValue("@OriginalMaDoUong", txtMaDoUong.Text.Trim()); 
                    cmd.Parameters.AddWithValue("@TenDoUong", sTenDoUong);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@KichCo", sKichCo);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        txtTenDoUong.Text = "";
                        txtGia.Text = "";
                        txtKichCo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã đồ uống để cập nhật.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xảy ra lỗi trong quá trình cập nhật: {ex.Message}");
                }
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string maDoUong = txtMaDoUong.Text.Trim();

                    if (string.IsNullOrEmpty(maDoUong))
                    {
                        MessageBox.Show("Vui lòng chọn một bản ghi để xóa.");
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa đồ uống này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    string query = "DELETE FROM DoUong WHERE MaDoUong = @MaDoUong";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaDoUong", maDoUong);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa bản ghi thành công!");
                        LoadDataGridView();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa bản ghi: {ex.Message}");
                }
            }
        }
        private void LoadDataGridView()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM DoUong";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "DoUong");
                    dataGridView1.DataSource = ds.Tables["DoUong"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                }
            }
        }
        private void ClearTextBoxes()
        {
            txtMaDoUong.Text = "";
            txtTenDoUong.Text = "";
            txtGia.Text = "";
            txtKichCo.Text = "";
        }
    }
}
