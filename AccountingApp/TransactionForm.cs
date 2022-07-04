using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class TransactionForm : Form
    {
        private SqlConnection connection;
        private int editID = -1;
        private Dictionary<int, int> categoryIDtoInd = new Dictionary<int, int>();
        private Dictionary<int, int> categoryIndtoID = new Dictionary<int, int>();

        public TransactionForm(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
            editDate.Value = DateTime.Today;
            loadCategories();
        }

        public TransactionForm(SqlConnection con, int id) : this(con)
        {
            editID = id;
            editApply.Text = "Save";
            var cmd =
                new SqlCommand(
                    "select transaction_id, date, price, category_id, comments from transactions where transaction_id = @id",
                    connection);
            cmd.Parameters.AddWithValue("id", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    editDate.Value = DateTime.Parse(reader["date"].ToString());
                    editPrice.Text = reader["price"].ToString();
                    editCategory.SelectedIndex = categoryIDtoInd[int.Parse(reader["category_id"].ToString())];
                    editComment.Text = reader["comments"].ToString();
                }
            }
        }

        void loadCategories()
        {
            editCategory.Items.Clear();
            categoryIDtoInd.Clear();
            categoryIndtoID.Clear();
            var cmd =
                new SqlCommand(
                    "select category_id, name from category",
                    connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader["category_id"].ToString());
                    string name = reader["name"].ToString();
                    int ind = editCategory.Items.Count;
                    categoryIDtoInd[id] = ind;
                    categoryIndtoID[ind] = id;
                    editCategory.Items.Add(name);
                }
            }
        }

        private void editApply_Click(object sender, EventArgs e)
        {
            if (editID <= 0)
            {
                var cmd =
                    new SqlCommand(
                        "insert into transactions(date,price,category_id,comments) values (@date,@price,@category_id,@comments)",
                        connection);
                cmd.Parameters.AddWithValue("date", editDate.Value);
                cmd.Parameters.AddWithValue("price", decimal.Parse(editPrice.Text));
                cmd.Parameters.AddWithValue("category_id", categoryIndtoID[editCategory.SelectedIndex]);
                cmd.Parameters.AddWithValue("comments", editComment.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added data");
                Close();
            }
            else
            {
                var cmd =
                    new SqlCommand(
                        "update transactions set date = @date, price = @price, category_id = @category_id, comments = @comments where transaction_id = @transaction_id",
                        connection);
                cmd.Parameters.AddWithValue("transaction_id", editID);
                cmd.Parameters.AddWithValue("date", editDate.Value);
                cmd.Parameters.AddWithValue("price", decimal.Parse(editPrice.Text));
                cmd.Parameters.AddWithValue("category_id", categoryIndtoID[editCategory.SelectedIndex]);
                cmd.Parameters.AddWithValue("comments", editComment.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved data");
                Close();
            }
        }
    }
}