namespace ModernUI
{
    partial class FrmSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.lblSignupTitle = new System.Windows.Forms.Label();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNick = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCoPass = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 22);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(-6, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 22);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(481, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSignupTitle
            // 
            this.lblSignupTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignupTitle.AutoSize = true;
            this.lblSignupTitle.Font = new System.Drawing.Font("moderna", 23F);
            this.lblSignupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignupTitle.Location = new System.Drawing.Point(-505, 43);
            this.lblSignupTitle.Name = "lblSignupTitle";
            this.lblSignupTitle.Padding = new System.Windows.Forms.Padding(700, 0, 0, 0);
            this.lblSignupTitle.Size = new System.Drawing.Size(833, 44);
            this.lblSignupTitle.TabIndex = 20;
            this.lblSignupTitle.Text = "Sign Up";
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
            this.btnRegister.Location = new System.Drawing.Point(13, 308);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(487, 32);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.Hint = "Password:";
            this.txtPass.LeadingIcon = null;
            this.txtPass.Location = new System.Drawing.Point(12, 237);
            this.txtPass.MaxLength = 30;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Password = true;
            this.txtPass.Size = new System.Drawing.Size(235, 50);
            this.txtPass.TabIndex = 18;
            this.txtPass.Text = "";
            this.txtPass.TrailingIcon = null;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email:";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(12, 169);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(488, 50);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtNick
            // 
            this.txtNick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNick.AnimateReadOnly = false;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNick.Depth = 0;
            this.txtNick.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNick.ForeColor = System.Drawing.Color.White;
            this.txtNick.Hint = "Nickname:";
            this.txtNick.LeadingIcon = null;
            this.txtNick.Location = new System.Drawing.Point(12, 102);
            this.txtNick.MaxLength = 30;
            this.txtNick.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNick.Multiline = false;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(488, 50);
            this.txtNick.TabIndex = 16;
            this.txtNick.Text = "";
            this.txtNick.TrailingIcon = null;
            this.txtNick.TextChanged += new System.EventHandler(this.txtNick_TextChanged);
            this.txtNick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNick_KeyPress);
            // 
            // txtCoPass
            // 
            this.txtCoPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoPass.AnimateReadOnly = false;
            this.txtCoPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoPass.Depth = 0;
            this.txtCoPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCoPass.Hint = "Confirm Password:";
            this.txtCoPass.LeadingIcon = null;
            this.txtCoPass.Location = new System.Drawing.Point(265, 237);
            this.txtCoPass.MaxLength = 30;
            this.txtCoPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCoPass.Multiline = false;
            this.txtCoPass.Name = "txtCoPass";
            this.txtCoPass.Password = true;
            this.txtCoPass.Size = new System.Drawing.Size(235, 50);
            this.txtCoPass.TabIndex = 21;
            this.txtCoPass.Text = "";
            this.txtCoPass.TrailingIcon = null;
            this.txtCoPass.TextChanged += new System.EventHandler(this.txtCoPass_TextChanged);
            this.txtCoPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoPass_KeyPress);
            // 
            // FrmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(512, 387);
            this.Controls.Add(this.txtCoPass);
            this.Controls.Add(this.lblSignupTitle);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSignup";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lblSignupTitle;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialTextBox txtPass;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtNick;
        private MaterialSkin.Controls.MaterialTextBox txtCoPass;
    }
}