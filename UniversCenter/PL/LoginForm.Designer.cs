
namespace UniversCenter.PL
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TB_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TB_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConnecte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 29);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(132, 35);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Bonjour !";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 64);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(192, 18);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Se connecter pour continue";
            // 
            // TB_username
            // 
            this.TB_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_username.Enabled = false;
            this.TB_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TB_username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_username.HintForeColor = System.Drawing.Color.Empty;
            this.TB_username.HintText = "";
            this.TB_username.isPassword = false;
            this.TB_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_username.LineThickness = 3;
            this.TB_username.Location = new System.Drawing.Point(19, 166);
            this.TB_username.Margin = new System.Windows.Forms.Padding(4);
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(268, 44);
            this.TB_username.TabIndex = 2;
            this.TB_username.Text = "Admin";
            this.TB_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_password
            // 
            this.TB_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TB_password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TB_password.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_password.HintText = "";
            this.TB_password.isPassword = false;
            this.TB_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_password.LineThickness = 3;
            this.TB_password.Location = new System.Drawing.Point(19, 283);
            this.TB_password.Margin = new System.Windows.Forms.Padding(4);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(268, 44);
            this.TB_password.TabIndex = 3;
            this.TB_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(16, 144);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(123, 18);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Nom d\'utilisateur";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 261);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(99, 18);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Mot de passe";
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = global::UniversCenter.Properties.Resources.exit_32px;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 60D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(239, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(48, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.Black;
            this.btnExit.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnecte
            // 
            this.btnConnecte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnConnecte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnecte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnConnecte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnecte.BorderRadius = 0;
            this.btnConnecte.ButtonText = "Entrer";
            this.btnConnecte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnecte.DisabledColor = System.Drawing.Color.Gray;
            this.btnConnecte.Iconcolor = System.Drawing.Color.Black;
            this.btnConnecte.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConnecte.Iconimage")));
            this.btnConnecte.Iconimage_right = null;
            this.btnConnecte.Iconimage_right_Selected = null;
            this.btnConnecte.Iconimage_Selected = null;
            this.btnConnecte.IconMarginLeft = 0;
            this.btnConnecte.IconMarginRight = 0;
            this.btnConnecte.IconRightVisible = true;
            this.btnConnecte.IconRightZoom = 0D;
            this.btnConnecte.IconVisible = true;
            this.btnConnecte.IconZoom = 100D;
            this.btnConnecte.IsTab = false;
            this.btnConnecte.Location = new System.Drawing.Point(19, 390);
            this.btnConnecte.Name = "btnConnecte";
            this.btnConnecte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnConnecte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnConnecte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConnecte.selected = false;
            this.btnConnecte.Size = new System.Drawing.Size(214, 48);
            this.btnConnecte.TabIndex = 6;
            this.btnConnecte.Text = "Entrer";
            this.btnConnecte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnecte.Textcolor = System.Drawing.Color.Black;
            this.btnConnecte.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecte.Click += new System.EventHandler(this.btnConnecte_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnecte);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TB_username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TB_password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnConnecte;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
    }
}