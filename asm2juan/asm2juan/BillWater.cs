using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm2juan
{
    public partial class BillWater : Form
    {
        
        private bool sortAscending = true;

        List<string> listCustomerType = new List<string>() { "Household customer", "Administrative agency, public services", "Production units", "Business services" };

        public BillWater()
        {
            InitializeComponent();
            BtnSort.Click += new EventHandler(btnSort_Click);
        }

        private void BillWater_Load(object sender, EventArgs e)
        {
            cbxCustomerType.DataSource = listCustomerType;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCaculate_Click(object sender, EventArgs e)
        {
            string customerName = tbxCustomerName.Text;
            int lastMonthReading = int.Parse(tbxLastMonthReading.Text);
            int thisMonthReading = int.Parse(tbxThisMonthReading.Text);
            int customerType = cbxCustomerType.SelectedIndex + 1;
            int numberOfPeople = (int)nudNumberOfPeople.Value;
            if (thisMonthReading < lastMonthReading)
            {
                MessageBox.Show("Warning. The number of water last month could not be more than the number of countries this month. ", "Notice to you");
                return;
            }

            // Tính lượng tiêu thụ
            int consumption = thisMonthReading - lastMonthReading;

            // Tính hóa đơn nước
            double totalBill = CalculateBill(customerType, consumption, numberOfPeople);

            // Hiển thị kết quả
            tbxResult.Text = $"Customer Name: {customerName}\r\n" +
                             $"Last Month's Reading: {lastMonthReading}\r\n" +
                             $"This Month's Reading: {thisMonthReading}\r\n" +
                             $"Consumption: {consumption} m3\r\n" +
                             $"TotalBill: {totalBill.ToString("0.00")} VND";
        }

        private double CalculateBill(int customerType, int consumption, int numberOfPeople)
        {
            double pricePerM3 = 0;
            double environmentFeePerM3 = 0;

            switch (customerType)
            {
                case 1: // Hộ gia đình
                    pricePerM3 = CalculateHouseholdBill(numberOfPeople, consumption, out environmentFeePerM3);
                    break;
                case 2: // Cơ quan hành chính, dịch vụ công cộng
                    pricePerM3 = 9.955;
                    environmentFeePerM3 = 0.9955;
                    break;
                case 3: // Đơn vị sản xuất
                    pricePerM3 = 11.615;
                    environmentFeePerM3 = 1.1615;
                    break;
                case 4: // Dịch vụ kinh doanh
                    pricePerM3 = 22.068;
                    environmentFeePerM3 = 2.2068;
                    break;
                default:
                    MessageBox.Show("Customer Type Not Available", " Warning ");
                    break;
            }
            double totalWithoutVAT = (pricePerM3 + environmentFeePerM3) * consumption;
            double VAT = totalWithoutVAT * 0.10;
            double totalWithVAT = totalWithoutVAT + VAT;

            return totalWithVAT;
        }

        private double CalculateHouseholdBill(int numberOfPeople, int consumption, out double environmentFeePerM3)
        {
            environmentFeePerM3 = 0;
            double totalBill = 0;
            double pricePerM3;

            for (int i = 0; i < numberOfPeople; i++)
            {
                int consumptionPerPerson = consumption / numberOfPeople;
                if (consumptionPerPerson <= 10)
                {
                    pricePerM3 = 5.973;
                    environmentFeePerM3 += 0.5973;
                }
                else if (consumptionPerPerson <= 20)
                {
                    pricePerM3 = 7.052;
                    environmentFeePerM3 += 0.7052;
                }
                else if (consumptionPerPerson <= 30)
                {
                    pricePerM3 = 8.699;
                    environmentFeePerM3 += 0.8669;
                }
                else
                {
                    pricePerM3 = 15.929;
                    environmentFeePerM3 += 1.5929;
                }
                totalBill += pricePerM3 * consumptionPerPerson;

            }

            return totalBill;
        }

        private void lsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dinh nghia 4 cot cua listview
            lsv.Columns[0].Width = (int)(lsv.Width * 0.20);
            lsv.Columns[1].Width = (int)(lsv.Width * 0.20);
            lsv.Columns[2].Width = (int)(lsv.Width * 0.20);
            lsv.Columns[3].Width = (int)(lsv.Width * 0.20);
            lsv.Columns[4].Width = (int)(lsv.Width * 0.20);
            lsv.Columns[5].Width = (int)(lsv.Width * 0.13);
            lsv.View = View.Details;
            lsv.GridLines = true;
            lsv.FullRowSelect = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsv.SelectedItems.Count > 0)
            {
                lsv.Items.Remove(lsv.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show(" Please choose 1 line to delete", "Notice to you");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các tbxvà các điều khiển khác

            int lastMonthReading = int.Parse(tbxLastMonthReading.Text);
            int thisMonthReading = int.Parse(tbxThisMonthReading.Text);
            int customerType = cbxCustomerType.SelectedIndex + 1;
            int numberOfPeople = (int)nudNumberOfPeople.Value;

            // Tính lượng tiêu thụ
            int consumption = thisMonthReading - lastMonthReading;
            if (consumption < 0)
            {
                MessageBox.Show("This month's reading cannot be less than last month's reading.", "Notice for you");
                return;
            }

            // Tính toán tổng hóa đơn
            double totalBill = CalculateBill(customerType, consumption, numberOfPeople);
            ListViewItem item = lsv.Items.Add(tbxCustomerName.Text);
            item.SubItems.Add(tbxLastMonthReading.Text);
            item.SubItems.Add(tbxThisMonthReading.Text);
            item.SubItems.Add(cbxCustomerType.SelectedItem.ToString());
            item.SubItems.Add(nudNumberOfPeople.Text);
            item.SubItems.Add(totalBill.ToString("F2") + "VND ");
        }

        private void lsv_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            

                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = tbxFind.Text.Trim().ToLower();

            // Lưu các mục hiện tại 
            List<ListViewItem> itemsToShow = new List<ListViewItem>();

            foreach (ListViewItem item in lsv.Items)
            {
                // Kiểm tra nếu tên khách hàng trong mục 
                if (item.SubItems[0].Text.ToLower().Contains(searchTerm))
                {
                    itemsToShow.Add(item);
                    // Thêm mục phù hợp 
                }
            }

            
            lsv.Items.Clear();

            // Thêm các mục từ danh sách vào ListView
            if (itemsToShow.Count > 0)
            {
                lsv.Items.AddRange(itemsToShow.ToArray());
            }
            else
            {
                MessageBox.Show("No customer found with name: " + searchTerm);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
        
        }

        private void BtnSort_Click_1(object sender, EventArgs e)
        {
            // Toggle sorting direction
            sortAscending = !sortAscending;

            // Perform sorting specifically for the totalBill column
            SortListView();
        }

        private void SortListView()
        {
            // Collect all items into a list
            var items = new List<ListViewItem>();
            foreach (ListViewItem item in lsv.Items)
            {
                items.Add(item);
            }

            // Sort items based on the totalBill column (index 5)
            items.Sort((x, y) =>
            {
                // Assuming totalBill is in the 6th column (index 5)
                double xValue = double.Parse(x.SubItems[5].Text.Replace("VND", "").Trim());
                double yValue = double.Parse(y.SubItems[5].Text.Replace("VND", "").Trim());
                int result = xValue.CompareTo(yValue);
                return sortAscending ? result : -result;
            });

            // Clear the current items and re-add the sorted items
            lsv.Items.Clear();
            lsv.Items.AddRange(items.ToArray());
        }
    }
    }

