
namespace UniversCenter.PL
{
    partial class msgBox
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
            this.lbl_Titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Titre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Titre.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.lbl_Titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(326, 35);
            this.lbl_Titre.TabIndex = 1;
            this.lbl_Titre.Text = "Titre";
            // 
            // lbl_Message
            // 
            this.lbl_Message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Message.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Message.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.lbl_Message.Location = new System.Drawing.Point(14, 49);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(324, 62);
            this.lbl_Message.TabIndex = 2;
            this.lbl_Message.Text = "Message";
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "OK";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = global::UniversCenter.Properties.Resources.Check_Circle_26px;
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 60D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(107, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnOk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(150, 40);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Textcolor = System.Drawing.Color.Black;
            this.btnOk.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // msgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_Titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgBox";
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomLabel lbl_Titre;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_Message;
        public Bunifu.Framework.UI.BunifuFlatButton btnOk;
    }
}