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

namespace IOOP_Assignment
{
    public partial class ChefInventoryForm : Form
    {
        Timer timer = new Timer();
        public ChefInventoryForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            LoadInventoryData();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
        }

        private void LoadInventoryData()
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "SELECT StockID, Name, Quantity, IndividualPrice, Status FROM Inventory ORDER BY StockID ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt");
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChefInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOPDatabaseDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.iOOPDatabaseDataSet.Inventory);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Console.WriteLine("CellFormatting called");  // Debug output

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value as string;
                Console.WriteLine($"Status: {status}");  // More detailed debug output

                if (status == "Out of Stock")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (status == "Lack of Stock")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;  // Ensuring other statuses are clear
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
