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
            this.transactions = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colCategory = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.colCommets = new System.Windows.Forms.ColumnHeader();
            this.deleteTransaction = new System.Windows.Forms.Button();
            this.editTransaction = new System.Windows.Forms.Button();
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
            // transactions
            // 
            this.transactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.colID, this.colDate, this.colCategory, this.colPrice, this.colCommets});
            this.transactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.transactions.FullRowSelect = true;
            this.transactions.Location = new System.Drawing.Point(0, 0);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(602, 450);
            this.transactions.TabIndex = 1;
            this.transactions.UseCompatibleStateImageBehavior = false;
            this.transactions.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 48;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 100;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 120;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 64;
            // 
            // colCommets
            // 
            this.colCommets.Text = "Comments";
            this.colCommets.Width = 200;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (43)))), ((int) (((byte) (54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editTransaction);
            this.Controls.Add(this.deleteTransaction);
            this.Controls.Add(this.transactions);
            this.Controls.Add(this.addTransactions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button editTransaction;

        private System.Windows.Forms.Button deleteTransaction;

        private System.Windows.Forms.ColumnHeader colCommets;

        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colPrice;

        private System.Windows.Forms.ListView transactions;

        private System.Windows.Forms.Button addTransactions;

        #endregion
    }
}