using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public static class Utility
{
    private static string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";

    // Method to open a form
    public static void OpenForm(Form currentForm, Form newForm)
    {
        currentForm.Hide();
        newForm.ShowDialog();
        currentForm.Show();
    }

    // Method to open a SQL connection
    public static SqlConnection OpenSqlConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }

    // Method to close a SQL connection
    public static void CloseSqlConnection(SqlConnection connection)
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
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
                        command.Parameters.Add(param.Clone());
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
                        command.Parameters.Add(param.Clone());
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

// Extension method to clone SqlParameter
public static class SqlParameterExtensions
{
    public static SqlParameter Clone(this SqlParameter param)
    {
        return new SqlParameter(param.ParameterName, param.Value)
        {
            DbType = param.DbType,
            Direction = param.Direction,
            IsNullable = param.IsNullable,
            Offset = param.Offset,
            Precision = param.Precision,
            Scale = param.Scale,
            Size = param.Size,
            SourceColumn = param.SourceColumn,
            SourceColumnNullMapping = param.SourceColumnNullMapping,
            SourceVersion = param.SourceVersion
        };
    }
}
