namespace POS.ProductForm
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.ProductGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SaveCategory = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.searchCategory = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToResizeColumns = false;
            this.ProductGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGridView.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.ProductGridView.EnableHeadersVisualStyles = false;
            this.ProductGridView.GridColor = System.Drawing.Color.Turquoise;
            this.ProductGridView.Location = new System.Drawing.Point(12, 121);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersVisible = false;
            this.ProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProductGridView.Size = new System.Drawing.Size(825, 314);
            this.ProductGridView.StandardTab = true;
            this.ProductGridView.TabIndex = 2;
            this.ProductGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProductGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductGridView.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductGridView.ThemeStyle.GridColor = System.Drawing.Color.Turquoise;
            this.ProductGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Turquoise;
            this.ProductGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.ProductGridView.ThemeStyle.ReadOnly = false;
            this.ProductGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ProductGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.ProductGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ProductGridView_CellBeginEdit);
            this.ProductGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellEndEdit);
            this.ProductGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellEnter);
            this.ProductGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductGridView_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.SaveCategory);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 69);
            this.panel1.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(4, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(310, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "MANAJEMEN PRODUK";
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 69);
            this.panel2.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(255, 14);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(310, 37);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "MANAJEMEN PRODUK";
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
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 505);
            this.Controls.Add(this.searchCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(865, 544);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView ProductGridView;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton SaveCategory;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox searchCategory;
    }
}