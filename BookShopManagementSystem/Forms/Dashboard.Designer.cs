namespace BookShopManagementSystem.Forms
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.viewSalesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.expensesButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.salebooksButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.shutDownButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.homePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 140);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Georgia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "North Books Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookShopManagementSystem.Properties.Resources.icons8_penguin_64;
            this.pictureBox1.Location = new System.Drawing.Point(110, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Image = global::BookShopManagementSystem.Properties.Resources.menu;
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(22, 9);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(39, 42);
            this.menuButton.TabIndex = 3;
            this.menuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.homePanel.Controls.Add(this.sidePanel);
            this.homePanel.Controls.Add(this.settingsButton);
            this.homePanel.Controls.Add(this.viewSalesButton);
            this.homePanel.Controls.Add(this.usersButton);
            this.homePanel.Controls.Add(this.expensesButton);
            this.homePanel.Controls.Add(this.purchaseButton);
            this.homePanel.Controls.Add(this.salebooksButton);
            this.homePanel.Controls.Add(this.homeButton);
            this.homePanel.Controls.Add(this.panel1);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(226, 720);
            this.homePanel.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.ForeColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(3, 147);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(7, 59);
            this.sidePanel.TabIndex = 3;
            // 
            // settingsButton
            // 
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = global::BookShopManagementSystem.Properties.Resources.icons8_services_64;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(12, 539);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(203, 59);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "   Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // viewSalesButton
            // 
            this.viewSalesButton.FlatAppearance.BorderSize = 0;
            this.viewSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSalesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSalesButton.ForeColor = System.Drawing.Color.White;
            this.viewSalesButton.Image = global::BookShopManagementSystem.Properties.Resources.viewsales;
            this.viewSalesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewSalesButton.Location = new System.Drawing.Point(12, 474);
            this.viewSalesButton.Name = "viewSalesButton";
            this.viewSalesButton.Size = new System.Drawing.Size(203, 59);
            this.viewSalesButton.TabIndex = 3;
            this.viewSalesButton.Text = "   View Sales";
            this.viewSalesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewSalesButton.UseVisualStyleBackColor = true;
            this.viewSalesButton.Click += new System.EventHandler(this.viewSalesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Image = global::BookShopManagementSystem.Properties.Resources.users;
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Location = new System.Drawing.Point(12, 409);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(203, 59);
            this.usersButton.TabIndex = 3;
            this.usersButton.Text = "   Users";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // expensesButton
            // 
            this.expensesButton.FlatAppearance.BorderSize = 0;
            this.expensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesButton.ForeColor = System.Drawing.Color.White;
            this.expensesButton.Image = global::BookShopManagementSystem.Properties.Resources.expenses;
            this.expensesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesButton.Location = new System.Drawing.Point(12, 344);
            this.expensesButton.Name = "expensesButton";
            this.expensesButton.Size = new System.Drawing.Size(203, 59);
            this.expensesButton.TabIndex = 3;
            this.expensesButton.Text = "   Expenses";
            this.expensesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.expensesButton.UseVisualStyleBackColor = true;
            this.expensesButton.Click += new System.EventHandler(this.ExpensesButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.FlatAppearance.BorderSize = 0;
            this.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseButton.ForeColor = System.Drawing.Color.White;
            this.purchaseButton.Image = global::BookShopManagementSystem.Properties.Resources.icons8_shopping_cart_801;
            this.purchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseButton.Location = new System.Drawing.Point(12, 276);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(203, 59);
            this.purchaseButton.TabIndex = 3;
            this.purchaseButton.Text = "   Purchase Items";
            this.purchaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // salebooksButton
            // 
            this.salebooksButton.FlatAppearance.BorderSize = 0;
            this.salebooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salebooksButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salebooksButton.ForeColor = System.Drawing.Color.White;
            this.salebooksButton.Image = global::BookShopManagementSystem.Properties.Resources.icons8_books_48;
            this.salebooksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salebooksButton.Location = new System.Drawing.Point(12, 211);
            this.salebooksButton.Name = "salebooksButton";
            this.salebooksButton.Size = new System.Drawing.Size(203, 59);
            this.salebooksButton.TabIndex = 3;
            this.salebooksButton.Text = "   Sale Books";
            this.salebooksButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salebooksButton.UseVisualStyleBackColor = true;
            this.salebooksButton.Click += new System.EventHandler(this.SalebooksButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = global::BookShopManagementSystem.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(12, 146);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(203, 59);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "   Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.shutDownButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(226, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(974, 48);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(31, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "North Books Shop Market";
            // 
            // shutDownButton
            // 
            this.shutDownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.shutDownButton.FlatAppearance.BorderSize = 0;
            this.shutDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutDownButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutDownButton.ForeColor = System.Drawing.Color.White;
            this.shutDownButton.Image = global::BookShopManagementSystem.Properties.Resources.shutdown_Blue;
            this.shutDownButton.Location = new System.Drawing.Point(928, 0);
            this.shutDownButton.Name = "shutDownButton";
            this.shutDownButton.Size = new System.Drawing.Size(46, 48);
            this.shutDownButton.TabIndex = 3;
            this.shutDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shutDownButton.UseVisualStyleBackColor = true;
            this.shutDownButton.Click += new System.EventHandler(this.shutDownButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.timeLabel);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(226, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(974, 92);
            this.panel5.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(864, 41);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(83, 19);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "HH:MM:SS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(141, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Role: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(141, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Davit Margvelashvili";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome: ";
            // 
            // timer
            // 
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(226, 140);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(974, 580);
            this.controlsPanel.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.homePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button viewSalesButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button expensesButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button salebooksButton;
        private System.Windows.Forms.Button shutDownButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Panel controlsPanel;
    }
}