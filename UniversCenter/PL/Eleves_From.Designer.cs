
namespace UniversCenter.PL
{
    partial class Eleves_From
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eleves_From));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreEl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preEl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeEl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Eleve = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.TB_cherche = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Eleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(1070, 47);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Listes Des Eleves";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateN
            // 
            this.dateN.HeaderText = "Date Naissance";
            this.dateN.Name = "dateN";
            this.dateN.ReadOnly = true;
            // 
            // codeParent
            // 
            this.codeParent.HeaderText = "Code Parent";
            this.codeParent.Name = "codeParent";
            this.codeParent.ReadOnly = true;
            // 
            // NbGroupe
            // 
            this.NbGroupe.HeaderText = "Nombre Groupe";
            this.NbGroupe.Name = "NbGroupe";
            this.NbGroupe.ReadOnly = true;
            // 
            // NTel
            // 
            this.NTel.HeaderText = "Télephone";
            this.NTel.Name = "NTel";
            this.NTel.ReadOnly = true;
            // 
            // genreEl
            // 
            this.genreEl.HeaderText = "Genre";
            this.genreEl.Name = "genreEl";
            this.genreEl.ReadOnly = true;
            // 
            // preEl
            // 
            this.preEl.HeaderText = "Prénom";
            this.preEl.Name = "preEl";
            this.preEl.ReadOnly = true;
            // 
            // nameEl
            // 
            this.nameEl.HeaderText = "Nom";
            this.nameEl.Name = "nameEl";
            this.nameEl.ReadOnly = true;
            // 
            // codeEl
            // 
            this.codeEl.HeaderText = "Code";
            this.codeEl.Name = "codeEl";
            this.codeEl.ReadOnly = true;
            // 
            // DGV_Eleve
            // 
            this.DGV_Eleve.AllowUserToAddRows = false;
            this.DGV_Eleve.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Eleve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Eleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Eleve.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Eleve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Eleve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Eleve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Eleve.ColumnHeadersHeight = 30;
            this.DGV_Eleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Eleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeEl,
            this.nameEl,
            this.preEl,
            this.genreEl,
            this.NTel,
            this.NbGroupe,
            this.codeParent,
            this.dateN});
            this.DGV_Eleve.DoubleBuffered = true;
            this.DGV_Eleve.EnableHeadersVisualStyles = false;
            this.DGV_Eleve.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.DGV_Eleve.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.DGV_Eleve.Location = new System.Drawing.Point(33, 143);
            this.DGV_Eleve.Name = "DGV_Eleve";
            this.DGV_Eleve.ReadOnly = true;
            this.DGV_Eleve.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Eleve.Size = new System.Drawing.Size(1000, 466);
            this.DGV_Eleve.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(33, 80);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuImageButton2.Image = global::UniversCenter.Properties.Resources.registration_32px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(79, 80);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuImageButton3.Image = global::UniversCenter.Properties.Resources.Delete_32px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(125, 80);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton3.TabIndex = 6;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(171, 80);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 7;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(217, 80);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 40);
            this.bunifuDropdown1.TabIndex = 9;
            // 
            // TB_cherche
            // 
            this.TB_cherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_cherche.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_cherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_cherche.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TB_cherche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TB_cherche.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_cherche.HintText = "Rechercher";
            this.TB_cherche.isPassword = false;
            this.TB_cherche.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_cherche.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_cherche.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.TB_cherche.LineThickness = 3;
            this.TB_cherche.Location = new System.Drawing.Point(765, 80);
            this.TB_cherche.Margin = new System.Windows.Forms.Padding(4);
            this.TB_cherche.Name = "TB_cherche";
            this.TB_cherche.Size = new System.Drawing.Size(268, 44);
            this.TB_cherche.TabIndex = 10;
            this.TB_cherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Eleves_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1070, 700);
            this.Controls.Add(this.TB_cherche);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.DGV_Eleve);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eleves_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleves_From";
            this.Load += new System.EventHandler(this.Eleves_From_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Eleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateN;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreEl;
        private System.Windows.Forms.DataGridViewTextBoxColumn preEl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeEl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Eleve;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TB_cherche;
    }
}