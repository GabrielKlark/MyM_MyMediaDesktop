namespace ModernUI
{
    partial class Frm1_Watchlist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMWTitle = new System.Windows.Forms.Label();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.cbSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSearchAll = new MaterialSkin.Controls.MaterialButton();
            this.dtgvWatchlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWatchlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMWTitle
            // 
            this.lblMWTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMWTitle.AutoSize = true;
            this.lblMWTitle.Font = new System.Drawing.Font("moderna", 23F);
            this.lblMWTitle.ForeColor = System.Drawing.Color.Red;
            this.lblMWTitle.Location = new System.Drawing.Point(-201, 29);
            this.lblMWTitle.Name = "lblMWTitle";
            this.lblMWTitle.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.lblMWTitle.Size = new System.Drawing.Size(714, 44);
            this.lblMWTitle.TabIndex = 18;
            this.lblMWTitle.Text = "My Watchlist";
            this.lblMWTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(666, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 48);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Hint = "Search:";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(409, 87);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 50);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbSelect
            // 
            this.cbSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSelect.AutoResize = false;
            this.cbSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSelect.Depth = 0;
            this.cbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSelect.DropDownHeight = 174;
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.DropDownWidth = 121;
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Hint = "Select an option to search: ";
            this.cbSelect.IntegralHeight = false;
            this.cbSelect.ItemHeight = 43;
            this.cbSelect.Items.AddRange(new object[] {
            "Code",
            "Title",
            "Date",
            "Num of Seasons",
            "Synopsis"});
            this.cbSelect.Location = new System.Drawing.Point(34, 87);
            this.cbSelect.MaxDropDownItems = 4;
            this.cbSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(360, 49);
            this.cbSelect.StartIndex = 0;
            this.cbSelect.TabIndex = 19;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchAll.AutoSize = false;
            this.btnSearchAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchAll.Depth = 0;
            this.btnSearchAll.HighEmphasis = true;
            this.btnSearchAll.Icon = null;
            this.btnSearchAll.Location = new System.Drawing.Point(34, 157);
            this.btnSearchAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(730, 26);
            this.btnSearchAll.TabIndex = 20;
            this.btnSearchAll.Text = "Show Everything!";
            this.btnSearchAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchAll.UseAccentColor = false;
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // dtgvWatchlist
            // 
            this.dtgvWatchlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvWatchlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvWatchlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvWatchlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dtgvWatchlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvWatchlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvWatchlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvWatchlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dtgvWatchlist.ColumnHeadersHeight = 30;
            this.dtgvWatchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvWatchlist.EnableHeadersVisualStyles = false;
            this.dtgvWatchlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.dtgvWatchlist.Location = new System.Drawing.Point(29, 211);
            this.dtgvWatchlist.Name = "dtgvWatchlist";
            this.dtgvWatchlist.ReadOnly = true;
            this.dtgvWatchlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvWatchlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dtgvWatchlist.RowHeadersVisible = false;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvWatchlist.RowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dtgvWatchlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvWatchlist.Size = new System.Drawing.Size(737, 299);
            this.dtgvWatchlist.TabIndex = 21;
            // 
            // Frm1_Watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgvWatchlist);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.lblMWTitle);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm1_Watchlist";
            this.Text = "Frm1_MyWatchlist";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWatchlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMWTitle;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private MaterialSkin.Controls.MaterialComboBox cbSelect;
        private MaterialSkin.Controls.MaterialButton btnSearchAll;
        private System.Windows.Forms.DataGridView dtgvWatchlist;
    }
}