
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
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.TB_cherche = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_AffecterEleve = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_SupprimerEleve = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_ModifierEleve = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_AjouterEleve = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Eleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AffecterEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SupprimerEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifierEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AjouterEleve)).BeginInit();
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
            // btn_AffecterEleve
            // 
            this.btn_AffecterEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btn_AffecterEleve.Image = global::UniversCenter.Properties.Resources.joining_queue_32px;
            this.btn_AffecterEleve.ImageActive = null;
            this.btn_AffecterEleve.Location = new System.Drawing.Point(171, 80);
            this.btn_AffecterEleve.Name = "btn_AffecterEleve";
            this.btn_AffecterEleve.Size = new System.Drawing.Size(40, 40);
            this.btn_AffecterEleve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AffecterEleve.TabIndex = 7;
            this.btn_AffecterEleve.TabStop = false;
            this.btn_AffecterEleve.Zoom = 10;
            // 
            // btn_SupprimerEleve
            // 
            this.btn_SupprimerEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btn_SupprimerEleve.Image = global::UniversCenter.Properties.Resources.Delete_32px;
            this.btn_SupprimerEleve.ImageActive = null;
            this.btn_SupprimerEleve.Location = new System.Drawing.Point(125, 80);
            this.btn_SupprimerEleve.Name = "btn_SupprimerEleve";
            this.btn_SupprimerEleve.Size = new System.Drawing.Size(40, 40);
            this.btn_SupprimerEleve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_SupprimerEleve.TabIndex = 6;
            this.btn_SupprimerEleve.TabStop = false;
            this.btn_SupprimerEleve.Zoom = 10;
            // 
            // btn_ModifierEleve
            // 
            this.btn_ModifierEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btn_ModifierEleve.Image = global::UniversCenter.Properties.Resources.registration_32px;
            this.btn_ModifierEleve.ImageActive = null;
            this.btn_ModifierEleve.Location = new System.Drawing.Point(79, 80);
            this.btn_ModifierEleve.Name = "btn_ModifierEleve";
            this.btn_ModifierEleve.Size = new System.Drawing.Size(40, 40);
            this.btn_ModifierEleve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_ModifierEleve.TabIndex = 5;
            this.btn_ModifierEleve.TabStop = false;
            this.btn_ModifierEleve.Zoom = 10;
            // 
            // btn_AjouterEleve
            // 
            this.btn_AjouterEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btn_AjouterEleve.Image = ((System.Drawing.Image)(resources.GetObject("btn_AjouterEleve.Image")));
            this.btn_AjouterEleve.ImageActive = null;
            this.btn_AjouterEleve.Location = new System.Drawing.Point(33, 80);
            this.btn_AjouterEleve.Name = "btn_AjouterEleve";
            this.btn_AjouterEleve.Size = new System.Drawing.Size(40, 40);
            this.btn_AjouterEleve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_AjouterEleve.TabIndex = 4;
            this.btn_AjouterEleve.TabStop = false;
            this.btn_AjouterEleve.Zoom = 10;
            this.btn_AjouterEleve.Click += new System.EventHandler(this.btn_AjouterEleve_Click);
            // 
            // Eleves_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1070, 700);
            this.Controls.Add(this.TB_cherche);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.btn_AffecterEleve);
            this.Controls.Add(this.btn_SupprimerEleve);
            this.Controls.Add(this.btn_ModifierEleve);
            this.Controls.Add(this.btn_AjouterEleve);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_AffecterEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SupprimerEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifierEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AjouterEleve)).EndInit();
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
        private Bunifu.Framework.UI.BunifuImageButton btn_AjouterEleve;
        private Bunifu.Framework.UI.BunifuImageButton btn_ModifierEleve;
        private Bunifu.Framework.UI.BunifuImageButton btn_SupprimerEleve;
        private Bunifu.Framework.UI.BunifuImageButton btn_AffecterEleve;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TB_cherche;
    }
}