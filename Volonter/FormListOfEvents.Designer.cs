namespace Volonter
{
    partial class FormListOfEvents
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnMain = new Panel();
            lblUserName = new Label();
            btnOut = new Button();
            dgvProduct = new DataGridView();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(lblUserName);
            pnMain.Controls.Add(btnOut);
            pnMain.Dock = DockStyle.Top;
            pnMain.Location = new Point(10, 10);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(0, 0, 0, 10);
            pnMain.Size = new Size(964, 40);
            pnMain.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(769, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.FromArgb(76, 175, 80);
            btnOut.Dock = DockStyle.Right;
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Location = new Point(814, 0);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(150, 30);
            btnOut.TabIndex = 5;
            btnOut.Text = "Войти";
            btnOut.UseVisualStyleBackColor = false;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(10, 50);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(964, 601);
            dgvProduct.TabIndex = 1;
            // 
            // FormListOfEvents
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(dgvProduct);
            Controls.Add(pnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormListOfEvents";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListOfEvents";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private DataGridView dgvProduct;
        private Label lblUserName;
        private Button btnOut;
    }
}