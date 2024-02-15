namespace POS
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
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
            this.panel1.Size = new System.Drawing.Size(850, 69);
            this.panel1.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(4, 15);
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
            this.SaveCategory.Image = null;
            this.SaveCategory.ImageSize = new System.Drawing.Size(35, 35);
            this.SaveCategory.Location = new System.Drawing.Point(663, 12);
            this.SaveCategory.Name = "SaveCategory";
            this.SaveCategory.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.SaveCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveCategory.OnHoverImage = null;
            this.SaveCategory.OnPressedColor = System.Drawing.Color.Black;
            this.SaveCategory.Size = new System.Drawing.Size(173, 42);
            this.SaveCategory.TabIndex = 10;
            this.SaveCategory.Text = "TAMBAH (F1)";
            this.SaveCategory.Click += new System.EventHandler(this.SaveCategory_Click);
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.AllowUserToAddRows = false;
            this.CategoryGridView.AllowUserToResizeColumns = false;
            this.CategoryGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CategoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryGridView.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.CategoryGridView.EnableHeadersVisualStyles = false;
            this.CategoryGridView.GridColor = System.Drawing.Color.Turquoise;
            this.CategoryGridView.Location = new System.Drawing.Point(12, 121);
            this.CategoryGridView.MultiSelect = false;
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.RowHeadersVisible = false;
            this.CategoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CategoryGridView.Size = new System.Drawing.Size(825, 314);
            this.CategoryGridView.StandardTab = true;
            this.CategoryGridView.TabIndex = 2;
            this.CategoryGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryGridView.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryGridView.ThemeStyle.GridColor = System.Drawing.Color.Turquoise;
            this.CategoryGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Turquoise;
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
            this.CategoryGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.CategoryGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellClick);
            this.CategoryGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellEndEdit);
            this.CategoryGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.CategoryGridView_UserDeletedRow);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 69);
            this.panel2.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(255, 14);
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
            this.searchCategory.Location = new System.Drawing.Point(12, 78);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.PasswordChar = '\0';
            this.searchCategory.SelectedText = "";
            this.searchCategory.Size = new System.Drawing.Size(825, 30);
            this.searchCategory.TabIndex = 1;
            this.searchCategory.TextChanged += new System.EventHandler(this.searchCategory_TextChanged);
            this.searchCategory.Enter += new System.EventHandler(this.Categories_Load);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(849, 505);
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
            this.Name = "CategoryForm";
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