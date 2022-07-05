using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class SummaryForm : Form
    {
        private SqlConnection connection;
        private Dictionary<int, string> categories = new Dictionary<int, string>();

        public SummaryForm(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        void loadCategories()
        {
            categories.Clear();
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
                    categories[id] = name;
                }
            }
        }

        void showSummary()
        {
            loadCategories();
            var cmd = new SqlCommand("select c.category_id, MONTH(t.date), sum(t.price) " +
                                     "from transactions t join category c on c.category_id = t.category_id " +
                                     "group by c.category_id, MONTH(t.date)" +
                                     "order by c.category_id, MONTH(t.date)", connection);
            var ds = new DataTable();
            ds.Columns.Add("Category");
            for (int i = 0; i < 12; i++)
            {
                var t = new DateTime(2022, i + 1, 1);
                ds.Columns.Add(t.ToString("MMM"));
            }

            var indexes = new Dictionary<int, int>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    int month = int.Parse(reader[1].ToString());
                    decimal sum = decimal.Parse(reader[2].ToString());
                    int ind = -1;
                    if (indexes.ContainsKey(id))
                    {
                        ind = indexes[id];
                    }
                    else
                    {
                        ind = ds.Rows.Count;
                        indexes[id] = ind;
                        ds.Rows.Add(new object[]{categories[id],0,0,0,0,0,0,0,0,0,0,0,0});
                    }
                    ds.Rows[ind][month] = sum;
                }
            }
            
            summary.DataSource = ds;
            for (int i = 0; i < 12; i++)
            {
                summary.Columns[i + 1].Width = 60;
            }
        }

        private void SummaryForm_Activated(object sender, EventArgs e)
        {
            showSummary();
        }
    }
}