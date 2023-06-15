// Copyright - Toby Hunter
// Namespaces used in the Class.
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Title_In_Development
{
    public partial class Sync_Menu : Form
    {
        // Global Class Objects.
        private MinecraftV1 MV1;
        Process H = new Process();
        ProcessStartInfo PSI;
        Process S;

        // Local Class Variables.
        private string Log;
        private int Counter;
        private bool MV1SyncTimer;
        private bool MV1StatusTimer;
        private bool MV1FillVariables;
        private bool FillMV1TF;
        private bool AutoSync;

        // Local get set used to change the value of the Log variable.
        public string L
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Log;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable, adds the text to the RTBLog textbox and calls the FormatLog method.
                Log = value;
                RTBLog.Text += Log;
                FormatLog();
            }
        }

        // Local get set used to change the value of the MV1SyncTimer variable.
        public bool MV1ST
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return MV1SyncTimer;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable.
                MV1SyncTimer = value;

                //Runs code if condition is met.
                if (MV1SyncTimer == true)
                {
                    // Starts the timer.
                    TMMV1Sync.Start();
                }

                // Runs code if condition is met.
                else
                {
                    // Stops the timer.
                    TMMV1Sync.Stop();
                }
            }
        }

        // Local get set used to change the value of the MV1StatusTimer variable.
        public bool MV1SST
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return MV1StatusTimer;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable.
                MV1StatusTimer = value;

                //Runs code if condition is met.
                if (MV1StatusTimer == true)
                {
                    // Changes the LBMV1SyncStatus text and starts the timer.
                    LBMV1SyncStatus.Text += MV1.LBSS;
                    TMMV1Status.Start();
                }

                // Runs code if condition is met.
                else
                {
                    // Stops the timer and resets the LBMV1SyncStatus text.
                    TMMV1Status.Stop();
                    LBMV1SyncStatus.Text = "Status: " + MV1.LBSS;
                }
            }
        }

        // Local get set used to change the value of the FillMV1TF variable.
        public bool FMV1
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return FillMV1TF;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the FillMV1 method.
                FillMV1TF = value;
                FillMV1();
            }
        }

        // Local get set used to change the value of the MV1FillVariables variable.
        public bool MV1FV
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return MV1FillVariables;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable, calls the FV get Set and sets it to true.
                MV1FillVariables = value;
                MV1.FV = true;
            }
        }

        // Runs code when program is started.
        public Sync_Menu()
        {
            InitializeComponent();

            // Passes the methods of the current form to the MV1 class.
            MV1 = new MinecraftV1(this);

            // Passes the methods of the ProcessStartInfo class with the given information.
            PSI = new ProcessStartInfo
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Passes the methods of the Process class with the start info of the given information.
            S = new Process { StartInfo = PSI };
            S.OutputDataReceived += OutputDataReceived;
        }

        // Runs code when the form loads.
        private async void Design(object sender, PaintEventArgs e)
        {
            // Gives g all the properties of the e.graphics class.
            Graphics g = e.Graphics;

            // Gives pen all the properties of the Pen class.
            Pen pen = new Pen(Color.Black, 2);

            // Draws a line with the given information.
            g.DrawLine(pen, 0, 35, 496, 35);
        }

        // Runs code when the form loads.
        private void Sync_Menu_Load(object sender, EventArgs e)
        {
            // Hides the TPServerLog tab.
            TCMenuTabs.TabPages.Remove(TPServerLog);
            TCMenuTabs.TabPages.Remove(TPMinecraftV2);

            // Calls the UC get set, sets it to true, changes the value of the AutoSync variable to the given value, starts the timer and passes a string to the L get set. 
            L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Automatic Sync Check has been started, checking for updates will be triggered every 5 minutes.";
            MV1.UC = true;
            AutoSync = true;
            TMMV1Sync.Start();
        }

        // Runs code when the method is called.
        private async void FillMV1()
        {
            // Runs code even if error may occur.
            try
            {
                // Passes a string to the L get set.
                L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Fill Variables triggered for the Minecraft 1.7.10 tab.";

                // Enables the buttons.
                BTMV1Check.Enabled = true;
                BTMV1Sync.Enabled = true;
                BTMV1Start.Enabled = true;

                // Fills out the menus containers with the given information.
                PBMV1Icon.Image = new Bitmap(".\\Data\\1.7.10 Forge Logo.jpeg");
                LBMV1ServerName.Text = "Server Name: " + MV1.SN;
                LBMV1ServerIP.Text = "Server IP: " + MV1.IPAddress;
                LBMV1ServerStatus.Text = "Server Status: " + MV1.SS;
                LBMV1ServerLastRan.Text = "Server Last Ran: " + MV1.LR;
                RTBMV1ServerMOTD.Text = "MOTD: " + MV1.MinecraftMOTD;
                LBMV1ServerGamemode.Text = "Gamemode: " + MV1.GM;
                LBMV1ServerDifficulty.Text = "Difficulty: " + MV1.D;
                LBMV1LevelType.Text = "Level Type: " + MV1.LT;
                LBMV1WhiteList.Text = "White List Enabled: " + MV1.WL;
                LBMV1PVP.Text = "PVP Enabled: " + MV1.PVPEnabled;
                LBMV1MaxPlayers.Text = "Max Players: " + MV1.MP;
                LBMV1MaxBuildHeight.Text = "Build Limit: " + MV1.BL;
                LBMV1GenerateStructures.Text = "Generate Structures: " + MV1.GS;
                LBMV1ViewDistance.Text = "View Distance: " + MV1.VD;
                TBMV1Ops.Text = "Ops:" + MV1.OppedPlayers;
                TBMV1Bans.Text = "Bans:" + MV1.BannedPlayers;
                TBMV1Mods.Text = "Mods:" + MV1.ServerMods;

                // Formats the MOTD to as it would appear in Minecraft.
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\n", Environment.NewLine);
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A73", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A7a", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A74", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A7r", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A75", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A76", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A7d", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A7e", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A70", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A77", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A78", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A7b", "");
                RTBMV1ServerMOTD.Text = RTBMV1ServerMOTD.Text.Replace("\\u00A7f", "");

                // Sets the TargetString variable to the given value and sets the StartIndex variable to the location of the TargetString variable.
                string TargetString = "Title is in Development";
                int StartIndex = RTBMV1ServerMOTD.Text.IndexOf(TargetString);

                // Runs code if condition is met.
                if (StartIndex >= 0)
                {
                    // Selects the string and changes its colour.
                    RTBMV1ServerMOTD.Select(StartIndex, TargetString.Length);
                    RTBMV1ServerMOTD.SelectionColor = Color.FromArgb(0, 170, 170);
                }

                // Sets the TargetString variable to the given value and sets the StartIndex variable to the location of the TargetString variable.
                TargetString = "[Survival]";
                StartIndex = RTBMV1ServerMOTD.Text.IndexOf(TargetString);

                // Runs code if condition is met.
                if (StartIndex >= 0)
                {
                    // Selects the string and changes its colour.
                    RTBMV1ServerMOTD.Select(StartIndex, TargetString.Length);
                    RTBMV1ServerMOTD.SelectionColor = Color.FromArgb(85, 255, 85);
                }

                // Sets the TargetString variable to the given value and sets the StartIndex variable to the location of the TargetString variable.
                TargetString = "Hard Mode";
                StartIndex = RTBMV1ServerMOTD.Text.IndexOf(TargetString);

                // Runs code if condition is met.
                if (StartIndex >= 0)
                {
                    // Selects the string and changes its colour.
                    RTBMV1ServerMOTD.Select(StartIndex, TargetString.Length);
                    RTBMV1ServerMOTD.SelectionColor = Color.FromArgb(170, 0, 0);
                }

                // Sets the TargetString variable to the given value and sets the StartIndex variable to the location of the TargetString variable.
                TargetString = "GalactiCraft";
                StartIndex = RTBMV1ServerMOTD.Text.IndexOf(TargetString);

                // Runs code if condition is met.
                if (StartIndex >= 0)
                {
                    // Selects the string and changes its colour.
                    RTBMV1ServerMOTD.Select(StartIndex, TargetString.Length);
                    RTBMV1ServerMOTD.SelectionColor = Color.FromArgb(170, 0, 170);
                }

                // Sets the TargetString variable to the given value and sets the StartIndex variable to the location of the TargetString variable.
                TargetString = "Mekanism";
                StartIndex = RTBMV1ServerMOTD.Text.IndexOf(TargetString);

                // Runs code if condition is met.
                if (StartIndex >= 0)
                {
                    // Selects the string and changes its colour.
                    RTBMV1ServerMOTD.Select(StartIndex, TargetString.Length);
                    RTBMV1ServerMOTD.SelectionColor = Color.FromArgb(255, 170, 0);
                }

                // Sets the TargetString variable to the given value and sets the StartIndex variable to the location of the TargetString variable.
                TargetString = "The Twilight Forest";
                StartIndex = RTBMV1ServerMOTD.Text.IndexOf(TargetString);

                // Runs code if condition is met.
                if (StartIndex >= 0)
                {
                    // Selects the string and changes its colour.
                    RTBMV1ServerMOTD.Select(StartIndex, TargetString.Length);
                    RTBMV1ServerMOTD.SelectionColor = Color.FromArgb(255, 85, 255);
                }

                // Sets the TargetString variable to the given value and sets the StartIndex variable to the location of the TargetString variable.
                TargetString = "1.7.10";
                StartIndex = RTBMV1ServerMOTD.Text.IndexOf(TargetString);

                // Runs code if condition is met.
                if (StartIndex >= 0)
                {
                    // Selects the string and changes its colour.
                    RTBMV1ServerMOTD.Select(StartIndex, TargetString.Length);
                    RTBMV1ServerMOTD.SelectionColor = Color.FromArgb(255, 255, 85);
                }

                // Runs code if condition is met.
                if (MV1.SS == "Running")
                {
                    // Disables the button.
                    BTMV1Start.Enabled = false;
                }

                // Runs code if condition is met.
                else if (MV1.SS == "Open")
                {
                    // Disables the buttons.
                    BTMV1Start.Enabled = false;
                    BTMV1Stop.Enabled = false;
                }

                // Runs code if condition is met.
                else
                {
                    // Disables the button.
                    BTMV1Stop.Enabled = false;
                }

                // Changes the value of the FillMV1TF variable to the given value.
                FillMV1TF = false;
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\FillMV1_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to fill out the form for the Minecraft 1.7.10 tab:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file and passes a string to the L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to fill out the form for the Minecraft 1.7.10 tab, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file and passes a string to the L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to fill out the form for the Minecraft 1.7.10 tab, see error log for details.";
                }
            }
        }

        // Runs code if button is clicked.
        private async void MV1StartClick(object sender, EventArgs e)
        {
            // Passes a string to the L get set, disables the button, enables the stop button, changes the LBServerStatus value, calls the SS get set, sets it to the given string and shows the TPServerLog tab.
            L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Starting Minecraft 1.7.10 Server and required applications.";
            BTMV1Start.Enabled = false;
            BTMV1Sync.Enabled = false;
            BTMV1Stop.Enabled = true;
            LBMV1ServerStatus.Text = "Server Status: Running";
            MV1.SS = "Running";
            TCMenuTabs.TabPages.Insert(TCMenuTabs.TabPages.Count, TPServerLog);

            // Runs code if condition is met.
            if (MV1.H == "")
            {
                // Passes a string to the L get set.
                L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Hamachi exe location unknown.";
            
                // Sets the parameters for the directory search.
                string SearchDirectoryC = "C:\\";
                string SearchDirectoryD = "D:\\";

                // Passes a string to the L get set and calls the SD get set.
                L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Searching for Hamachi exe in " + SearchDirectoryC + ".";
                L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Searching for Hamachi exe in " + SearchDirectoryD + ".";
                MV1.SD = SearchDirectoryC;
                MV1.SD = SearchDirectoryD;
           
                // Runs code if condition is met.
                if (MV1.H == "")
                {
                    // Passes a string to the L get set.
                    L = Environment.NewLine + DateTime.Now.ToString() + " - Error - Hamachi exe. location not found in " + SearchDirectoryC + " or " + SearchDirectoryD + ".";
                }
            
                // Runs code if condition is met.
                else if (MV1.H.Contains(SearchDirectoryC) == true)
                {
                    // Passes a string to the L get set.
                    L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Hamachi exe. location not found in " + SearchDirectoryD + ".";
                }
            
                // Runs code if condition is met.
                else
                {
                    // Passes a string to the L get set.
                    L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Hamachi exe. location not found in " + SearchDirectoryC + ".";
                }
            
                // Starts Hamachi and the server bat file.
                H.StartInfo.FileName = MV1.H;
                H.Start();
                S.StartInfo.FileName = MV1.SB;
                S.StartInfo.WorkingDirectory = MV1.SL;
                S.Start();
                S.BeginOutputReadLine();
            }

                // Runs code if condition is met.
            else
            {
                // Starts Hamachi and the server bat file.
                H.StartInfo.FileName = MV1.H;
                H.Start();
                S.StartInfo.FileName = MV1.SB;
                S.StartInfo.WorkingDirectory = MV1.SL;
                S.Start();
                S.BeginOutputReadLine();
            }
        }

        // Runs code if button is clicked.
        private async void MV1StopClick(object sender, EventArgs e)
        {
            // Passes a string to the L get set, enables the button, disables the stop button, changes the LBServerStatus value, calls the SS get set, sets it to the given string and hides the TPServerLog tab.
            L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Stopping Minecraft 1.7.10 Server and required applications.";
            BTMV1Start.Enabled = true;
            BTMV1Sync.Enabled = true;
            BTMV1Stop.Enabled = false;
            LBMV1ServerStatus.Text = "Server Status: Stopped";
            MV1.SS = "Stopped";
            TCMenuTabs.TabPages.Remove(TPServerLog);

            // Stops the server and closes Hamachi.
            S.StandardInput.WriteLine("stop");
            S.StandardInput.Flush();
            H.Kill();
        }

        // Runs code if button is clicked.
        private async void MV1SyncClick(object sender, EventArgs e)
        {
            // Disables the button, displays a message to the user.
            BTMV1Sync.Enabled = false;
            BTMV1Check.Enabled = false;
            BTMV1Start.Enabled = false;
            var Result = MessageBox.Show("You are about to start a manual upload. This will force an update and will not do any checks before hand. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Runs code if condition met.
            if (Result == DialogResult.Yes)
            {
                // Passes the given value to the LBSS get set, passes the given value to the UU get set and starts the timer.
                MV1.LBSS = "Syncing  ";
                MV1ST = true;
                MV1.UU = true;
                TMMV1Status.Start();
            }

            // Runs code if condition met.
            else
            {
                // Enables the button.
                BTMV1Sync.Enabled = true;
                BTMV1Check.Enabled = true;
                BTMV1Start.Enabled = true;
            }
        }

        // Runs code if button is clicked.
        private async void MV1CFUClick(object sender, EventArgs e)
        {
            // Passes the given value to the UU get set and disables the button.
            MV1.UC = true;
            BTMV1Check.Enabled = false;
            BTMV1Sync.Enabled = false;
        }

        // Runs code if button is clicked.
        private async void MV1ASClick(object sender, EventArgs e)
        {
            // Runs code if condition met.
            if (AutoSync == true)
            {
                // Changes the text on the button, stops the timer, changes the value of the AutoSync variable and passes a string to the L get set.
                L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Automatic Sync Check has been stopped, checking will need to be triggered manually.";
                BTMV1AutoSync.Text = "Start Auto Sync";
                AutoSync = false;
                TMMV1Sync.Stop();
            }

            // Runs code if condition met.
            else
            {
                // Changes the text on the button, start the timer, changes the value of the AutoSync variable and passes a string to the L get set.
                L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Automatic Sync Check has been started, checking for updates will be triggered every 5 minutes.";
                BTMV1AutoSync.Text = "Stop Auto Sync";
                AutoSync = true;
                TMMV1Sync.Start();
            }
        }

        // Runs code if button is clicked.
        private async void SCClicked(object sender, EventArgs e)
        {
            // Passes the command to the server.
            S.StandardInput.WriteLine(TBCommand.Text);
            S.StandardInput.Flush();
        }

        

        // Runs code when the program closes.
        private void Exit(object sender, FormClosingEventArgs e)
        {
            // Passes the given string to the L get set.
            L = Environment.NewLine + DateTime.Now.ToString() + " - Info - " + "Logging Stopped";

            // Closes the pogram fully.
            // Creates a file path and name for the error log and creates the error message.
            string SyncLog = @".\Logs\Sync Logs\Main Log." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

            // Runs code if condition is met.
            if (File.Exists(SyncLog) == true)
            {
                // Writes the Log variable to the log file and closes the pogram fully.
                File.WriteAllText(SyncLog, File.ReadAllText(SyncLog) + Environment.NewLine + RTBLog.Text);
                Application.Exit();
            }

            // Runs code if condition is met.
            else
            {
                // Creates the file, writes the contents of the RTBLog textbox to the log file and closes the pogram fully.
                File.Create(SyncLog).Dispose();
                File.WriteAllText(SyncLog, RTBLog.Text);
                Application.Exit();
            }
        }

        // Runs code when the text is changed.
        private async void FormatLog()
        {
            // Runs code for every line in the textbox.
            for (int x = 0; x < RTBLog.Lines.Length; x++)
            {
                // Check if the line contains the search string
                if (RTBLog.Lines[x].ToString().Contains("- Error -") == true)
                {
                    // Get the start and end positions of the line
                    int lineStart = RTBLog.GetFirstCharIndexFromLine(x);

                    // Change the color of the line
                    RTBLog.Select(lineStart, RTBLog.Lines[x].Length);
                    RTBLog.SelectionBackColor = Color.FromArgb(255, 128, 128);
                }

                // Check if the line contains the search string
                else if (RTBLog.Lines[x].ToString().Contains("- Info -") == true)
                {
                    // Get the start and end positions of the line
                    int lineStart = RTBLog.GetFirstCharIndexFromLine(x);

                    // Change the color of the line
                    RTBLog.Select(lineStart, RTBLog.Lines[x].Length);
                    RTBLog.SelectionBackColor = Color.FromArgb(128, 255, 128);
                }

                // Check if the line contains the search string
                else if (RTBLog.Lines[x].ToString().Contains("- Warn -") == true)
                {
                    // Get the start and end positions of the line
                    int lineStart = RTBLog.GetFirstCharIndexFromLine(x);

                    // Change the color of the line
                    RTBLog.Select(lineStart, RTBLog.Lines[x].Length);
                    RTBLog.SelectionBackColor = Color.FromArgb(255, 181, 106);
                }

                // Check if the line contains the search string
                else if (RTBLog.Lines[x].ToString().Contains("- Debug -") == true)
                {
                    // Get the start and end positions of the line
                    int lineStart = RTBLog.GetFirstCharIndexFromLine(x);

                    // Change the color of the line
                    RTBLog.Select(lineStart, RTBLog.Lines[x].Length);
                    RTBLog.SelectionBackColor = Color.FromArgb(255, 255, 128);
                }
            }

            //RTBLog.SelectionStart = RTBLog.Text.Length;
            //RTBLog.ScrollToCaret();
        }

        // Runs code when the method is called.
        private async void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            // Runs code if condition is met.
            if (string.IsNullOrEmpty(e.Data) == false)
            {
                // Adds the console output to the TBServerConsole textbox and scrolls it to the last line of the textbox.
                TBServerConsole.Invoke((MethodInvoker)delegate {
                    TBServerConsole.Text += e.Data + Environment.NewLine;
                    TBServerConsole.SelectionStart = TBServerConsole.Text.Length;
                    TBServerConsole.ScrollToCaret();
                });
            }
        }

        // Runs code when the time has passed.
        private async void MV1SyncTimePassed(object sender, EventArgs e)
        {
            // Passes a string to the L get set and passes the given value to the UD get set.
            L = Environment.NewLine + DateTime.Now.ToString() + " - Info - MV1SyncTimePassed triggered.";
            MV1.UC = true;

            // Enables the button.
            BTMV1Check.Enabled = false;
            BTMV1Sync.Enabled = false;
        }

        // Runs code when the time has passed.
        private async void MV1StatusTimePassed(object sender, EventArgs e)
        {
            // Changes the LBMV1SyncStatus text, gives Builder all the properties of the StringBuilder class with the given information and increases the value of Counter by 1.
            LBMV1SyncStatus.Text = "Status: " + MV1.LBSS;
            StringBuilder Builder = new StringBuilder(LBMV1SyncStatus.Text);
            Counter++;

            // Divides Counter by 4 and runs the code.
            switch (Counter % 4)
            {
                // Changes the last letter of the LBMV1SyncStatus label.
                case 0: Builder[Builder.Length - 1] = Convert.ToChar("/"); LBMV1SyncStatus.Text = Builder.ToString(); break;
                case 1: Builder[Builder.Length - 1] = Convert.ToChar("-"); LBMV1SyncStatus.Text = Builder.ToString(); break;
                case 2: Builder[Builder.Length - 1] = Convert.ToChar("\\"); LBMV1SyncStatus.Text = Builder.ToString(); break;
                case 3: Builder[Builder.Length - 1] = Convert.ToChar("|"); LBMV1SyncStatus.Text = Builder.ToString(); break;

            }
        }
    }
}
