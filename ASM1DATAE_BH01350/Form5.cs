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
    public partial class Employee : Form
    {
        List<Employee> employees = new List<Employee>();
        int currentIndex = -1;
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }  // If you have salary too

        public Employee()
        {
            InitializeComponent();

        }
        private void DisplayEmployee(int index)
        {
            if (index >= 0 && index < employees.Count)
            {
                // Lấy đối tượng Employee tại chỉ số 'index' từ danh sách 'employees'
                Employee employee = employees[index];

                // Hiển thị thông tin của nhân viên lên các textbox
                txtName.Text = employee.Name;
                txtPhone.Text = employee.Phone;
                txtEmail.Text = employee.Email;
                txtPosition.Text = employee.Position;
                dateTimePickerHireDate.Value = employee.HireDate;
                txtSalary.Text = employee.Salary.ToString();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btadd5_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that no fields are left empty
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPosition.Text) ||
                    string.IsNullOrWhiteSpace(txtSalary.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Collect data from input fields
                Employee employee = new Employee
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Position = txtPosition.Text,
                    HireDate = dateTimePickerHireDate.Value,
                };

                // Parse Salary as decimal
                if (decimal.TryParse(txtSalary.Text, out decimal salary))
                {
                    employee.Salary = salary;
                }
                else
                {
                    MessageBox.Show("Please enter a valid salary (numeric).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add employee to the list
                employees.Add(employee);
                currentIndex = employees.Count - 1;

                // Add the new employee to the DataGridView
                dataGridView1.Rows.Add(
                    employee.Name,
                    employee.Phone,
                    employee.Email,
                    employee.Position,
                    employee.HireDate.ToString("MMMM dd, yyyy"),  // Format the HireDate
                    employee.Salary.ToString("N2")                // Format salary to 2 decimal places
                );

                // Display the new employee
                DisplayEmployee(currentIndex);

                // Show success message
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Catch and display any unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btedit5_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < employees.Count)
            {
                try
                {
                    // Validate inputs
                    if (string.IsNullOrWhiteSpace(txtName.Text) ||
                        string.IsNullOrWhiteSpace(txtPhone.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text) ||
                        string.IsNullOrWhiteSpace(txtPosition.Text) ||
                        string.IsNullOrWhiteSpace(txtSalary.Text))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                    // Edit the selected employee
                    Employee employee = employees[currentIndex];
                    employee.Name = txtName.Text;
                    employee.Phone = txtPhone.Text;
                    employee.Email = txtEmail.Text;
                    employee.Position = txtPosition.Text;
                    employee.HireDate = dateTimePickerHireDate.Value;
                    employee.Salary = Convert.ToDecimal(txtSalary.Text);

                    // Refresh the display
                    DisplayEmployee(currentIndex);

                    MessageBox.Show("Employee details updated successfully.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid salary.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btclear5_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtPosition.Clear();
            txtSalary.Clear();
            dateTimePickerHireDate.Value = DateTime.Now;
        }

        private void btout5_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayEmployee(currentIndex);
            }
        }

        private void btnext5_Click(object sender, EventArgs e)
        {
            if (currentIndex < employees.Count - 1)
            {
                currentIndex++;
                DisplayEmployee(currentIndex);
            }

            // Hiển thị thông báo lựa chọn trang
            DialogResult result = MessageBox.Show(
                "Chọn trang tiếp theo:\n1. Customer\n2. Product\n3. User\n4. Statistic",
                "Chọn Trang",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            // Xử lý lựa chọn của người dùng
            if (result == DialogResult.Yes)  // Giả sử "Yes" tương ứng với Customer
            {
                FormCustomer customerForm = new FormCustomer();  // Mở Form 4
                customerForm.Show();
            }
            else if (result == DialogResult.No)  // Giả sử "No" tương ứng với Product
            {
                Form3 productForm = new Form3();  // Mở Form 3
                productForm.Show();
            }
            else if (result == DialogResult.Cancel)  // Nếu người dùng nhấn "Cancel", mở User hoặc Statistic
            {
                // Hiển thị thêm lựa chọn
                DialogResult secondChoice = MessageBox.Show(
                    "Bạn muốn chọn User hay Statistic?\n1. User\n2. Statistic",
                    "Chọn Trang",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (secondChoice == DialogResult.Yes)
                {
                    FormUser userForm = new FormUser();  // Mở Form 7
                    userForm.Show();
                }
                else if (secondChoice == DialogResult.No)
                {
                    LoadStatistics statisticForm = new LoadStatistics();  // Mở Form 6
                    statisticForm.Show();
                }
            }
        }
       

    }
}
