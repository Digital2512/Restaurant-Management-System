using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public static class Utility
{
    private static string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=\"FINAL DATABASE\";Integrated Security=True;";

    // Method to open a form
    public static void OpenForm(Form currentForm, Form newForm)
    {
        currentForm.Hide();
        newForm.FormClosed += (s, args) => currentForm.Show();
        newForm.Show();
    }

    // Method to open a SQL connection
    public static SqlConnection OpenSqlConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }

    // Method to execute a SQL command
    public static int ExecuteSqlCommand(string query, SqlParameter[] parameters)
    {
        using (SqlConnection connection = OpenSqlConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(param.ParameterName, param.Value)
                        {
                            SqlDbType = param.SqlDbType,
                            Direction = param.Direction,
                            IsNullable = param.IsNullable,
                            Size = param.Size
                        });
                    }
                }
                return command.ExecuteNonQuery();
            }
        }
    }

    // Method to execute a SQL query and return a data table
    public static DataTable ExecuteSqlQuery(string query, SqlParameter[] parameters)
    {
        using (SqlConnection connection = OpenSqlConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(param.ParameterName, param.Value)
                        {
                            SqlDbType = param.SqlDbType,
                            Direction = param.Direction,
                            IsNullable = param.IsNullable,
                            Size = param.Size
                        });
                    }
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    // Method to show a confirmation dialog
    public static bool ShowConfirmationDialog(string message)
    {
        return MessageBox.Show(message, "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}
