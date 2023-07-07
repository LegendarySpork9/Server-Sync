// Copyright - Toby Hunter
// Namespaces used in the Class.
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.IO.Compression;
using System.Threading;

namespace Title_In_Development
{
    internal class ColdWaters
    {
        // Global Class Objects.
        XmlDocument XML = new XmlDocument();
        private Sync_Menu _SM;
        ProcessStartInfo PSI;
        Process EF;

        // Local Class Variables.
        private bool Variables;
        private string GameDirectory;
        private string ModDirectory;
        private string LastRan;
        private string ModRunning;
        private string Mod;
        private int RetryNumber = 0;
        private bool SwitchModTF;

        // Handles the Sync_Menu.
        public ColdWaters(Sync_Menu SM)
        {
            // Gives the SM variable the methods of the Sync_Menu form.
            _SM = SM;
        }

        // Local get set used to change the value of the Variables variable.
        public bool FV
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Variables;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the FillVariables Method.
                Variables = value;
                FillVariables();
            }
        }

        // Local get used to change the value of the LastRan variable.
        public string LR
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return LastRan;
            }
        }

        // Local get used to change the value of the ModRunning variable.
        public string MR
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return ModRunning;
            }
        }

        // Local get set used to change the value of the Mod variable.
        public string M
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Mod;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the SwitchMod Method.
                Mod = value;
                SwitchMod();
            }
        }

        // Local get set used to change the value of the SwitchModTF variable.
        public bool SM
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return SwitchModTF;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the SwitchMod Method.
                SwitchModTF = value;
                SwitchMod();
            }
        }

        // Runs code when the method is called.
        private async void FillVariables()
        {
            // Runs code even if error may occur.
            try
            {
                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Variable Population triggered for the ColdWaters class.";

                // Loads the XML of the given file, sets the FolderPath variable to the value in the given XML node, sets the ServerLocation variable to the value of the given variable, sets the ServerBatFile variable to the given information,
                // sets the Hamachi variable to the given information, sets the LastRan variable to the value in the given XML node, sets the ServerHosted variable to the value in the given XML node and sets the ServerProp variable to the text of the given file.
                XML.Load(@".\Configuration\Server Config.config");
                GameDirectory = XML.SelectSingleNode("ServerSync/Servers/Cold-Waters/Location").Attributes[0].Value + "\\";
                ModDirectory = XML.SelectSingleNode("ServerSync/Servers/Cold-Waters/Location").Attributes[1].Value + "\\";
                LastRan = XML.SelectSingleNode("ServerSync/Servers/Cold-Waters/LastRan").InnerText;
                ModRunning = XML.SelectSingleNode("ServerSync/Servers/Cold-Waters/ModRunning").InnerText;

                // Runs code if condition is met.
                if ((LastRan.Contains("AM") == true) || (LastRan.Contains("PM") == true))
                {
                    // Converts the string to the accepted format.
                    LastRan = DateTime.ParseExact(LastRan, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd/MM/yyyy hh:mm tt");
                }

                // Obatins last modified date of selected file.
                string GLM = File.GetLastWriteTime(Path.Combine(GameDirectory, "output_log.txt")).ToString();

                // Runs code if condition is met.
                if ((GLM.Contains("AM") == true) || (GLM.Contains("PM") == true))
                {
                    // Converts the string to the accepted format.
                    GLM = DateTime.ParseExact(GLM, "dd/MM/yyyy hh:mm:ss tt", null).ToString();
                }

                // Runs code if condition is met.
                if (LastRan != GLM)
                {
                    // Loads the XML of the given file, updates the LastRan, saves the file and changes the value of the LastRan variable.
                    XML.Load(@".\Configuration\Server Config.config");
                    XML.SelectSingleNode("ServerSync/Servers/Cold-Waters/LastRan").InnerText = GLM;
                    XML.Save(@".\Configuration\Server Config.config");
                    LastRan = GLM;
                }

                // Sets the Variables variable to false.
                Variables = false;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Variable Population complete for the ColdWaters class.";

                // Passes a value to the _SM.FCD get set.
                _SM.FCW = true;
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\CWFillVariables_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to fill the variables for the Cold Waters tab:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to fill the variables for the Cold Waters tab, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to fill the variables for the Cold Waters tab, see error log for details.";
                }
            }
        }

        // Runs code when the method is called.
        private async void SwitchMod()
        {
            // Sets the SwitchModTF Variable to false.
            SwitchModTF = false;

            // Runs code if condition is met.
            if (Mod == "Vanilla +")
            {
                // Calls the Vanilla Method.
                Vanilla();
            }

            // Runs code if condition is met.
            else
            {
                // Calls the DotMod Method.
                DotMod();
            }
        }

        // Runs code when the method is called.
        private async void Vanilla()
        {
            // Runs code even if error may occur.
            try
            {
                // Deletes the ZIP file if it already exists to avoid error.
                File.Delete(".\\Data\\Cold Waters Dot Mod.zip");

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Mod switching has been triggered for Cold Waters, beginning switch.";

                // Zips save files into data folder, moves the file to the storage location and deletes the file in the Data folder.
                ZipFile.CreateFromDirectory(GameDirectory, ".\\Data\\Cold Waters Dot Mod.zip");
                File.Copy(".\\Data\\Cold Waters Dot Mod.zip", ModDirectory + "Cold Waters Dot Mod.zip", true);
                File.Delete(".\\Data\\Cold Waters Dot Mod.zip");

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Backed up the Dot Mod game files, activating Vanilla +.";

                // Passes the methods of the ProcessStartInfo class with the given information.
                PSI = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = string.Format("/C RD /S /Q \"{0}", GameDirectory),
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Passes the methods of the Process class with the start info of the given information and deletes all files and folders in the save folder.
                EF = new Process { StartInfo = PSI };
                EF.Start();

                // Pauses the process.
                Thread.Sleep(10000);

                // Creates the save folder.
                Directory.CreateDirectory(GameDirectory);

                // Extracts the game files.
                ZipFile.ExtractToDirectory(ModDirectory + "Cold Waters Vanilla Plus.zip", GameDirectory);

                // Loads the XML of the given file, updates the ModRunning and saves the file.
                XML.Load(@".\Configuration\Server Config.config");
                XML.SelectSingleNode("ServerSync/Servers/Cold-Waters/ModRunning").InnerText = "Vanilla +";
                XML.Save(@".\Configuration\Server Config.config");

                // Starts the timer.
                _SM.MV1ST = true;

                // Calls the FillVariables method and resets the RetryNumber Variable.
                FillVariables();
                RetryNumber = 0;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Mod switching for Cold Waters is complete.";
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\CWVanilla_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to switch the mods for Cold Waters:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to switch the mods for Cold Waters, see error log for details.";

                    // Runs code if condition is met.
                    if (RetryNumber < 3)
                    {
                        // Passes a string to the _SM.L get set, increases RetryNumber by 1 and starts the timer.
                        _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Retry timer has been started, switch will be attempted again in 30 seconds.";
                        RetryNumber += 1;
                        _SM.RTS = "ColdWaters";
                        _SM.RT = true;
                    }

                    // Runs code if condition is met.
                    else
                    {
                        // Sets the Mod variable to null, calls the FillVariables method and stops the timer.
                        Mod = null;
                        FillVariables();
                        _SM.RTS = null;
                        _SM.RT = false;
                    }
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to switch the mods for Cold Waters, see error log for details.";

                    // Runs code if condition is met.
                    if (RetryNumber < 3)
                    {
                        // Passes a string to the _SM.L get set, increases RetryNumber by 1 and starts the timer.
                        _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Retry timer has been started, switch will be attempted again in 30 seconds.";
                        RetryNumber += 1;
                        _SM.RTS = "ColdWaters";
                        _SM.RT = true;
                    }

                    // Runs code if condition is met.
                    else
                    {
                        // Sets the Mod variable to null, calls the FillVariables method and stops the timer.
                        Mod = null;
                        FillVariables();
                        _SM.RTS = null;
                        _SM.RT = false;
                    }
                }
            }
        }

        // Runs code when the method is called.
        private async void DotMod()
        {
            // Runs code even if error may occur.
            try
            {
                // Deletes the ZIP file if it already exists to avoid error.
                File.Delete(".\\Data\\Cold Waters Vanilla Plus.zip");

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Mod switching has been triggered for Cold Waters, beginning switch.";

                // Zips save files into data folder, moves the file to the storage location and deletes the file in the Data folder.
                ZipFile.CreateFromDirectory(GameDirectory, ".\\Data\\Cold Waters Vanilla Plus.zip");
                File.Copy(".\\Data\\Cold Waters Vanilla Plus.zip", ModDirectory + "Cold Waters Vanilla Plus.zip", true);
                File.Delete(".\\Data\\Cold Waters Vanilla Plus.zip");

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Backed up the Vanilla + game files, activating the Dot Mod.";

                // Passes the methods of the ProcessStartInfo class with the given information.
                PSI = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = string.Format("/C RD /S /Q \"{0}", GameDirectory),
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Passes the methods of the Process class with the start info of the given information and deletes all files and folders in the save folder.
                EF = new Process { StartInfo = PSI };
                EF.Start();

                // Pauses the process.
                Thread.Sleep(10000);

                // Creates the save folder.
                Directory.CreateDirectory(GameDirectory);

                // Extracts the game files.
                ZipFile.ExtractToDirectory(ModDirectory + "Cold Waters Dot Mod.zip", GameDirectory);

                // Loads the XML of the given file, updates the ModRunning and saves the file.
                XML.Load(@".\Configuration\Server Config.config");
                XML.SelectSingleNode("ServerSync/Servers/Cold-Waters/ModRunning").InnerText = "Dot Mod";
                XML.Save(@".\Configuration\Server Config.config");

                // Starts the timer.
                _SM.MV1ST = true;

                // Calls the FillVariables method and resets the RetryNumber Variable.
                FillVariables();
                RetryNumber = 0;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Mod switching for Cold Waters is complete.";
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\CWVanilla_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to switch the mods for Cold Waters:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to switch the mods for Cold Waters, see error log for details.";

                    // Runs code if condition is met.
                    if (RetryNumber < 3)
                    {
                        // Passes a string to the _SM.L get set, increases RetryNumber by 1 and starts the timer.
                        _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Retry timer has been started, switch will be attempted again in 30 seconds.";
                        RetryNumber += 1;
                        _SM.RTS = "ColdWaters";
                        _SM.RT = true;
                    }

                    // Runs code if condition is met.
                    else
                    {
                        // Sets the Mod variable to null, calls the FillVariables method and stops the timer.
                        Mod = null;
                        FillVariables();
                        _SM.RTS = null;
                        _SM.RT = false;
                    }
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to switch the mods for Cold Waters, see error log for details.";

                    // Runs code if condition is met.
                    if (RetryNumber < 3)
                    {
                        // Passes a string to the _SM.L get set, increases RetryNumber by 1 and starts the timer.
                        _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Warn - Retry timer has been started, switch will be attempted again in 30 seconds.";
                        RetryNumber += 1;
                        _SM.RTS = "ColdWaters";
                        _SM.RT = true;
                    }

                    // Runs code if condition is met.
                    else
                    {
                        // Sets the Mod variable to null, calls the FillVariables method and stops the timer.
                        Mod = null;
                        FillVariables();
                        _SM.RTS = null;
                        _SM.RT = false;
                    }
                }
            }
        }
    }
}
