namespace POS
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SaveCategory = new Guna.UI.WinForms.GunaButton();
            this.CategoryGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.searchCategory = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.SaveCategory);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 63);
            this.panel1.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(4, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(328, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "MANAJEMEN KATEGORI";
            // 
            // SaveCategory
            // 
            this.SaveCategory.AnimationHoverSpeed = 0.07F;
            this.SaveCategory.AnimationSpeed = 0.03F;
            this.SaveCategory.BaseColor = System.Drawing.Color.Turquoise;
            this.SaveCategory.BorderColor = System.Drawing.Color.Black;
            this.SaveCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveCategory.FocusedColor = System.Drawing.Color.Empty;
            this.SaveCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCategory.ForeColor = System.Drawing.Color.White;
            this.SaveCategory.Image = ((System.Drawing.Image)(resources.GetObject("SaveCategory.Image")));
            this.SaveCategory.ImageSize = new System.Drawing.Size(35, 35);
            this.SaveCategory.Location = new System.Drawing.Point(670, 12);
            this.SaveCategory.Name = "SaveCategory";
            this.SaveCategory.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.SaveCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveCategory.OnHoverImage = null;
            this.SaveCategory.OnPressedColor = System.Drawing.Color.Black;
            this.SaveCategory.Size = new System.Drawing.Size(166, 42);
            this.SaveCategory.TabIndex = 10;
            this.SaveCategory.Text = "TAMBAH";
            this.SaveCategory.Click += new System.EventHandler(this.SaveCategory_Click);
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.AllowUserToResizeColumns = false;
            this.CategoryGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CategoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CategoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.CategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CategoryGridView.ColumnHeadersHeight = 21;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.CategoryGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.CategoryGridView.EnableHeadersVisualStyles = false;
            this.CategoryGridView.GridColor = System.Drawing.Color.Turquoise;
            this.CategoryGridView.Location = new System.Drawing.Point(12, 110);
            this.CategoryGridView.MultiSelect = false;
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.RowHeadersVisible = false;
            this.CategoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryGridView.Size = new System.Drawing.Size(825, 326);
            this.CategoryGridView.TabIndex = 12;
            this.CategoryGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoryGridView.ThemeStyle.GridColor = System.Drawing.Color.Turquoise;
            this.CategoryGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CategoryGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoryGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoryGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoryGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.CategoryGridView.ThemeStyle.ReadOnly = false;
            this.CategoryGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoryGridView.ThemeStyle.RowsStyle.Height = 22;
            this.CategoryGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellClick);
            this.CategoryGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.CategoryGridView_UserAddedRow);
            this.CategoryGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.CategoryGridView_UserDeletedRow);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 63);
            this.panel2.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(255, 17);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(328, 37);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "MANAJEMEN KATEGORI";
            // 
            // searchCategory
            // 
            this.searchCategory.BaseColor = System.Drawing.Color.White;
            this.searchCategory.BorderColor = System.Drawing.Color.Silver;
            this.searchCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCategory.FocusedBaseColor = System.Drawing.Color.White;
            this.searchCategory.FocusedBorderColor = System.Drawing.Color.Turquoise;
            this.searchCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.searchCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchCategory.Location = new System.Drawing.Point(12, 74);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.PasswordChar = '\0';
            this.searchCategory.SelectedText = "";
            this.searchCategory.Size = new System.Drawing.Size(825, 30);
            this.searchCategory.TabIndex = 1;
            this.searchCategory.TextChanged += new System.EventHandler(this.searchCategory_TextChanged);
            this.searchCategory.Enter += new System.EventHandler(this.Categories_Load);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 528);
            this.Controls.Add(this.searchCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CategoryGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(865, 544);
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CategoriesForm_FormClosed);
            this.Load += new System.EventHandler(this.Categories_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CategoriesForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView CategoryGridView;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton SaveCategory;
        private Guna.UI.WinForms.GunaTextBox searchCategory;
    }
}