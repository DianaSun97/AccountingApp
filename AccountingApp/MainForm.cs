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
        private int selectIndex;

        public MainForm()
        {
            InitializeComponent();
            connection.Open();
        }

        ~MainForm()
        {
            connection.Close();
        }
        
        // загрузка списка транзакций
        public void showTransactions()
        {
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            transactions.DataSource = dt;
            selectIndex = transactions.Rows.Count == 0 ? -1 : 0;

            transactions.Columns[0].HeaderText = "ID";
            transactions.Columns[1].HeaderText = "Date";
            transactions.Columns[2].HeaderText = "Price";
            transactions.Columns[3].Visible = false;
            transactions.Columns[4].HeaderText = "Category";
            transactions.Columns[5].HeaderText = "Comments";
        }
        
        private void MainForm_Activated(object sender, EventArgs e)
        {
            showTransactions();
        }
        
        // удаление транзакций
        private void deleteTransaction_Click(object sender, EventArgs e)
        {
            if (selectIndex >= 0)
            {
                var cmd =
                    new SqlCommand(
                        "delete from transactions where transaction_id = @id",
                        connection);
                cmd.Parameters.AddWithValue("id", int.Parse(transactions.Rows[selectIndex].Cells[0].Value.ToString()));
                cmd.ExecuteNonQuery();
            }
        
            showTransactions();
        }
        
        // редактирование платежа
        private void editTransaction_Click(object sender, EventArgs e)
        {
            if (selectIndex >= 0)
            {
                var id = int.Parse(transactions.Rows[selectIndex].Cells[0].Value.ToString());
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

        private void transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectIndex = e.RowIndex;
        }
    }
}