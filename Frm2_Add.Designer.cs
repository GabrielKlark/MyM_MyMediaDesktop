namespace ModernUI
{
    partial class Frm2_Add
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
            this.txtCod = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSeason = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSynopsis = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.btnAlter = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCod.AnimateReadOnly = false;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCod.Depth = 0;
            this.txtCod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCod.ForeColor = System.Drawing.Color.White;
            this.txtCod.Hint = "Code:";
            this.txtCod.LeadingIcon = null;
            this.txtCod.Location = new System.Drawing.Point(124, 93);
            this.txtCod.MaxLength = 50;
            this.txtCod.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCod.Multiline = false;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(133, 50);
            this.txtCod.TabIndex = 2;
            this.txtCod.Text = "";
            this.txtCod.TrailingIcon = null;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.AnimateReadOnly = false;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Depth = 0;
            this.txtTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.Hint = "Title:";
            this.txtTitle.LeadingIcon = null;
            this.txtTitle.Location = new System.Drawing.Point(124, 166);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(573, 50);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "";
            this.txtTitle.TrailingIcon = null;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.AnimateReadOnly = false;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Depth = 0;
            this.txtDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDate.Hint = "Watching Date (YYYY/MM/DD):";
            this.txtDate.LeadingIcon = null;
            this.txtDate.Location = new System.Drawing.Point(278, 93);
            this.txtDate.MaxLength = 10;
            this.txtDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(267, 50);
            this.txtDate.TabIndex = 6;
            this.txtDate.Text = "";
            this.txtDate.TrailingIcon = null;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            // 
            // txtSeason
            // 
            this.txtSeason.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSeason.AnimateReadOnly = false;
            this.txtSeason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeason.Depth = 0;
            this.txtSeason.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSeason.Hint = "N. of Seasons:";
            this.txtSeason.LeadingIcon = null;
            this.txtSeason.Location = new System.Drawing.Point(564, 93);
            this.txtSeason.MaxLength = 3;
            this.txtSeason.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSeason.Multiline = false;
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(133, 50);
            this.txtSeason.TabIndex = 8;
            this.txtSeason.Text = "";
            this.txtSeason.TrailingIcon = null;
            this.txtSeason.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeason_KeyPress);
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSynopsis.AnimateReadOnly = false;
            this.txtSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSynopsis.Depth = 0;
            this.txtSynopsis.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSynopsis.Hint = "Synopsis:";
            this.txtSynopsis.LeadingIcon = null;
            this.txtSynopsis.Location = new System.Drawing.Point(124, 242);
            this.txtSynopsis.MaxLength = 300;
            this.txtSynopsis.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSynopsis.Multiline = false;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.Size = new System.Drawing.Size(573, 50);
            this.txtSynopsis.TabIndex = 10;
            this.txtSynopsis.Text = "";
            this.txtSynopsis.TrailingIcon = null;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.AutoSize = false;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.Enabled = false;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(126, 320);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(125, 36);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlter.AutoSize = false;
            this.btnAlter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAlter.Depth = 0;
            this.btnAlter.Enabled = false;
            this.btnAlter.HighEmphasis = true;
            this.btnAlter.Icon = null;
            this.btnAlter.Location = new System.Drawing.Point(272, 320);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAlter.Size = new System.Drawing.Size(125, 36);
            this.btnAlter.TabIndex = 12;
            this.btnAlter.Text = "Alter";
            this.btnAlter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAlter.UseAccentColor = false;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(419, 320);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(125, 36);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.Enabled = false;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(564, 320);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(125, 36);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("moderna", 23F);
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddTitle.Location = new System.Drawing.Point(-375, 36);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Padding = new System.Windows.Forms.Padding(700, 0, 0, 0);
            this.lblAddTitle.Size = new System.Drawing.Size(879, 44);
            this.lblAddTitle.TabIndex = 15;
            this.lblAddTitle.Text = "Add to List";
            // 
            // Frm2_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.lblAddTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm2_Add";
            this.Text = "Frm2_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtCod;
        private MaterialSkin.Controls.MaterialTextBox txtTitle;
        private MaterialSkin.Controls.MaterialTextBox txtDate;
        private MaterialSkin.Controls.MaterialTextBox txtSeason;
        private MaterialSkin.Controls.MaterialTextBox txtSynopsis;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialButton btnAlter;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private System.Windows.Forms.Label lblAddTitle;
    }
}