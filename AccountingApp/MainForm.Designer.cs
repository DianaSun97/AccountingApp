using System.Windows.Forms;

namespace AccountingApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTransactions = new System.Windows.Forms.Button();
            this.deleteTransaction = new System.Windows.Forms.Button();
            this.editTransaction = new System.Windows.Forms.Button();
            this.transactions = new System.Windows.Forms.DataGridView();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.connection = new System.Data.SqlClient.SqlConnection();
            this.dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // addTransactions
            // 
            this.addTransactions.Location = new System.Drawing.Point(623, 24);
            this.addTransactions.Name = "addTransactions";
            this.addTransactions.Size = new System.Drawing.Size(138, 49);
            this.addTransactions.TabIndex = 0;
            this.addTransactions.Text = "Add transactions";
            this.addTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addTransactions.UseVisualStyleBackColor = true;
            this.addTransactions.Click += new System.EventHandler(this.addTransactions_Click);
            // 
            // deleteTransaction
            // 
            this.deleteTransaction.Location = new System.Drawing.Point(623, 88);
            this.deleteTransaction.Name = "deleteTransaction";
            this.deleteTransaction.Size = new System.Drawing.Size(138, 49);
            this.deleteTransaction.TabIndex = 2;
            this.deleteTransaction.Text = "Delete transaction";
            this.deleteTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deleteTransaction.UseVisualStyleBackColor = true;
            this.deleteTransaction.Click += new System.EventHandler(this.deleteTransaction_Click);
            // 
            // editTransaction
            // 
            this.editTransaction.Location = new System.Drawing.Point(623, 152);
            this.editTransaction.Name = "editTransaction";
            this.editTransaction.Size = new System.Drawing.Size(138, 49);
            this.editTransaction.TabIndex = 3;
            this.editTransaction.Text = "Edit transaction";
            this.editTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editTransaction.UseVisualStyleBackColor = true;
            this.editTransaction.Click += new System.EventHandler(this.editTransaction_Click);
            // 
            // transactions
            // 
            this.transactions.AllowUserToAddRows = false;
            this.transactions.AllowUserToDeleteRows = false;
            this.transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactions.Location = new System.Drawing.Point(14, 14);
            this.transactions.Name = "transactions";
            this.transactions.ReadOnly = true;
            this.transactions.Size = new System.Drawing.Size(586, 307);
            this.transactions.TabIndex = 4;
            this.transactions.CellClick += new DataGridViewCellEventHandler(this.transactions_CellContentClick);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "select t.transaction_id, t.date, t.price, t.category_id, c.name, t.comments from transactions t join category c on c.category_id = t.category_id";
            this.sqlCommand1.Connection = this.connection;
            // 
            // connection
            // 
            this.connection.ConnectionString = "Server=localhost;Database=accountant;Trusted_Connection=True;";
            this.connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataAdapter
            // 
            this.dataAdapter.SelectCommand = this.sqlCommand1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(783, 333);
            this.Controls.Add(this.transactions);
            this.Controls.Add(this.editTransaction);
            this.Controls.Add(this.deleteTransaction);
            this.Controls.Add(this.addTransactions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.transactions)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Data.SqlClient.SqlDataAdapter dataAdapter;

        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection connection;

        private System.Windows.Forms.DataGridView transactions;

        private System.Windows.Forms.Button editTransaction;

        private System.Windows.Forms.Button deleteTransaction;

        private System.Windows.Forms.Button addTransactions;

        #endregion
    }
}