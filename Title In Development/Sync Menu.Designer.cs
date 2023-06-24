namespace Title_In_Development
{
    partial class Sync_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sync_Menu));
            this.TCMenuTabs = new System.Windows.Forms.TabControl();
            this.TPMinecraftV1 = new System.Windows.Forms.TabPage();
            this.TBMV1Mods = new System.Windows.Forms.TextBox();
            this.TBMV1Bans = new System.Windows.Forms.TextBox();
            this.TBMV1Ops = new System.Windows.Forms.TextBox();
            this.RTBMV1ServerMOTD = new System.Windows.Forms.RichTextBox();
            this.LBMV1ViewDistance = new System.Windows.Forms.Label();
            this.LBMV1GenerateStructures = new System.Windows.Forms.Label();
            this.LBMV1MaxBuildHeight = new System.Windows.Forms.Label();
            this.LBMV1MaxPlayers = new System.Windows.Forms.Label();
            this.LBMV1PVP = new System.Windows.Forms.Label();
            this.LBMV1WhiteList = new System.Windows.Forms.Label();
            this.LBMV1LevelType = new System.Windows.Forms.Label();
            this.LBMV1ServerDifficulty = new System.Windows.Forms.Label();
            this.LBMV1ServerGamemode = new System.Windows.Forms.Label();
            this.BTMV1Stop = new System.Windows.Forms.Button();
            this.BTMV1Start = new System.Windows.Forms.Button();
            this.LBMV1ServerLastRan = new System.Windows.Forms.Label();
            this.LBMV1ServerStatus = new System.Windows.Forms.Label();
            this.LBMV1ServerIP = new System.Windows.Forms.Label();
            this.LBMV1ServerName = new System.Windows.Forms.Label();
            this.PBMV1Icon = new System.Windows.Forms.PictureBox();
            this.BTMV1AutoSync = new System.Windows.Forms.Button();
            this.BTMV1Check = new System.Windows.Forms.Button();
            this.BTMV1Sync = new System.Windows.Forms.Button();
            this.LBMV1SyncStatus = new System.Windows.Forms.Label();
            this.TPMinecraftV2 = new System.Windows.Forms.TabPage();
            this.TPLog = new System.Windows.Forms.TabPage();
            this.RTBLog = new System.Windows.Forms.RichTextBox();
            this.TPServerLog = new System.Windows.Forms.TabPage();
            this.BTSubmitCommand = new System.Windows.Forms.Button();
            this.TBCommand = new System.Windows.Forms.TextBox();
            this.TBServerConsole = new System.Windows.Forms.TextBox();
            this.TPChangeLog = new System.Windows.Forms.TabPage();
            this.RTBChangeLog = new System.Windows.Forms.RichTextBox();
            this.TMMV1Sync = new System.Windows.Forms.Timer(this.components);
            this.TMMV1Status = new System.Windows.Forms.Timer(this.components);
            this.TMRetry = new System.Windows.Forms.Timer(this.components);
            this.TCMenuTabs.SuspendLayout();
            this.TPMinecraftV1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMV1Icon)).BeginInit();
            this.TPLog.SuspendLayout();
            this.TPServerLog.SuspendLayout();
            this.TPChangeLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCMenuTabs
            // 
            this.TCMenuTabs.Controls.Add(this.TPMinecraftV1);
            this.TCMenuTabs.Controls.Add(this.TPMinecraftV2);
            this.TCMenuTabs.Controls.Add(this.TPLog);
            this.TCMenuTabs.Controls.Add(this.TPServerLog);
            this.TCMenuTabs.Controls.Add(this.TPChangeLog);
            this.TCMenuTabs.Location = new System.Drawing.Point(0, 0);
            this.TCMenuTabs.Name = "TCMenuTabs";
            this.TCMenuTabs.SelectedIndex = 0;
            this.TCMenuTabs.Size = new System.Drawing.Size(504, 481);
            this.TCMenuTabs.TabIndex = 0;
            this.TCMenuTabs.SelectedIndexChanged += new System.EventHandler(this.ChangeOfTab);
            // 
            // TPMinecraftV1
            // 
            this.TPMinecraftV1.Controls.Add(this.TBMV1Mods);
            this.TPMinecraftV1.Controls.Add(this.TBMV1Bans);
            this.TPMinecraftV1.Controls.Add(this.TBMV1Ops);
            this.TPMinecraftV1.Controls.Add(this.RTBMV1ServerMOTD);
            this.TPMinecraftV1.Controls.Add(this.LBMV1ViewDistance);
            this.TPMinecraftV1.Controls.Add(this.LBMV1GenerateStructures);
            this.TPMinecraftV1.Controls.Add(this.LBMV1MaxBuildHeight);
            this.TPMinecraftV1.Controls.Add(this.LBMV1MaxPlayers);
            this.TPMinecraftV1.Controls.Add(this.LBMV1PVP);
            this.TPMinecraftV1.Controls.Add(this.LBMV1WhiteList);
            this.TPMinecraftV1.Controls.Add(this.LBMV1LevelType);
            this.TPMinecraftV1.Controls.Add(this.LBMV1ServerDifficulty);
            this.TPMinecraftV1.Controls.Add(this.LBMV1ServerGamemode);
            this.TPMinecraftV1.Controls.Add(this.BTMV1Stop);
            this.TPMinecraftV1.Controls.Add(this.BTMV1Start);
            this.TPMinecraftV1.Controls.Add(this.LBMV1ServerLastRan);
            this.TPMinecraftV1.Controls.Add(this.LBMV1ServerStatus);
            this.TPMinecraftV1.Controls.Add(this.LBMV1ServerIP);
            this.TPMinecraftV1.Controls.Add(this.LBMV1ServerName);
            this.TPMinecraftV1.Controls.Add(this.PBMV1Icon);
            this.TPMinecraftV1.Controls.Add(this.BTMV1AutoSync);
            this.TPMinecraftV1.Controls.Add(this.BTMV1Check);
            this.TPMinecraftV1.Controls.Add(this.BTMV1Sync);
            this.TPMinecraftV1.Controls.Add(this.LBMV1SyncStatus);
            this.TPMinecraftV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPMinecraftV1.Location = new System.Drawing.Point(4, 22);
            this.TPMinecraftV1.Name = "TPMinecraftV1";
            this.TPMinecraftV1.Padding = new System.Windows.Forms.Padding(3);
            this.TPMinecraftV1.Size = new System.Drawing.Size(496, 455);
            this.TPMinecraftV1.TabIndex = 0;
            this.TPMinecraftV1.Text = "Minecraft 1.7.10";
            this.TPMinecraftV1.UseVisualStyleBackColor = true;
            this.TPMinecraftV1.Paint += new System.Windows.Forms.PaintEventHandler(this.Design);
            // 
            // TBMV1Mods
            // 
            this.TBMV1Mods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMV1Mods.Location = new System.Drawing.Point(8, 328);
            this.TBMV1Mods.Multiline = true;
            this.TBMV1Mods.Name = "TBMV1Mods";
            this.TBMV1Mods.ReadOnly = true;
            this.TBMV1Mods.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBMV1Mods.Size = new System.Drawing.Size(484, 123);
            this.TBMV1Mods.TabIndex = 28;
            this.TBMV1Mods.Text = "Mods:";
            // 
            // TBMV1Bans
            // 
            this.TBMV1Bans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMV1Bans.Location = new System.Drawing.Point(254, 283);
            this.TBMV1Bans.Multiline = true;
            this.TBMV1Bans.Name = "TBMV1Bans";
            this.TBMV1Bans.ReadOnly = true;
            this.TBMV1Bans.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBMV1Bans.Size = new System.Drawing.Size(238, 40);
            this.TBMV1Bans.TabIndex = 27;
            this.TBMV1Bans.Text = "Bans:";
            // 
            // TBMV1Ops
            // 
            this.TBMV1Ops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMV1Ops.Location = new System.Drawing.Point(8, 283);
            this.TBMV1Ops.Multiline = true;
            this.TBMV1Ops.Name = "TBMV1Ops";
            this.TBMV1Ops.ReadOnly = true;
            this.TBMV1Ops.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBMV1Ops.Size = new System.Drawing.Size(238, 40);
            this.TBMV1Ops.TabIndex = 26;
            this.TBMV1Ops.Text = "Ops:";
            // 
            // RTBMV1ServerMOTD
            // 
            this.RTBMV1ServerMOTD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RTBMV1ServerMOTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBMV1ServerMOTD.Location = new System.Drawing.Point(8, 172);
            this.RTBMV1ServerMOTD.Name = "RTBMV1ServerMOTD";
            this.RTBMV1ServerMOTD.ReadOnly = true;
            this.RTBMV1ServerMOTD.Size = new System.Drawing.Size(484, 40);
            this.RTBMV1ServerMOTD.TabIndex = 25;
            this.RTBMV1ServerMOTD.Text = "MOTD: ";
            // 
            // LBMV1ViewDistance
            // 
            this.LBMV1ViewDistance.AutoSize = true;
            this.LBMV1ViewDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1ViewDistance.Location = new System.Drawing.Point(368, 261);
            this.LBMV1ViewDistance.Name = "LBMV1ViewDistance";
            this.LBMV1ViewDistance.Size = new System.Drawing.Size(104, 17);
            this.LBMV1ViewDistance.TabIndex = 20;
            this.LBMV1ViewDistance.Text = "View Distance: ";
            // 
            // LBMV1GenerateStructures
            // 
            this.LBMV1GenerateStructures.AutoSize = true;
            this.LBMV1GenerateStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1GenerateStructures.Location = new System.Drawing.Point(150, 261);
            this.LBMV1GenerateStructures.Name = "LBMV1GenerateStructures";
            this.LBMV1GenerateStructures.Size = new System.Drawing.Size(145, 17);
            this.LBMV1GenerateStructures.TabIndex = 19;
            this.LBMV1GenerateStructures.Text = "Generate Structures: ";
            // 
            // LBMV1MaxBuildHeight
            // 
            this.LBMV1MaxBuildHeight.AutoSize = true;
            this.LBMV1MaxBuildHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1MaxBuildHeight.Location = new System.Drawing.Point(8, 261);
            this.LBMV1MaxBuildHeight.Name = "LBMV1MaxBuildHeight";
            this.LBMV1MaxBuildHeight.Size = new System.Drawing.Size(80, 17);
            this.LBMV1MaxBuildHeight.TabIndex = 18;
            this.LBMV1MaxBuildHeight.Text = "Build Limit: ";
            // 
            // LBMV1MaxPlayers
            // 
            this.LBMV1MaxPlayers.AutoSize = true;
            this.LBMV1MaxPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1MaxPlayers.Location = new System.Drawing.Point(380, 239);
            this.LBMV1MaxPlayers.Name = "LBMV1MaxPlayers";
            this.LBMV1MaxPlayers.Size = new System.Drawing.Size(92, 17);
            this.LBMV1MaxPlayers.TabIndex = 17;
            this.LBMV1MaxPlayers.Text = "Max Players: ";
            // 
            // LBMV1PVP
            // 
            this.LBMV1PVP.AutoSize = true;
            this.LBMV1PVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1PVP.Location = new System.Drawing.Point(211, 239);
            this.LBMV1PVP.Name = "LBMV1PVP";
            this.LBMV1PVP.Size = new System.Drawing.Size(99, 17);
            this.LBMV1PVP.TabIndex = 16;
            this.LBMV1PVP.Text = "PVP Enabled: ";
            // 
            // LBMV1WhiteList
            // 
            this.LBMV1WhiteList.AutoSize = true;
            this.LBMV1WhiteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1WhiteList.Location = new System.Drawing.Point(8, 239);
            this.LBMV1WhiteList.Name = "LBMV1WhiteList";
            this.LBMV1WhiteList.Size = new System.Drawing.Size(134, 17);
            this.LBMV1WhiteList.TabIndex = 15;
            this.LBMV1WhiteList.Text = "White List Enabled: ";
            // 
            // LBMV1LevelType
            // 
            this.LBMV1LevelType.AutoSize = true;
            this.LBMV1LevelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1LevelType.Location = new System.Drawing.Point(330, 217);
            this.LBMV1LevelType.Name = "LBMV1LevelType";
            this.LBMV1LevelType.Size = new System.Drawing.Size(86, 17);
            this.LBMV1LevelType.TabIndex = 14;
            this.LBMV1LevelType.Text = "Level Type: ";
            // 
            // LBMV1ServerDifficulty
            // 
            this.LBMV1ServerDifficulty.AutoSize = true;
            this.LBMV1ServerDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1ServerDifficulty.Location = new System.Drawing.Point(184, 217);
            this.LBMV1ServerDifficulty.Name = "LBMV1ServerDifficulty";
            this.LBMV1ServerDifficulty.Size = new System.Drawing.Size(69, 17);
            this.LBMV1ServerDifficulty.TabIndex = 13;
            this.LBMV1ServerDifficulty.Text = "Difficulty: ";
            // 
            // LBMV1ServerGamemode
            // 
            this.LBMV1ServerGamemode.AutoSize = true;
            this.LBMV1ServerGamemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1ServerGamemode.Location = new System.Drawing.Point(8, 217);
            this.LBMV1ServerGamemode.Name = "LBMV1ServerGamemode";
            this.LBMV1ServerGamemode.Size = new System.Drawing.Size(89, 17);
            this.LBMV1ServerGamemode.TabIndex = 12;
            this.LBMV1ServerGamemode.Text = "Gamemode: ";
            // 
            // BTMV1Stop
            // 
            this.BTMV1Stop.Enabled = false;
            this.BTMV1Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMV1Stop.Location = new System.Drawing.Point(397, 114);
            this.BTMV1Stop.Name = "BTMV1Stop";
            this.BTMV1Stop.Size = new System.Drawing.Size(95, 53);
            this.BTMV1Stop.TabIndex = 10;
            this.BTMV1Stop.Text = "Stop Server";
            this.BTMV1Stop.UseVisualStyleBackColor = true;
            this.BTMV1Stop.Click += new System.EventHandler(this.MV1StopClick);
            // 
            // BTMV1Start
            // 
            this.BTMV1Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMV1Start.Location = new System.Drawing.Point(397, 42);
            this.BTMV1Start.Name = "BTMV1Start";
            this.BTMV1Start.Size = new System.Drawing.Size(95, 53);
            this.BTMV1Start.TabIndex = 9;
            this.BTMV1Start.Text = "Start Server";
            this.BTMV1Start.UseVisualStyleBackColor = true;
            this.BTMV1Start.Click += new System.EventHandler(this.MV1StartClick);
            // 
            // LBMV1ServerLastRan
            // 
            this.LBMV1ServerLastRan.AutoSize = true;
            this.LBMV1ServerLastRan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1ServerLastRan.Location = new System.Drawing.Point(140, 150);
            this.LBMV1ServerLastRan.Name = "LBMV1ServerLastRan";
            this.LBMV1ServerLastRan.Size = new System.Drawing.Size(119, 17);
            this.LBMV1ServerLastRan.TabIndex = 8;
            this.LBMV1ServerLastRan.Text = "Server Last Ran: ";
            // 
            // LBMV1ServerStatus
            // 
            this.LBMV1ServerStatus.AutoSize = true;
            this.LBMV1ServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1ServerStatus.Location = new System.Drawing.Point(140, 114);
            this.LBMV1ServerStatus.Name = "LBMV1ServerStatus";
            this.LBMV1ServerStatus.Size = new System.Drawing.Size(102, 17);
            this.LBMV1ServerStatus.TabIndex = 7;
            this.LBMV1ServerStatus.Text = "Server Status: ";
            // 
            // LBMV1ServerIP
            // 
            this.LBMV1ServerIP.AutoSize = true;
            this.LBMV1ServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1ServerIP.Location = new System.Drawing.Point(140, 78);
            this.LBMV1ServerIP.Name = "LBMV1ServerIP";
            this.LBMV1ServerIP.Size = new System.Drawing.Size(74, 17);
            this.LBMV1ServerIP.TabIndex = 6;
            this.LBMV1ServerIP.Text = "Server IP: ";
            // 
            // LBMV1ServerName
            // 
            this.LBMV1ServerName.AutoSize = true;
            this.LBMV1ServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1ServerName.Location = new System.Drawing.Point(140, 42);
            this.LBMV1ServerName.Name = "LBMV1ServerName";
            this.LBMV1ServerName.Size = new System.Drawing.Size(99, 17);
            this.LBMV1ServerName.TabIndex = 5;
            this.LBMV1ServerName.Text = "Server Name: ";
            // 
            // PBMV1Icon
            // 
            this.PBMV1Icon.Image = ((System.Drawing.Image)(resources.GetObject("PBMV1Icon.Image")));
            this.PBMV1Icon.Location = new System.Drawing.Point(8, 42);
            this.PBMV1Icon.Name = "PBMV1Icon";
            this.PBMV1Icon.Size = new System.Drawing.Size(125, 125);
            this.PBMV1Icon.TabIndex = 4;
            this.PBMV1Icon.TabStop = false;
            // 
            // BTMV1AutoSync
            // 
            this.BTMV1AutoSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMV1AutoSync.Location = new System.Drawing.Point(360, 5);
            this.BTMV1AutoSync.Name = "BTMV1AutoSync";
            this.BTMV1AutoSync.Size = new System.Drawing.Size(132, 25);
            this.BTMV1AutoSync.TabIndex = 3;
            this.BTMV1AutoSync.Text = "Stop Auto Sync";
            this.BTMV1AutoSync.UseVisualStyleBackColor = true;
            this.BTMV1AutoSync.Click += new System.EventHandler(this.MV1ASClick);
            // 
            // BTMV1Check
            // 
            this.BTMV1Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMV1Check.Location = new System.Drawing.Point(224, 5);
            this.BTMV1Check.Name = "BTMV1Check";
            this.BTMV1Check.Size = new System.Drawing.Size(130, 25);
            this.BTMV1Check.TabIndex = 2;
            this.BTMV1Check.Text = "Check For Update";
            this.BTMV1Check.UseVisualStyleBackColor = true;
            this.BTMV1Check.Click += new System.EventHandler(this.MV1CFUClick);
            // 
            // BTMV1Sync
            // 
            this.BTMV1Sync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMV1Sync.Location = new System.Drawing.Point(143, 5);
            this.BTMV1Sync.Name = "BTMV1Sync";
            this.BTMV1Sync.Size = new System.Drawing.Size(75, 25);
            this.BTMV1Sync.TabIndex = 1;
            this.BTMV1Sync.Text = "Sync";
            this.BTMV1Sync.UseVisualStyleBackColor = true;
            this.BTMV1Sync.Click += new System.EventHandler(this.MV1SyncClick);
            // 
            // LBMV1SyncStatus
            // 
            this.LBMV1SyncStatus.AutoSize = true;
            this.LBMV1SyncStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV1SyncStatus.Location = new System.Drawing.Point(8, 8);
            this.LBMV1SyncStatus.Name = "LBMV1SyncStatus";
            this.LBMV1SyncStatus.Size = new System.Drawing.Size(56, 17);
            this.LBMV1SyncStatus.TabIndex = 0;
            this.LBMV1SyncStatus.Text = "Status: ";
            // 
            // TPMinecraftV2
            // 
            this.TPMinecraftV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPMinecraftV2.Location = new System.Drawing.Point(4, 22);
            this.TPMinecraftV2.Name = "TPMinecraftV2";
            this.TPMinecraftV2.Padding = new System.Windows.Forms.Padding(3);
            this.TPMinecraftV2.Size = new System.Drawing.Size(496, 455);
            this.TPMinecraftV2.TabIndex = 1;
            this.TPMinecraftV2.Text = "Minecraft 1.12.2";
            this.TPMinecraftV2.UseVisualStyleBackColor = true;
            // 
            // TPLog
            // 
            this.TPLog.Controls.Add(this.RTBLog);
            this.TPLog.Location = new System.Drawing.Point(4, 22);
            this.TPLog.Name = "TPLog";
            this.TPLog.Size = new System.Drawing.Size(496, 455);
            this.TPLog.TabIndex = 2;
            this.TPLog.Text = "Log";
            this.TPLog.UseVisualStyleBackColor = true;
            // 
            // RTBLog
            // 
            this.RTBLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBLog.Location = new System.Drawing.Point(0, 0);
            this.RTBLog.Name = "RTBLog";
            this.RTBLog.Size = new System.Drawing.Size(496, 455);
            this.RTBLog.TabIndex = 0;
            this.RTBLog.Text = "";
            this.RTBLog.WordWrap = false;
            // 
            // TPServerLog
            // 
            this.TPServerLog.Controls.Add(this.BTSubmitCommand);
            this.TPServerLog.Controls.Add(this.TBCommand);
            this.TPServerLog.Controls.Add(this.TBServerConsole);
            this.TPServerLog.Location = new System.Drawing.Point(4, 22);
            this.TPServerLog.Name = "TPServerLog";
            this.TPServerLog.Size = new System.Drawing.Size(496, 455);
            this.TPServerLog.TabIndex = 3;
            this.TPServerLog.Text = "Server Log";
            this.TPServerLog.UseVisualStyleBackColor = true;
            // 
            // BTSubmitCommand
            // 
            this.BTSubmitCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSubmitCommand.Location = new System.Drawing.Point(367, 3);
            this.BTSubmitCommand.Name = "BTSubmitCommand";
            this.BTSubmitCommand.Size = new System.Drawing.Size(126, 25);
            this.BTSubmitCommand.TabIndex = 2;
            this.BTSubmitCommand.Text = "Submit Command";
            this.BTSubmitCommand.UseVisualStyleBackColor = true;
            this.BTSubmitCommand.Click += new System.EventHandler(this.SCClicked);
            // 
            // TBCommand
            // 
            this.TBCommand.Location = new System.Drawing.Point(3, 6);
            this.TBCommand.Name = "TBCommand";
            this.TBCommand.Size = new System.Drawing.Size(358, 20);
            this.TBCommand.TabIndex = 1;
            // 
            // TBServerConsole
            // 
            this.TBServerConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBServerConsole.Location = new System.Drawing.Point(0, 33);
            this.TBServerConsole.Multiline = true;
            this.TBServerConsole.Name = "TBServerConsole";
            this.TBServerConsole.ReadOnly = true;
            this.TBServerConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBServerConsole.Size = new System.Drawing.Size(496, 423);
            this.TBServerConsole.TabIndex = 0;
            // 
            // TPChangeLog
            // 
            this.TPChangeLog.Controls.Add(this.RTBChangeLog);
            this.TPChangeLog.Location = new System.Drawing.Point(4, 22);
            this.TPChangeLog.Name = "TPChangeLog";
            this.TPChangeLog.Size = new System.Drawing.Size(496, 455);
            this.TPChangeLog.TabIndex = 4;
            this.TPChangeLog.Text = "Change Log";
            this.TPChangeLog.UseVisualStyleBackColor = true;
            // 
            // RTBChangeLog
            // 
            this.RTBChangeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBChangeLog.Location = new System.Drawing.Point(0, 0);
            this.RTBChangeLog.Name = "RTBChangeLog";
            this.RTBChangeLog.ReadOnly = true;
            this.RTBChangeLog.Size = new System.Drawing.Size(496, 455);
            this.RTBChangeLog.TabIndex = 0;
            this.RTBChangeLog.Text = resources.GetString("RTBChangeLog.Text");
            // 
            // TMMV1Sync
            // 
            this.TMMV1Sync.Interval = 300000;
            this.TMMV1Sync.Tick += new System.EventHandler(this.MV1SyncTimePassed);
            // 
            // TMMV1Status
            // 
            this.TMMV1Status.Tick += new System.EventHandler(this.MV1StatusTimePassed);
            // 
            // TMRetry
            // 
            this.TMRetry.Interval = 30000;
            this.TMRetry.Tick += new System.EventHandler(this.RetryTimePassed);
            // 
            // Sync_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.TCMenuTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sync_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.Sync_Menu_Load);
            this.TCMenuTabs.ResumeLayout(false);
            this.TPMinecraftV1.ResumeLayout(false);
            this.TPMinecraftV1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMV1Icon)).EndInit();
            this.TPLog.ResumeLayout(false);
            this.TPServerLog.ResumeLayout(false);
            this.TPServerLog.PerformLayout();
            this.TPChangeLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCMenuTabs;
        private System.Windows.Forms.TabPage TPMinecraftV1;
        private System.Windows.Forms.TabPage TPMinecraftV2;
        private System.Windows.Forms.TabPage TPLog;
        private System.Windows.Forms.Button BTMV1AutoSync;
        private System.Windows.Forms.Button BTMV1Check;
        private System.Windows.Forms.Button BTMV1Sync;
        private System.Windows.Forms.Label LBMV1SyncStatus;
        private System.Windows.Forms.PictureBox PBMV1Icon;
        private System.Windows.Forms.Button BTMV1Stop;
        private System.Windows.Forms.Button BTMV1Start;
        private System.Windows.Forms.Label LBMV1ServerLastRan;
        private System.Windows.Forms.Label LBMV1ServerStatus;
        private System.Windows.Forms.Label LBMV1ServerIP;
        private System.Windows.Forms.Label LBMV1ServerName;
        private System.Windows.Forms.Label LBMV1ServerDifficulty;
        private System.Windows.Forms.Label LBMV1ServerGamemode;
        private System.Windows.Forms.Label LBMV1LevelType;
        private System.Windows.Forms.Label LBMV1MaxPlayers;
        private System.Windows.Forms.Label LBMV1PVP;
        private System.Windows.Forms.Label LBMV1WhiteList;
        private System.Windows.Forms.Label LBMV1ViewDistance;
        private System.Windows.Forms.Label LBMV1GenerateStructures;
        private System.Windows.Forms.Label LBMV1MaxBuildHeight;
        private System.Windows.Forms.RichTextBox RTBMV1ServerMOTD;
        private System.Windows.Forms.TextBox TBMV1Mods;
        private System.Windows.Forms.TextBox TBMV1Bans;
        private System.Windows.Forms.TextBox TBMV1Ops;
        private System.Windows.Forms.RichTextBox RTBLog;
        private System.Windows.Forms.TabPage TPServerLog;
        private System.Windows.Forms.Button BTSubmitCommand;
        private System.Windows.Forms.TextBox TBCommand;
        private System.Windows.Forms.TextBox TBServerConsole;
        private System.Windows.Forms.Timer TMMV1Sync;
        private System.Windows.Forms.Timer TMMV1Status;
        private System.Windows.Forms.Timer TMRetry;
        private System.Windows.Forms.TabPage TPChangeLog;
        private System.Windows.Forms.RichTextBox RTBChangeLog;
    }
}