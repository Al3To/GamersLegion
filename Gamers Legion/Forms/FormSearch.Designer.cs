namespace Gamers_Legion.Forms
{
    partial class FormSearch
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
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.GameCover = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.iconSwitchLanguage = new FontAwesome.Sharp.IconButton();
            this.labelLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameCover)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchBar.Location = new System.Drawing.Point(276, 38);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(210, 26);
            this.SearchBar.TabIndex = 4;
            this.SearchBar.Text = "Search";
            this.SearchBar.Enter += new System.EventHandler(this.SearchBar_Enter);
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyDown);
            this.SearchBar.Leave += new System.EventHandler(this.SearchBar_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 23;
            this.btnSearch.Location = new System.Drawing.Point(492, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 26);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GameCover
            // 
            this.GameCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameCover.Location = new System.Drawing.Point(47, 92);
            this.GameCover.Name = "GameCover";
            this.GameCover.Size = new System.Drawing.Size(187, 187);
            this.GameCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameCover.TabIndex = 6;
            this.GameCover.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(276, 92);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 24);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "label1";
            this.labelTitle.Visible = false;
            // 
            // labelSummary
            // 
            this.labelSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSummary.AutoEllipsis = true;
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSummary.Location = new System.Drawing.Point(276, 130);
            this.labelSummary.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(51, 20);
            this.labelSummary.TabIndex = 8;
            this.labelSummary.Text = "label1";
            this.labelSummary.Visible = false;
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoEllipsis = true;
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelError.Location = new System.Drawing.Point(277, 67);
            this.labelError.MaximumSize = new System.Drawing.Size(1000, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(115, 16);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Gioco non trovato!";
            this.labelError.Visible = false;
            // 
            // labelRating
            // 
            this.labelRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRating.Location = new System.Drawing.Point(695, 92);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(60, 24);
            this.labelRating.TabIndex = 10;
            this.labelRating.Text = "label1";
            this.labelRating.Visible = false;
            // 
            // iconSwitchLanguage
            // 
            this.iconSwitchLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconSwitchLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSwitchLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSwitchLanguage.ForeColor = System.Drawing.Color.Thistle;
            this.iconSwitchLanguage.IconChar = FontAwesome.Sharp.IconChar.Language;
            this.iconSwitchLanguage.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconSwitchLanguage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSwitchLanguage.IconSize = 23;
            this.iconSwitchLanguage.Location = new System.Drawing.Point(726, 62);
            this.iconSwitchLanguage.Name = "iconSwitchLanguage";
            this.iconSwitchLanguage.Size = new System.Drawing.Size(29, 26);
            this.iconSwitchLanguage.TabIndex = 11;
            this.iconSwitchLanguage.UseVisualStyleBackColor = true;
            this.iconSwitchLanguage.Click += new System.EventHandler(this.iconSwitchLanguage_Click);
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoading.AutoEllipsis = true;
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLoading.Location = new System.Drawing.Point(323, 15);
            this.labelLoading.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(111, 20);
            this.labelLoading.TabIndex = 20;
            this.labelLoading.Text = "Caricamento...";
            this.labelLoading.Visible = false;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.iconSwitchLanguage);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.GameCover);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchBar);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            ((System.ComponentModel.ISupportInitialize)(this.GameCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBar;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.PictureBox GameCover;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelRating;
        private FontAwesome.Sharp.IconButton iconSwitchLanguage;
        private System.Windows.Forms.Label labelLoading;
    }
}