namespace Gamers_Legion
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAddUser = new FontAwesome.Sharp.IconButton();
            this.buttonEventManager = new FontAwesome.Sharp.IconButton();
            this.buttonAddEvent = new FontAwesome.Sharp.IconButton();
            this.showEvents = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.labelDate);
            this.panelDesktop.Controls.Add(this.labelTime);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(768, 480);
            this.panelDesktop.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelDate.Location = new System.Drawing.Point(282, 320);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(233, 24);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "venerdì,12 dicembre, 2021";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Location = new System.Drawing.Point(315, 278);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(164, 42);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(206, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(768, 9);
            this.panelShadow.TabIndex = 6;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonClose);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(768, 75);
            this.panelTitleBar.TabIndex = 5;
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(721, 3);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(19, 18);
            this.buttonMaximize.TabIndex = 4;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(696, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(19, 18);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(746, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(19, 18);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(54, 44);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 35);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.buttonAddUser);
            this.panelMenu.Controls.Add(this.buttonEventManager);
            this.panelMenu.Controls.Add(this.buttonAddEvent);
            this.panelMenu.Controls.Add(this.showEvents);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 564);
            this.panelMenu.TabIndex = 4;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonAddUser.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAddUser.IconSize = 32;
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(0, 504);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonAddUser.Size = new System.Drawing.Size(220, 60);
            this.buttonAddUser.TabIndex = 4;
            this.buttonAddUser.Text = "Aggiungi Utente";
            this.buttonAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonEventManager
            // 
            this.buttonEventManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEventManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEventManager.FlatAppearance.BorderSize = 0;
            this.buttonEventManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEventManager.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.buttonEventManager.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonEventManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEventManager.IconSize = 32;
            this.buttonEventManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEventManager.Location = new System.Drawing.Point(0, 260);
            this.buttonEventManager.Name = "buttonEventManager";
            this.buttonEventManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonEventManager.Size = new System.Drawing.Size(220, 60);
            this.buttonEventManager.TabIndex = 3;
            this.buttonEventManager.Text = "Gestisci Eventi";
            this.buttonEventManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEventManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEventManager.UseVisualStyleBackColor = true;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddEvent.FlatAppearance.BorderSize = 0;
            this.buttonAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddEvent.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonAddEvent.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAddEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAddEvent.IconSize = 32;
            this.buttonAddEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEvent.Location = new System.Drawing.Point(0, 200);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonAddEvent.Size = new System.Drawing.Size(220, 60);
            this.buttonAddEvent.TabIndex = 2;
            this.buttonAddEvent.Text = "Aggiungi Evento";
            this.buttonAddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            // 
            // showEvents
            // 
            this.showEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.showEvents.FlatAppearance.BorderSize = 0;
            this.showEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.showEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.showEvents.IconColor = System.Drawing.Color.Gainsboro;
            this.showEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showEvents.IconSize = 32;
            this.showEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showEvents.Location = new System.Drawing.Point(0, 140);
            this.showEvents.Name = "showEvents";
            this.showEvents.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.showEvents.Size = new System.Drawing.Size(220, 60);
            this.showEvents.TabIndex = 1;
            this.showEvents.Text = "Visualizza Eventi";
            this.showEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showEvents.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Location = new System.Drawing.Point(-20, 36);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(237, 82);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 564);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton buttonAddUser;
        private FontAwesome.Sharp.IconButton buttonEventManager;
        private FontAwesome.Sharp.IconButton buttonAddEvent;
        private FontAwesome.Sharp.IconButton showEvents;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Timer timer1;
    }
}

