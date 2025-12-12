using System.Drawing;
using System.Windows.Forms;

namespace RailwayApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFindMin;
        private Button btnSave;
        private Button btnLoad;
        private Button btnDebug;

        private void BackColorButtons()
        {
            Color buttonColor = Color.FromArgb(250, 237, 205);
            Color hoverColor = Color.FromArgb(153, 88, 42);

            foreach (Button button in new Button[] { btnAdd, btnEdit, btnDelete, btnFindMin, btnSave, btnLoad, btnDebug })
            {
                button.BackColor = buttonColor;
                button.ForeColor = hoverColor;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.Font = new Font("Segoe UI", 9F);

                button.MouseEnter += (s, e) =>
                {
                    button.BackColor = hoverColor;
                    button.ForeColor = Color.White;
                };
                button.MouseLeave += (s, e) =>
                {  
                    button.BackColor = buttonColor;
                    button.ForeColor = hoverColor;
                };
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindMin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();

            // DataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(680, 280);
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);

            
            // Кнопки
            this.btnAdd.Location = new System.Drawing.Point(12, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Location = new System.Drawing.Point(112, 305);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new System.Drawing.Point(212, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnFindMin.Location = new System.Drawing.Point(312, 305);
            this.btnFindMin.Name = "btnFindMin";
            this.btnFindMin.Size = new System.Drawing.Size(130, 30);
            this.btnFindMin.Text = "Найти мин. стоимость";
            this.btnFindMin.Click += new System.EventHandler(this.btnFindMin_Click);

            this.btnSave.Location = new System.Drawing.Point(12, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnLoad.Location = new System.Drawing.Point(112, 345);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 30);
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            this.btnDebug.Location = new System.Drawing.Point(212, 345);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(110, 30);
            this.btnDebug.Text = "Отладка БД";
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 400);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFindMin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "Управление вокзалом";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);


            this.BackColor = System.Drawing.Color.FromArgb(255, 230, 167);

            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 230, 167);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(111, 29, 27);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Candara", 12F, FontStyle.Bold);

            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 237, 205);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(250, 237, 205);

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 88, 42);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView.BackgroundColor = Color.White;
            dataGridView.GridColor = Color.FromArgb(111, 29, 27);
            dataGridView.Font = new Font("Candara", 10F);
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 237, 205);
            dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 240);
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 240);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 237, 205);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(153, 88, 42);

            BackColorButtons();
        }
    }
}