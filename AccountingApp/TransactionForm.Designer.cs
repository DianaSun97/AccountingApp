using System.ComponentModel;

namespace AccountingApp
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.editPrice = new System.Windows.Forms.RichTextBox();
            this.editComment = new System.Windows.Forms.RichTextBox();
            this.editApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // editPrice
            // 
            this.editPrice.Location = new System.Drawing.Point(183, 51);
            this.editPrice.Name = "editPrice";
            this.editPrice.Size = new System.Drawing.Size(111, 20);
            this.editPrice.TabIndex = 2;
            this.editPrice.Text = "";
            // 
            // editComment
            // 
            this.editComment.Location = new System.Drawing.Point(33, 168);
            this.editComment.Name = "editComment";
            this.editComment.Size = new System.Drawing.Size(480, 82);
            this.editComment.TabIndex = 3;
            this.editComment.Text = "";
            // 
            // editApply
            // 
            this.editApply.Location = new System.Drawing.Point(33, 273);
            this.editApply.Name = "editApply";
            this.editApply.Size = new System.Drawing.Size(142, 35);
            this.editApply.TabIndex = 5;
            this.editApply.Text = "Add";
            this.editApply.UseVisualStyleBackColor = true;
            this.editApply.Click += new System.EventHandler(this.editApply_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // editDate
            // 
            this.editDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.editDate.Location = new System.Drawing.Point(33, 51);
            this.editDate.Name = "editDate";
            this.editDate.Size = new System.Drawing.Size(111, 20);
            this.editDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(183, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(33, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comments";
            // 
            // editCategory
            // 
            this.editCategory.FormattingEnabled = true;
            this.editCategory.Location = new System.Drawing.Point(33, 108);
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(142, 21);
            this.editCategory.TabIndex = 12;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 345);
            this.Controls.Add(this.editCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editApply);
            this.Controls.Add(this.editComment);
            this.Controls.Add(this.editPrice);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox editCategory;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button editApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker editDate;

        private System.Windows.Forms.RichTextBox editPrice;
        private System.Windows.Forms.RichTextBox editComment;

        #endregion
    }
}