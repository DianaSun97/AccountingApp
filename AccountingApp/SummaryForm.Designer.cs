using System.ComponentModel;

namespace AccountingApp
{
    partial class SummaryForm
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
            this.summary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.summary)).BeginInit();
            this.SuspendLayout();
            // 
            // summary
            // 
            this.summary.AllowUserToAddRows = false;
            this.summary.AllowUserToDeleteRows = false;
            this.summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summary.Location = new System.Drawing.Point(18, 18);
            this.summary.Name = "summary";
            this.summary.ReadOnly = true;
            this.summary.Size = new System.Drawing.Size(770, 347);
            this.summary.TabIndex = 0;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.summary);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Activated += new System.EventHandler(this.SummaryForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.summary)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView summary;

        #endregion
    }
}