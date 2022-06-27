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
using System.Windows.Forms.VisualStyles;

namespace AccountingApp
{
    public partial class MainForm : Form
    {
        private const string ConnectionString = "Server=localhost;Database=accountant;Trusted_Connection=True;";
        private SqlConnection connection;

        public MainForm()
        {
            InitializeComponent();
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        ~MainForm()
        {
            connection.Close();
        }

        // загрузка списка транзакций
        public void showTransactions()
        {
            transactions.Items.Clear();
            var cmd =
                new SqlCommand(
                    "select t.transaction_id as id, t.date, t.price, c.name as category, t.comments from transactions t join category c on c.category_id = t.category_id",
                    connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var item = new ListViewItem(new[]
                    {
                        Convert.ToString(reader["id"]),
                        Convert.ToString(reader["date"]),
                        Convert.ToString(reader["category"]),
                        Convert.ToString(reader["price"]),
                        Convert.ToString(reader["comments"])
                    });
                    transactions.Items.Add(item);
                }
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            showTransactions();
        }

        // удаление транзакций
        private void deleteTransaction_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in transactions.SelectedItems)
            {
                var cmd =
                    new SqlCommand(
                        "delete from transactions where transaction_id = @id",
                        connection);
                cmd.Parameters.Add("id", int.Parse(item.SubItems[0].Text));
                cmd.ExecuteNonQuery();
            }

            showTransactions();
        }

        // редактирование платежа
        private void editTransaction_Click(object sender, EventArgs e)
        {
            if (transactions.SelectedItems.Count == 1)
            {
                var id = int.Parse(transactions.SelectedItems[0].SubItems[0].Text);
                var form = new TransactionForm(connection, id);
                form.Show();
            }
        }

        // добавления платежа
        public void addTransactions_Click(object sender, EventArgs e)
        {
            var form = new TransactionForm(connection);
            form.Show();
        }
    }
}