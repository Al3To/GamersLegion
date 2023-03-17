namespace Gamers_Legion.Forms
{
    partial class FormFindTheGame
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
            this.GameCover = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.Guess = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.Heart3 = new FontAwesome.Sharp.IconPictureBox();
            this.Heart2 = new FontAwesome.Sharp.IconPictureBox();
            this.Heart1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelScoreTitle = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.iconEnter = new FontAwesome.Sharp.IconButton();
            this.labelError = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameCover
            // 
            this.GameCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameCover.Location = new System.Drawing.Point(278, 71);
            this.GameCover.Name = "GameCover";
            this.GameCover.Size = new System.Drawing.Size(215, 223);
            this.GameCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameCover.TabIndex = 7;
            this.GameCover.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(306, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 24);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Riconosci Il Gioco";
            // 
            // Guess
            // 
            this.Guess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guess.ForeColor = System.Drawing.Color.Black;
            this.Guess.Location = new System.Drawing.Point(278, 315);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(215, 26);
            this.Guess.TabIndex = 10;
            this.Guess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Guess_KeyDown);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.AutoEllipsis = true;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelScore.Location = new System.Drawing.Point(254, 72);
            this.labelScore.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(18, 20);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "0";
            // 
            // Heart3
            // 
            this.Heart3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Heart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Heart3.ForeColor = System.Drawing.Color.Red;
            this.Heart3.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.Heart3.IconColor = System.Drawing.Color.Red;
            this.Heart3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Heart3.IconSize = 28;
            this.Heart3.Location = new System.Drawing.Point(499, 71);
            this.Heart3.Name = "Heart3";
            this.Heart3.Size = new System.Drawing.Size(28, 29);
            this.Heart3.TabIndex = 12;
            this.Heart3.TabStop = false;
            // 
            // Heart2
            // 
            this.Heart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Heart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Heart2.ForeColor = System.Drawing.Color.Red;
            this.Heart2.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.Heart2.IconColor = System.Drawing.Color.Red;
            this.Heart2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Heart2.IconSize = 28;
            this.Heart2.Location = new System.Drawing.Point(533, 71);
            this.Heart2.Name = "Heart2";
            this.Heart2.Size = new System.Drawing.Size(28, 29);
            this.Heart2.TabIndex = 13;
            this.Heart2.TabStop = false;
            // 
            // Heart1
            // 
            this.Heart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Heart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Heart1.ForeColor = System.Drawing.Color.Red;
            this.Heart1.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.Heart1.IconColor = System.Drawing.Color.Red;
            this.Heart1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Heart1.IconSize = 28;
            this.Heart1.Location = new System.Drawing.Point(567, 71);
            this.Heart1.Name = "Heart1";
            this.Heart1.Size = new System.Drawing.Size(28, 29);
            this.Heart1.TabIndex = 14;
            this.Heart1.TabStop = false;
            // 
            // labelScoreTitle
            // 
            this.labelScoreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScoreTitle.AutoEllipsis = true;
            this.labelScoreTitle.AutoSize = true;
            this.labelScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelScoreTitle.Location = new System.Drawing.Point(174, 71);
            this.labelScoreTitle.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelScoreTitle.Name = "labelScoreTitle";
            this.labelScoreTitle.Size = new System.Drawing.Size(85, 20);
            this.labelScoreTitle.TabIndex = 15;
            this.labelScoreTitle.Text = "Punteggio:";
            // 
            // labelTip
            // 
            this.labelTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTip.AutoEllipsis = true;
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTip.Location = new System.Drawing.Point(275, 344);
            this.labelTip.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(173, 13);
            this.labelTip.TabIndex = 16;
            this.labelTip.Text = "Specifica il nome in modo completo";
            // 
            // iconEnter
            // 
            this.iconEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEnter.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconEnter.IconColor = System.Drawing.Color.Lime;
            this.iconEnter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEnter.IconSize = 28;
            this.iconEnter.Location = new System.Drawing.Point(494, 315);
            this.iconEnter.Name = "iconEnter";
            this.iconEnter.Size = new System.Drawing.Size(28, 26);
            this.iconEnter.TabIndex = 17;
            this.iconEnter.UseVisualStyleBackColor = true;
            this.iconEnter.Click += new System.EventHandler(this.iconEnter_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoEllipsis = true;
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(304, 272);
            this.labelError.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(169, 20);
            this.labelError.TabIndex = 18;
            this.labelError.Text = "Errore nel caricamento";
            this.labelError.Visible = false;
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoading.AutoEllipsis = true;
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLoading.Location = new System.Drawing.Point(499, 272);
            this.labelLoading.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(111, 20);
            this.labelLoading.TabIndex = 19;
            this.labelLoading.Text = "Caricamento...";
            this.labelLoading.Visible = false;
            // 
            // FormFindTheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.iconEnter);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelScoreTitle);
            this.Controls.Add(this.Heart1);
            this.Controls.Add(this.Heart2);
            this.Controls.Add(this.Heart3);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.GameCover);
            this.Name = "FormFindTheGame";
            this.Text = "FormFindTheGame";
            ((System.ComponentModel.ISupportInitialize)(this.GameCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameCover;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox Guess;
        private System.Windows.Forms.Label labelScore;
        private FontAwesome.Sharp.IconPictureBox Heart3;
        private FontAwesome.Sharp.IconPictureBox Heart2;
        private FontAwesome.Sharp.IconPictureBox Heart1;
        private System.Windows.Forms.Label labelScoreTitle;
        private System.Windows.Forms.Label labelTip;
        private FontAwesome.Sharp.IconButton iconEnter;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelLoading;
    }
}