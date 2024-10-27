using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1DATAE_BH01350
{
    public partial class FormUser : Form
    {
        string connectionstring = @"Data Source=LAPTOP-IG12I1HR\SQLEXPRESS;Initial Catalog = ASMDATA; Integrated Security = True; TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public FormUser()
        {
            InitializeComponent();
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring); // Khởi tạo kết nối với cơ sở dữ liệu
            try
            {
                con.Open(); // Mở kết nối
                cmd = new SqlCommand("select * from Product", con); // Tạo lệnh SQL để lấy tất cả sản phẩm
                adt = new SqlDataAdapter(cmd); // Tạo SqlDataAdapter từ lệnh
                adt.Fill(dt); // Điền dữ liệu vào DataTable
                dgv_User.DataSource = dt; // Gán DataTable cho DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hiển thị thông báo lỗi nếu có
            }
            finally
            {
                con.Close(); // Đóng kết nối
            }
        }

        private void dgv_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu chỉ số dòng hợp lệ
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_User.Rows[e.RowIndex];

                // Hiển thị dữ liệu trong TextBox
                try
                {
                    // Gán giá trị từ dòng được chọn vào các TextBox tương ứng
                    txtB_idUser.Text = selectedRow.Cells["ProductID"].Value.ToString();
                    txtB_nameUser.Text = selectedRow.Cells["Name"].Value.ToString();
                    cbB_sizeUser.Text = selectedRow.Cells["Size"].Value.ToString();
                   txtB_priceUser.Text = selectedRow.Cells["Price"].Value.ToString();
                    txtB_quantity.Text = selectedRow.Cells["quantity"].Value.ToString();

                    // Hiển thị hình ảnh trong PictureBox
                    if (selectedRow.Cells["Image"].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])selectedRow.Cells["Image"].Value; // Lấy dữ liệu hình ảnh
                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData)) // Chuyển đổi byte array thành hình ảnh
                            {
                                picB_imageUser.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            picB_imageUser.Image = null; // Hoặc hình ảnh mặc định
                        }
                    }
                    else
                    {
                        picB_imageUser.Image = null; // Hoặc hình ảnh mặc định
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message); // Hiển thị thông báo lỗi nếu có
                }
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(cbB_sizeUser.Text) && !string.IsNullOrEmpty(txtB_purchaseUser.Text)) 
            {
                int productID = int.Parse(txtB_idUser.Text);
                int purchase = int.Parse(txtB_purchaseUser.Text);
                int quantity = int.Parse(txtB_quantity.Text);
                decimal price = decimal.Parse(txtB_priceUser.Text);
                decimal total = price * purchase;
                if (purchase > quantity) 
                {
                    MessageBox.Show("Số lượng đặt mua nhiều hơn số lượng sản phẩm trong kho. Không thể thanh toán", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_total.Enabled = false;
                }
                else 
                {
                    txtB_totalUser.Text = total.ToString();
                    btn_total.Enabled = true;
                }

            }
            else 
            {
                txtB_totalUser.Text = "";
                btn_total.Enabled = false;
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(txtB_idUser.Text);
            decimal price = decimal.Parse(txtB_priceUser.Text);
            int purchase = int.Parse(txtB_purchaseUser.Text);
            decimal total = price * purchase;
            MessageBox.Show($"Paying {total} for {purchase} item of prodcut {productID}.");
        }
    }
}
