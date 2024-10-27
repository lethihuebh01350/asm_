using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASM1DATAE_BH01350
{
    public partial class FormCustomer : Form
    {
        private int total = 0;
        private int purchases = 0;
        private int score = 0;
        public FormCustomer(string total)
        {
            InitializeComponent();
            // Hiển thị giá trị total vào TextBox
            tbtotal4.Text = total;
            tbphone4.KeyPress += new KeyPressEventHandler(tbphone4_KeyPress);
        }

        public FormCustomer()
        {
        }

        private void tbtotal4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbname4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbphone4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số (chỉ cho phép số và ký tự điều khiển như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số, hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng chỉ nhập số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Không cho phép ký tự không hợp lệ
                e.Handled = true;
            }
        }       

        private void btadd4_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ ô Total và loại bỏ "VND" và dấu phẩy để chuyển sang số nguyên
                string sanitizedText = tbtotal4.Text.Replace("VND", "").Replace(",", "").Trim();
                int purchaseAmount = int.Parse(sanitizedText);

                // Cập nhật Total: cộng dồn tổng số tiền
                total += purchaseAmount;

                // Cập nhật số lần mua (Purchases): tăng số lượt mua lên 1 mỗi lần nhấn
                purchases += 1;

                // Tính số điểm (Score): lấy số tiền đã thanh toán cho giao dịch này chia cho 50,000 VND
                int score = purchaseAmount / 50000; // Điểm được tính từ purchaseAmount

                // Cập nhật vào DataGridView với các cột: Name, Phone, Purchases, Total, Score
                dgvform4.Rows.Add(tbname4.Text, tbphone4.Text, purchases, purchaseAmount.ToString("N0") + " VND", total.ToString("N0") + " VND", score.ToString("0"));

                // Hiển thị Total trong textbox
                tbtotal4.Text = total.ToString("N0") + " VND";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!");
            }
        }

        private void btedit4_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvform4.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvform4.SelectedRows[0];

                // Cập nhật giá trị của dòng đã chọn
                selectedRow.Cells["Name"].Value = tbname4.Text;
                selectedRow.Cells["Phone"].Value = tbphone4.Text;
                selectedRow.Cells["Total"].Value = tbtotal4.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            if (dgvform4.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa dòng đã chọn
                    dgvform4.Rows.RemoveAt(dgvform4.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btout4_Click(object sender, EventArgs e)
        {
            // Hộp thoại chọn Form
            DialogResult result = MessageBox.Show("Bạn muốn quay về Home (Form2) hay Product (Form3)?", "Chọn Form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Chuyển đến Form2 (Home)
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); // Ẩn Form4
            }
            else if (result == DialogResult.No)
            {
                // Chuyển đến Form3 (Product)
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide(); // Ẩn Form4
            }
        }
    }
}
