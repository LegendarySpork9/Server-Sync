// Copyright - Toby Hunter
// Namespaces used in the Class.
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Reflection;

namespace Title_In_Development
{
    public partial class Load_Screen : Form
    {
        // Global Class Objects.
        Rectangle LeftBar = new Rectangle(259, 0, 2, 24);
        Rectangle RightBar = new Rectangle(259, 0, 2, 24);
        Rectangle LoadingBar = new Rectangle(18, 0, 2, 24);
        StringFormat Format = new StringFormat();
        Sync_Menu SM = new Sync_Menu();

        // Local Class Variables.
        private int Stage = 0;
        private int CurrentCharacter = 0;
        private bool InternetConnected = false;
        private string[] Servers = { };
        private int x = 0;
        private int Alpha = 255;
        private int Step = 10;
        private bool IsTransparent = false;

        // Runs code when program is started.
        public Load_Screen()
        {
            InitializeComponent();

            // Starts the timer.
            TMWait.Start();

            // Runs the InternetConnection Method
            InternetConnection();

            // Sets the alliagnment of a string using this format to the center of its container.
            Format.Alignment = StringAlignment.Center;

            // Passes the given string to the SM.L get set.
            SM.L = DateTime.Now.ToString() + " - Info - " + "Logging Started";
            SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - " + "Running Version: " + Assembly.GetEntryAssembly().GetName().Version;
        }

        // Runs code when the form loads.
        private async void Load_Screen_Load(object sender, EventArgs e)
        {
            // Directs the mouse to edit a hidden label.
            LBIgnore.Select();

            // Hides the Loading Graphic panel and hides the Loading Graphic label.
            PLoadingGraphic.Hide();
            LBLoadingGraphic.Hide();
        }

        // Runs code when TBStartDebug is clicked.
        private void Click(object sender, EventArgs e)
        {
            // Directs the mouse to edit a hidden label.
            LBIgnore.Select();
        }

        // Runs code when time has elapsed.
        private void Wait(object sender, EventArgs e)
        {
            // Runs code if condition is met.
            if (Stage == 0)
            {
                // Runs code if condition is met.
                if (InternetConnected == true)
                {
                    // Sets the varable to the defined string.
                    string StartDebug = "Internet Connection = true";

                    // Runs code if condition is met.
                    if (CurrentCharacter >= StartDebug.Length)
                    {
                        // Changes the timer interval, adds a new line to the textbox, increases the Stage variable, resets the CurrentCharacter variable, starts the timer
                        // and passes StartDebug to the SM.L get set.
                        TMWait.Interval = 175;
                        TBStartDebug.Text += Environment.NewLine;
                        Stage += 1;
                        CurrentCharacter = 0;
                        TMWait.Start();
                        SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - " + StartDebug;
                    }

                    // Runs code if condition is met.
                    else if (CurrentCharacter < StartDebug.Length)
                    {
                        // Changes the timer interval, adds the current character in StartDebug to the textbox, increases the current character, starts the timer.
                        TMWait.Interval = 50;
                        TBStartDebug.Text += StartDebug[CurrentCharacter].ToString();
                        CurrentCharacter += 1;
                        TMWait.Start();
                    }
                }

                // Runs code if condition is met.
                else
                {
                    // Sets the varable to the defined string and passes it to the SM.L get set.
                    string StartDebug = "Internet Connection = false";

                    // Runs code if condition is met.
                    if (CurrentCharacter >= StartDebug.Length)
                    {
                        // Changes the timer interval, adds a new line to the textbox, increases the Stage variable, resets the CurrentCharacter variable, starts the timer
                        // and passes StartDebug to the SM.L get set.
                        TMWait.Interval = 175;
                        TBStartDebug.Text += Environment.NewLine;
                        Stage += 1;
                        CurrentCharacter = 0;
                        TMWait.Start();
                        SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - " + StartDebug;
                    }

                    // Runs code if condition is met.
                    else if (CurrentCharacter < StartDebug.Length)
                    {
                        // Changes the timer interval, adds the current character in StartDebug to the textbox, increases the current character, starts the timer.
                        TMWait.Interval = 50;
                        TBStartDebug.Text += StartDebug[CurrentCharacter].ToString();
                        CurrentCharacter += 1;
                        TMWait.Start();
                    }
                }
            }

            // Runs code if condition is met.
            else if (Stage == 1)
            {
                // Sets the varable to the defined string and passes it to the SM.L get set.
                string StartDebug = "Looking for Servers";

                // Runs code if condition is met.
                if (CurrentCharacter >= StartDebug.Length)
                {
                    // Changes the timer interval, adds a new line to the textbox, increases the Stage variable, resets the CurrentCharacter variable,
                    // Runs the LookForServers Method, starts the timer and passes StartDebug to the SM.L get set.
                    TMWait.Interval = 175;
                    TBStartDebug.Text += Environment.NewLine;
                    Stage += 1;
                    CurrentCharacter = 0;
                    LookForServers();
                    TMWait.Start();
                    SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - " + StartDebug;
                }

                // Runs code if condition is met.
                else if (CurrentCharacter < StartDebug.Length)
                {
                    // Changes the timer interval, adds the current character in StartDebug to the textbox, increases the current character, starts the timer.
                    TMWait.Interval = 50;
                    TBStartDebug.Text += StartDebug[CurrentCharacter].ToString();
                    CurrentCharacter += 1;
                    TMWait.Start();
                }
            }

            // Runs code if condition is met.
            else if (Stage == 2)
            {
                // Runs code if condition is met.
                if (x == Servers.Length)
                {
                    // Runs code if condition is met.
                    if (x == 0)
                    {
                        // Sets the varable to the defined string and passes it to the SM.L get set.
                        string StartDebug = "No Servers Found";

                        // Runs code if condition is met.
                        if (CurrentCharacter >= StartDebug.Length)
                        {
                            // Changes the timer interval, adds a new line to the textbox, increases the Stage variable, resets the CurrentCharacter variable, starts the timer and passes StartDebug to the SM.L get set.
                            TMWait.Interval = 175;
                            TBStartDebug.Text += Environment.NewLine;
                            Stage += 1;
                            CurrentCharacter = 0;
                            TMWait.Start();
                            SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - " + StartDebug;
                        }

                        // Runs code if condition is met.
                        else if (CurrentCharacter < StartDebug.Length)
                        {
                            // Changes the timer interval, adds the current character in StartDebug to the textbox, increases the current character, starts the timer.
                            TMWait.Interval = 50;
                            TBStartDebug.Text += StartDebug[CurrentCharacter].ToString();
                            CurrentCharacter += 1;
                            TMWait.Start();
                        }
                    }

                    // Runs code if condition is met.
                    else
                    {
                        // Increases the Stage variable.
                        Stage += 1;
                    }
                }

                // Runs code if condition is met.
                else
                {
                    // Sets the varable to the defined string and passes it to the SM.L get set.
                    string StartDebug = "Server Found - " + Servers[x];

                    // Runs code if condition is met.
                    if (CurrentCharacter >= StartDebug.Length)
                    {
                        // Changes the timer interval, adds a new line to the textbox, increases the x variable, resets the CurrentCharacter variable,
                        // starts the timer and passes StartDebug to the SM.L get set.
                        TMWait.Interval = 175;
                        TBStartDebug.Text += Environment.NewLine;
                        x += 1;
                        CurrentCharacter = 0;
                        TMWait.Start();
                        SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - " + StartDebug;
                    }

                    // Runs code if condition is met.
                    else if (CurrentCharacter < StartDebug.Length)
                    {
                        // Changes the timer interval, adds the current character in StartDebug to the textbox, increases the current character, starts the timer.
                        TMWait.Interval = 50;
                        TBStartDebug.Text += StartDebug[CurrentCharacter].ToString();
                        CurrentCharacter += 1;
                        TMWait.Start();
                    }
                }
            }

            // Runs code if condition is met.
            else if (Stage == 3)
            {
                // Sets the varable to the defined string and passes it to the SM.L get set.
                string StartDebug = "Loading Server Sync UI";

                // Runs code if condition is met.
                if (CurrentCharacter >= StartDebug.Length)
                {
                    // Changes the timer interval, increases the Stage variable, starts the timer, passes StartDebug to the SM.L get set and passes the list of found servers to the SM.ServerArray get set.
                    TMWait.Interval = 175;
                    Stage += 1;
                    TMWait.Start();
                    SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - " + StartDebug;
                    SM.ServerArray = Servers;
                }

                // Runs code if condition is met.
                else if (CurrentCharacter < StartDebug.Length)
                {
                    // Changes the timer interval, adds the current character in StartDebug to the textbox, increases the current character, starts the timer.
                    TMWait.Interval = 50;
                    TBStartDebug.Text += StartDebug[CurrentCharacter].ToString();
                    CurrentCharacter += 1;
                    TMWait.Start();
                }
            }

            // Runs code if condition is met.
            else if (Stage == 4)
            {
                // Shows the Loading Graphic panel, stops the timer and starts a timer.
                PLoadingGraphic.Show();
                TMWait.Stop();
                TMGraphic.Start();
            }
        }

        // Runs code when the method is called.
        private void InternetConnection()
        {
            // Runs code even if error may occur.
            try
            {
                // Assigns WC all the properties within the WebClient class, opens a stream to the URL and changes the value of the InternetConnected variable.
                WebClient WC = new WebClient();
                WC.OpenRead("https://www.google.com/");
                InternetConnected = true;
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\InternetConnection_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to test the internet connection:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    InternetConnected = false;
                    SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to test the internet connection, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    InternetConnected = false;
                    SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to test the internet connection, see error log for details.";
                }
            }
        }

        // Runs code when the method is called.
        private void LookForServers()
        {
            // Runs code even if error may occur.
            try
            {
                // Assigns XML all the properties within the XmlDocument class, loads the xml of the given file and creates a list of all child nodes of the given node.
                XmlDocument XML = new XmlDocument();
                XML.Load(@".\Configuration\Server Config.config");
                XmlNodeList List = XML.SelectNodes("ServerSync/Servers/child::*");

                // Runs code for every item in the list.
                foreach (XmlNode Node in List)
                {
                    // Adds the server name to the Servers list.
                    Servers = Servers.Append(Node.Name.Replace("-", " ")).ToArray();
                }
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\LookForServers_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to look for servers in the Server Config file:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file and passes a string to the SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to look for servers in the Server Config file, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file and passes a string to the SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to look for servers in the Server Config file, see error log for details.";
                }
            }
        }

        // Runs code when the form loads.
        private void Loading_Graphic(object sender, PaintEventArgs e)
        {
            // Draws a rectangle with the given information.
            e.Graphics.FillRectangle(Brushes.White, RightBar);
            e.Graphics.FillRectangle(Brushes.White, LeftBar);

            // Runs code if condition is met.
            if (RightBar.X == 510)
            {
                // Draws a rectangle with the given information.
                e.Graphics.FillRectangle(Brushes.White, LoadingBar);
            }
        }

        // Runs code when time has elapsed.
        private void Graphic(object sender, EventArgs e)
        {
            // Runs code if condition is met.
            if (RightBar.X < 510)
            {
                // Alters the X coordinate of the rectangle.
                RightBar.X += 1;
                LeftBar.X -= 1;

                // Reloads the Loading Graphic panel.
                PLoadingGraphic.Invalidate();
            }

            // Runs code if condition is met.
            else if (LoadingBar.Width < 484)
            {
                // Shows the Loading Graphic label.
                LBLoadingGraphic.Show();

                // Alters the width of the rectangle.
                LoadingBar.Width += 1;

                // Reloads the Loading Graphic panel.
                PLoadingGraphic.Invalidate();

                // Runs code if condition is met.
                if (IsTransparent == false)
                {
                    // Changes the value of the Alpha variable by the value of the Step variable.
                    Alpha -= Step;

                    // Runs code if condition is met.
                    if (Alpha <= 0)
                    {
                        // Sets the Alpha variable to 0 and changes the IsTransparent variable to true.
                        Alpha = 0;
                        IsTransparent = true;
                    }

                    // Reloads the Loading Graphic label.
                    LBLoadingGraphic.Invalidate();
                }

                // Runs code if condition is met.
                else
                {
                    // Changes the value of the Alpha variable by the value of the Step variable.
                    Alpha += Step;

                    // Runs code if condition is met.
                    if (Alpha >= 255)
                    {
                        // Sets the Alpha variable to 255 and changes the IsTransparent variable to fales.
                        Alpha = 255;
                        IsTransparent = false;
                    }

                    // Reloads the Loading Graphic label.
                    LBLoadingGraphic.Invalidate();
                }
            }

            // Runs code if condition is met.
            else
            {
                // Stops the timer, hides this debug window and shows main form.
                TMGraphic.Stop();
                SM.Show();
                this.Hide();
            }
        }

        // Runs code when the form loads.
        private void Loading_Text_Graphic(object sender, PaintEventArgs e)
        {
            // Runs code if condition is met.
            if (Alpha > 0)
            {
                // Gives the brush variable all the properties of the Brush class.
                using (Brush brush = new SolidBrush(Color.FromArgb(Alpha, LBLoadingGraphic.ForeColor)))
                {
                    // Draw the text with the given information.
                    e.Graphics.DrawString("Loading", LBLoadingGraphic.Font, brush, LBLoadingGraphic.ClientRectangle, Format);
                }
            }
        }
    }
}
