namespace p19057_diceGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstMenu = new System.Windows.Forms.Panel();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.secondMenu = new System.Windows.Forms.Panel();
            this.warningMsgLevel = new System.Windows.Forms.Label();
            this.warningMsgName = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.linePnl = new System.Windows.Forms.Panel();
            this.SelectLevelLabel = new System.Windows.Forms.Label();
            this.EnterUsernameLabel = new System.Windows.Forms.Label();
            this.hardOption = new System.Windows.Forms.RadioButton();
            this.normalOption = new System.Windows.Forms.RadioButton();
            this.easyOption = new System.Windows.Forms.RadioButton();
            this.returnBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.gamePnl = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.ingamePnl = new System.Windows.Forms.Panel();
            this.tryAgainPnl = new System.Windows.Forms.Panel();
            this.restartBtn = new System.Windows.Forms.Button();
            this.returntoTheMainMenu = new System.Windows.Forms.Button();
            this.dicePictureBox = new System.Windows.Forms.PictureBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.timeCountdown = new System.Windows.Forms.Timer(this.components);
            this.thirdMenu = new System.Windows.Forms.Panel();
            this.scoreListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diffucultyLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnScoreboardBtn = new System.Windows.Forms.Button();
            this.easyLevelTimer = new System.Windows.Forms.Timer(this.components);
            this.normalLevelTimer = new System.Windows.Forms.Timer(this.components);
            this.hardLevelTimer = new System.Windows.Forms.Timer(this.components);
            this.infoPanel = new System.Windows.Forms.Panel();
            this.returnInfoButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.firstMenu.SuspendLayout();
            this.secondMenu.SuspendLayout();
            this.gamePnl.SuspendLayout();
            this.ingamePnl.SuspendLayout();
            this.tryAgainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).BeginInit();
            this.thirdMenu.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstMenu
            // 
            this.firstMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstMenu.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu.Controls.Add(this.scoreBtn);
            this.firstMenu.Controls.Add(this.playBtn);
            this.firstMenu.Controls.Add(this.infoBtn);
            this.firstMenu.Location = new System.Drawing.Point(143, 53);
            this.firstMenu.Margin = new System.Windows.Forms.Padding(50);
            this.firstMenu.Name = "firstMenu";
            this.firstMenu.Size = new System.Drawing.Size(692, 511);
            this.firstMenu.TabIndex = 3;
            // 
            // scoreBtn
            // 
            this.scoreBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.scoreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreBtn.FlatAppearance.BorderSize = 0;
            this.scoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.scoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreBtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBtn.ForeColor = System.Drawing.Color.Black;
            this.scoreBtn.Location = new System.Drawing.Point(254, 200);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(200, 51);
            this.scoreBtn.TabIndex = 1;
            this.scoreBtn.Text = "Scoreboard";
            this.scoreBtn.UseVisualStyleBackColor = false;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.Black;
            this.playBtn.Location = new System.Drawing.Point(284, 100);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(110, 54);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoBtn.BackColor = System.Drawing.Color.Transparent;
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.infoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBtn.ForeColor = System.Drawing.Color.Black;
            this.infoBtn.Location = new System.Drawing.Point(284, 295);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(110, 64);
            this.infoBtn.TabIndex = 2;
            this.infoBtn.Text = "Info";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // secondMenu
            // 
            this.secondMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondMenu.BackColor = System.Drawing.Color.Transparent;
            this.secondMenu.Controls.Add(this.warningMsgLevel);
            this.secondMenu.Controls.Add(this.warningMsgName);
            this.secondMenu.Controls.Add(this.usernameBox);
            this.secondMenu.Controls.Add(this.linePnl);
            this.secondMenu.Controls.Add(this.SelectLevelLabel);
            this.secondMenu.Controls.Add(this.EnterUsernameLabel);
            this.secondMenu.Controls.Add(this.hardOption);
            this.secondMenu.Controls.Add(this.normalOption);
            this.secondMenu.Controls.Add(this.easyOption);
            this.secondMenu.Controls.Add(this.returnBtn);
            this.secondMenu.Controls.Add(this.startBtn);
            this.secondMenu.Location = new System.Drawing.Point(143, 53);
            this.secondMenu.Margin = new System.Windows.Forms.Padding(50);
            this.secondMenu.Name = "secondMenu";
            this.secondMenu.Size = new System.Drawing.Size(692, 511);
            this.secondMenu.TabIndex = 4;
            // 
            // warningMsgLevel
            // 
            this.warningMsgLevel.AutoSize = true;
            this.warningMsgLevel.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMsgLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warningMsgLevel.Location = new System.Drawing.Point(272, 313);
            this.warningMsgLevel.Name = "warningMsgLevel";
            this.warningMsgLevel.Size = new System.Drawing.Size(141, 17);
            this.warningMsgLevel.TabIndex = 12;
            this.warningMsgLevel.Text = "Please select a level";
            // 
            // warningMsgName
            // 
            this.warningMsgName.AutoSize = true;
            this.warningMsgName.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMsgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warningMsgName.Location = new System.Drawing.Point(272, 144);
            this.warningMsgName.Name = "warningMsgName";
            this.warningMsgName.Size = new System.Drawing.Size(163, 17);
            this.warningMsgName.TabIndex = 11;
            this.warningMsgName.Text = "Please enter a username";
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameBox.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(254, 112);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(0);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(200, 29);
            this.usernameBox.TabIndex = 10;
            // 
            // linePnl
            // 
            this.linePnl.BackColor = System.Drawing.Color.Black;
            this.linePnl.Location = new System.Drawing.Point(254, 141);
            this.linePnl.Margin = new System.Windows.Forms.Padding(0);
            this.linePnl.Name = "linePnl";
            this.linePnl.Size = new System.Drawing.Size(200, 3);
            this.linePnl.TabIndex = 9;
            // 
            // SelectLevelLabel
            // 
            this.SelectLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectLevelLabel.AutoSize = true;
            this.SelectLevelLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLevelLabel.Location = new System.Drawing.Point(248, 170);
            this.SelectLevelLabel.Name = "SelectLevelLabel";
            this.SelectLevelLabel.Size = new System.Drawing.Size(244, 36);
            this.SelectLevelLabel.TabIndex = 7;
            this.SelectLevelLabel.Text = "Choose difficulty:";
            // 
            // EnterUsernameLabel
            // 
            this.EnterUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterUsernameLabel.AutoSize = true;
            this.EnterUsernameLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterUsernameLabel.Location = new System.Drawing.Point(235, 61);
            this.EnterUsernameLabel.Name = "EnterUsernameLabel";
            this.EnterUsernameLabel.Size = new System.Drawing.Size(238, 36);
            this.EnterUsernameLabel.TabIndex = 6;
            this.EnterUsernameLabel.Text = "Enter a username:";
            // 
            // hardOption
            // 
            this.hardOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hardOption.AutoSize = true;
            this.hardOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardOption.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardOption.Location = new System.Drawing.Point(300, 276);
            this.hardOption.Name = "hardOption";
            this.hardOption.Size = new System.Drawing.Size(75, 32);
            this.hardOption.TabIndex = 5;
            this.hardOption.TabStop = true;
            this.hardOption.Text = "Hard";
            this.hardOption.UseVisualStyleBackColor = true;
            // 
            // normalOption
            // 
            this.normalOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.normalOption.AutoSize = true;
            this.normalOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.normalOption.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalOption.Location = new System.Drawing.Point(300, 238);
            this.normalOption.Name = "normalOption";
            this.normalOption.Size = new System.Drawing.Size(109, 32);
            this.normalOption.TabIndex = 4;
            this.normalOption.TabStop = true;
            this.normalOption.Text = "Normal";
            this.normalOption.UseVisualStyleBackColor = true;
            // 
            // easyOption
            // 
            this.easyOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.easyOption.AutoSize = true;
            this.easyOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyOption.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyOption.Location = new System.Drawing.Point(300, 200);
            this.easyOption.Name = "easyOption";
            this.easyOption.Size = new System.Drawing.Size(77, 32);
            this.easyOption.TabIndex = 3;
            this.easyOption.TabStop = true;
            this.easyOption.Text = "Easy";
            this.easyOption.UseVisualStyleBackColor = true;
            // 
            // returnBtn
            // 
            this.returnBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.returnBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.returnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.Black;
            this.returnBtn.Location = new System.Drawing.Point(275, 391);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(119, 38);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return the menu";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.Black;
            this.startBtn.Location = new System.Drawing.Point(284, 333);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(110, 52);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // gamePnl
            // 
            this.gamePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePnl.BackgroundImage = global::p19057_diceGame.Properties.Resources.aiqseucuew4umusgdsvk2rzdsgfxieoykbhods0cd36bafni9pjfalu00phqqzcx_;
            this.gamePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePnl.Controls.Add(this.timeLabel);
            this.gamePnl.Controls.Add(this.scoreLabel);
            this.gamePnl.Controls.Add(this.ingamePnl);
            this.gamePnl.Controls.Add(this.sumLabel);
            this.gamePnl.Controls.Add(this.timerLabel);
            this.gamePnl.Location = new System.Drawing.Point(0, 0);
            this.gamePnl.Name = "gamePnl";
            this.gamePnl.Size = new System.Drawing.Size(1010, 629);
            this.gamePnl.TabIndex = 4;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(729, 53);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(84, 36);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Time:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(563, 53);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(93, 36);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingamePnl
            // 
            this.ingamePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingamePnl.BackColor = System.Drawing.Color.Transparent;
            this.ingamePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ingamePnl.Controls.Add(this.tryAgainPnl);
            this.ingamePnl.Controls.Add(this.dicePictureBox);
            this.ingamePnl.Location = new System.Drawing.Point(146, 96);
            this.ingamePnl.Name = "ingamePnl";
            this.ingamePnl.Size = new System.Drawing.Size(738, 449);
            this.ingamePnl.TabIndex = 3;
            // 
            // tryAgainPnl
            // 
            this.tryAgainPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tryAgainPnl.Controls.Add(this.restartBtn);
            this.tryAgainPnl.Controls.Add(this.returntoTheMainMenu);
            this.tryAgainPnl.Location = new System.Drawing.Point(3, 3);
            this.tryAgainPnl.Name = "tryAgainPnl";
            this.tryAgainPnl.Size = new System.Drawing.Size(732, 443);
            this.tryAgainPnl.TabIndex = 1;
            // 
            // restartBtn
            // 
            this.restartBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restartBtn.BackColor = System.Drawing.Color.Transparent;
            this.restartBtn.FlatAppearance.BorderSize = 0;
            this.restartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.restartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.ForeColor = System.Drawing.Color.Black;
            this.restartBtn.Location = new System.Drawing.Point(262, 136);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(167, 50);
            this.restartBtn.TabIndex = 6;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // returntoTheMainMenu
            // 
            this.returntoTheMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.returntoTheMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.returntoTheMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returntoTheMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returntoTheMainMenu.FlatAppearance.BorderSize = 0;
            this.returntoTheMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.returntoTheMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.returntoTheMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returntoTheMainMenu.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntoTheMainMenu.ForeColor = System.Drawing.Color.Black;
            this.returntoTheMainMenu.Location = new System.Drawing.Point(182, 261);
            this.returntoTheMainMenu.Name = "returntoTheMainMenu";
            this.returntoTheMainMenu.Size = new System.Drawing.Size(350, 40);
            this.returntoTheMainMenu.TabIndex = 2;
            this.returntoTheMainMenu.Text = "Return to the main menu";
            this.returntoTheMainMenu.UseVisualStyleBackColor = false;
            this.returntoTheMainMenu.Click += new System.EventHandler(this.returntoTheMainMenu_Click);
            // 
            // dicePictureBox
            // 
            this.dicePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dicePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dicePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dicePictureBox.Location = new System.Drawing.Point(148, 101);
            this.dicePictureBox.Name = "dicePictureBox";
            this.dicePictureBox.Size = new System.Drawing.Size(64, 64);
            this.dicePictureBox.TabIndex = 0;
            this.dicePictureBox.TabStop = false;
            this.dicePictureBox.Click += new System.EventHandler(this.dicePictureBox_Click);
            // 
            // sumLabel
            // 
            this.sumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sumLabel.AutoSize = true;
            this.sumLabel.BackColor = System.Drawing.Color.Transparent;
            this.sumLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLabel.Location = new System.Drawing.Point(666, 53);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(33, 36);
            this.sumLabel.TabIndex = 5;
            this.sumLabel.Text = "0";
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(816, 53);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(72, 36);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "timer";
            // 
            // timeCountdown
            // 
            this.timeCountdown.Interval = 1000;
            this.timeCountdown.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // thirdMenu
            // 
            this.thirdMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thirdMenu.BackColor = System.Drawing.Color.Transparent;
            this.thirdMenu.Controls.Add(this.scoreListView);
            this.thirdMenu.Controls.Add(this.returnScoreboardBtn);
            this.thirdMenu.Location = new System.Drawing.Point(143, 53);
            this.thirdMenu.Margin = new System.Windows.Forms.Padding(50);
            this.thirdMenu.Name = "thirdMenu";
            this.thirdMenu.Size = new System.Drawing.Size(692, 511);
            this.thirdMenu.TabIndex = 7;
            // 
            // scoreListView
            // 
            this.scoreListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.scoreListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.scoreHeader,
            this.diffucultyLevel});
            this.scoreListView.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreListView.HideSelection = false;
            this.scoreListView.HoverSelection = true;
            this.scoreListView.Location = new System.Drawing.Point(135, 74);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(458, 273);
            this.scoreListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.scoreListView.TabIndex = 2;
            this.scoreListView.UseCompatibleStateImageBehavior = false;
            this.scoreListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            // 
            // scoreHeader
            // 
            this.scoreHeader.Text = "Score";
            // 
            // diffucultyLevel
            // 
            this.diffucultyLevel.Text = "Difficulty";
            // 
            // returnScoreboardBtn
            // 
            this.returnScoreboardBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.returnScoreboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnScoreboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnScoreboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnScoreboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnScoreboardBtn.FlatAppearance.BorderSize = 0;
            this.returnScoreboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.returnScoreboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.returnScoreboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnScoreboardBtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnScoreboardBtn.ForeColor = System.Drawing.Color.Black;
            this.returnScoreboardBtn.Location = new System.Drawing.Point(188, 365);
            this.returnScoreboardBtn.Name = "returnScoreboardBtn";
            this.returnScoreboardBtn.Size = new System.Drawing.Size(325, 42);
            this.returnScoreboardBtn.TabIndex = 1;
            this.returnScoreboardBtn.Text = "Return to the menu";
            this.returnScoreboardBtn.UseVisualStyleBackColor = false;
            this.returnScoreboardBtn.Click += new System.EventHandler(this.returnScoreboardBtn_Click);
            // 
            // easyLevelTimer
            // 
            this.easyLevelTimer.Interval = 1000;
            this.easyLevelTimer.Tick += new System.EventHandler(this.easyLevelTimer_Tick);
            // 
            // normalLevelTimer
            // 
            this.normalLevelTimer.Interval = 700;
            this.normalLevelTimer.Tick += new System.EventHandler(this.normalLevelTimer_Tick);
            // 
            // hardLevelTimer
            // 
            this.hardLevelTimer.Interval = 600;
            this.hardLevelTimer.Tick += new System.EventHandler(this.hardLevelTimer_Tick);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Controls.Add(this.returnInfoButton);
            this.infoPanel.Location = new System.Drawing.Point(143, 53);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(50);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(692, 511);
            this.infoPanel.TabIndex = 8;
            // 
            // returnInfoButton
            // 
            this.returnInfoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.returnInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.returnInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnInfoButton.FlatAppearance.BorderSize = 0;
            this.returnInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.returnInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.returnInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnInfoButton.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnInfoButton.ForeColor = System.Drawing.Color.Black;
            this.returnInfoButton.Location = new System.Drawing.Point(188, 365);
            this.returnInfoButton.Name = "returnInfoButton";
            this.returnInfoButton.Size = new System.Drawing.Size(325, 42);
            this.returnInfoButton.TabIndex = 1;
            this.returnInfoButton.Text = "Return to the menu";
            this.returnInfoButton.UseVisualStyleBackColor = false;
            this.returnInfoButton.Click += new System.EventHandler(this.returnInfoButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(84, 71);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(517, 280);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::p19057_diceGame.Properties.Resources.depositphotos_71171979_stock_photo_old_parchment_on_aged_wooden;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 629);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.thirdMenu);
            this.Controls.Add(this.gamePnl);
            this.Controls.Add(this.secondMenu);
            this.Controls.Add(this.firstMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DiceMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.firstMenu.ResumeLayout(false);
            this.secondMenu.ResumeLayout(false);
            this.secondMenu.PerformLayout();
            this.gamePnl.ResumeLayout(false);
            this.gamePnl.PerformLayout();
            this.ingamePnl.ResumeLayout(false);
            this.tryAgainPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).EndInit();
            this.thirdMenu.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel firstMenu;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Panel secondMenu;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel gamePnl;
        private System.Windows.Forms.Button returntoTheMainMenu;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel ingamePnl;
        private System.Windows.Forms.PictureBox dicePictureBox;
        private System.Windows.Forms.Timer timeCountdown;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Panel thirdMenu;
        private System.Windows.Forms.ListView scoreListView;
        private System.Windows.Forms.Button returnScoreboardBtn;
        private System.Windows.Forms.Label EnterUsernameLabel;
        private System.Windows.Forms.RadioButton hardOption;
        private System.Windows.Forms.RadioButton normalOption;
        private System.Windows.Forms.RadioButton easyOption;
        private System.Windows.Forms.Label SelectLevelLabel;
        private System.Windows.Forms.Panel linePnl;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label warningMsgName;
        private System.Windows.Forms.Label warningMsgLevel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer easyLevelTimer;
        private System.Windows.Forms.Timer normalLevelTimer;
        private System.Windows.Forms.Timer hardLevelTimer;
        private System.Windows.Forms.Panel tryAgainPnl;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader scoreHeader;
        private System.Windows.Forms.ColumnHeader diffucultyLevel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button returnInfoButton;
        private System.Windows.Forms.Label infoLabel;
    }
}

