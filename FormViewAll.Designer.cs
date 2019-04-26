namespace FinancialTrackingApp
{
    partial class FormViewAll
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
            this.dgvDisplayTransactions = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayTransactions
            // 
            this.dgvDisplayTransactions.AllowUserToAddRows = false;
            this.dgvDisplayTransactions.AllowUserToDeleteRows = false;
            this.dgvDisplayTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayTransactions.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplayTransactions.Name = "dgvDisplayTransactions";
            this.dgvDisplayTransactions.ReadOnly = true;
            this.dgvDisplayTransactions.Size = new System.Drawing.Size(706, 455);
            this.dgvDisplayTransactions.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(59, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // FormViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 479);
            this.Controls.Add(this.dgvDisplayTransactions);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormViewAll";
            this.Text = "FormViewAll";
            this.Load += new System.EventHandler(this.FormViewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayTransactions;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}