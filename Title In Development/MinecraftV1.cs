// Copyright - Toby Hunter
// Namespaces used in the Class.
using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json.Linq;
using Dropbox.Api;
using Dropbox.Api.Files;
using System.Threading;
using System.Diagnostics;
using System.IO.Compression;

namespace Title_In_Development
{
    internal class MinecraftV1
    {
        // Global Class Objects.
        XmlDocument XML = new XmlDocument();
        private Sync_Menu _SM;
        TimeSpan Time;

        // Local Class Variables.
        private bool Variables;
        private string ServerLocation;
        private string ServerBatFile;
        private string SyncStatus;
        private string ServerName;
        private string IP;
        private string ServerStatus;
        private string LastRan;
        private string MOTD;
        private string Gamemode;
        private string Difficulty;
        private string LevelType;
        private string WhiteList;
        private string PVP;
        private string MaxPlayers;
        private string BuildLimit;
        private string GenerateStructures;
        private string ViewDistance;
        private string Ops;
        private string Bans;
        private string Mods;
        private string DateLMServer;
        private bool UpdateCheck;
        private bool UploadUpdate;
        private bool DownloadUpdate;
        private bool ServerRunning;

        // Handles the Sync_Menu.
        public MinecraftV1(Sync_Menu SM)
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

        // Local get used to change the value of the ServerName variable.
        public string SN
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return ServerName;
            }
        }

        // Local get used to change the value of the ServerLocation variable.
        public string SL
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return ServerLocation;
            }
        }

        // Local get used to change the value of the ServerBatFile variable.
        public string SB
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return ServerBatFile;
            }
        }

        // Local get used to change the value of the SyncStatus variable.
        public string LBSS
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return SyncStatus;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable.
                SyncStatus = value;
            }
        }

        // Local get used to change the value of the IP variable.
        public string IPAddress
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return IP;
            }
        }

        // Local get set used to change the value of the ServerStatus variable.
        public string SS
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return ServerStatus;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the ServerStatusChange Method.
                ServerStatus = value;
                ServerStatusChange();
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

        // Local get used to change the value of the MOTD variable.
        public string MinecraftMOTD
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return MOTD;
            }
        }

        // Local get used to change the value of the Gamemode variable.
        public string GM
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Gamemode;
            }
        }

        // Local get used to change the value of the Difficulty variable.
        public string D
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Difficulty;
            }
        }

        // Local get used to change the value of the LevelType variable.
        public string LT
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return LevelType;
            }
        }

        // Local get used to change the value of the WhiteList variable.
        public string WL
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return WhiteList;
            }
        }

        // Local get used to change the value of the PVP variable.
        public string PVPEnabled
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return PVP;
            }
        }

        // Local get used to change the value of the MaxPlayers variable.
        public string MP
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return MaxPlayers;
            }
        }

        // Local get used to change the value of the BuildLimit variable.
        public string BL
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return BuildLimit;
            }
        }

        // Local get used to change the value of the GenerateStructures variable.
        public string GS
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return GenerateStructures;
            }
        }

        // Local get used to change the value of the ViewDistance variable.
        public string VD
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return ViewDistance;
            }
        }

        // Local get used to change the value of the Ops variable.
        public string OppedPlayers
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Ops;
            }
        }

        // Local get used to change the value of the Bans variable.
        public string BannedPlayers
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Bans;
            }
        }

        // Local get used to change the value of the Mods variable.
        public string ServerMods
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return Mods;
            }
        }

        // Local get set used to change the value of the UpdateCheck variable.
        public bool UC
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return UpdateCheck;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the Check Method.
                UpdateCheck = value;
                Check();
            }
        }

        // Local get set used to change the value of the UploadUpdate variable.
        public bool UU
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return UploadUpdate;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the Upload Method.
                UploadUpdate = value;
                Upload();
            }
        }

        // Local get set used to change the value of the DownloadUpdate variable.
        public bool DU
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return DownloadUpdate;
            }

            // Changes the value of the variable.
            set
            {
                // Changes the value of the variable and calls the Download Method.
                DownloadUpdate = value;
                Download();
            }
        }

        // Local get used to change the value of the ServerRunning variable.
        public bool SR
        {
            // Obtains the value of the variable.
            get
            {
                // Obtains the value of the variable.
                return ServerRunning;
            }
        }

    // Runs code when the method is called.
    private async void FillVariables()
        {
            // Runs code even if error may occur.
            try
            {
                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Variable Population triggered for the MinecraftV1 class.";

                // Loads the XML of the given file, sets the FolderPath variable to the value in the given XML node, sets the ServerLocation variable to the value of the given variable, sets the ServerBatFile variable to the given information,
                // sets the LastRan variable to the value in the given XML node, sets the ServerHosted variable to the value in the given XML node and sets the ServerProp variable to the text of the given file.
                XML.Load(@".\Configuration\Server Config.config");
                string FolderPath = XML.SelectSingleNode("Servers/Minecraft-1.7.10/Location").Attributes[0].Value;
                ServerLocation = FolderPath + "\\";
                ServerBatFile = XML.SelectSingleNode("Servers/Minecraft-1.7.10/Location").Attributes[0].Value + "\\Start.bat";
                LastRan = XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText;
                string ServerOpenLocal = XML.SelectSingleNode("Servers/Minecraft-1.7.10/ServerOpen").InnerText;
                string[] ServerProp = File.ReadAllLines(FolderPath + "\\server.properties");

                // Runs code if condition is met.
                if ((LastRan.Contains("AM") == true) || (LastRan.Contains("PM") == true))
                {
                    // Converts the string to the accepted format.
                    LastRan = DateTime.ParseExact(LastRan, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd/MM/yyyy HH:mm");
                }

                // Runs code if condition is met.
                else
                {
                    // Converts the string to the accepted format.
                    LastRan = DateTime.Parse(LastRan).ToString("dd/MM/yyyy HH:mm");
                }

                // Runs code for every line in the array.
                foreach (var line in ServerProp)
                {
                    // Runs code if condition is met.
                    if (line.Contains("level-name=") == true)
                    {
                        // Sets the value of the variable to the current line.
                        ServerName = line.Replace("level-name=", "");
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("server-ip=") == true)
                    {
                        // Sets the value of the variable to the current line.
                        IP = line.Replace("server-ip=", "");
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("motd=") == true)
                    {
                        // Sets the value of the variable to the current line.
                        MOTD = line.Replace("motd=", "");
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("gamemode=") == true)
                    {
                        // Runs code if condition is met.
                        if (line.Replace("gamemode=", "") == "0")
                        {
                            // Sets the value of the variable to the given string.
                            Gamemode = "Survival";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("gamemode=", "") == "1")
                        {
                            // Sets the value of the variable to the given string.
                            Gamemode = "Creative";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("gamemode=", "") == "2")
                        {
                            // Sets the value of the variable to the given string.
                            Gamemode = "Adventure";
                        }
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("difficulty=") == true)
                    {
                        // Runs code if condition is met.
                        if (line.Replace("difficulty=", "") == "0")
                        {
                            // Sets the value of the variable to the given string.
                            Difficulty = "Peaceful";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("difficulty=", "") == "1")
                        {
                            // Sets the value of the variable to the given string.
                            Difficulty = "Easy";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("difficulty=", "") == "2")
                        {
                            // Sets the value of the variable to the given string.
                            Difficulty = "Normal";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("difficulty=", "") == "3")
                        {
                            // Sets the value of the variable to the given string.
                            Difficulty = "Hard";
                        }
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("level-type=") == true)
                    {
                        // Sets the value of the variable to the current line.
                        LevelType = line.Replace("level-type=", "");
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("white-list=") == true)
                    {
                        // Runs code if condition is met.
                        if (line.Replace("white-list=", "") == "false")
                        {
                            // Sets the value of the variable to the given string.
                            WhiteList = "False";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("white-list=", "") == "true")
                        {
                            // Sets the value of the variable to the given string.
                            WhiteList = "True";
                        }
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("pvp=") == true)
                    {
                        // Runs code if condition is met.
                        if (line.Replace("pvp=", "") == "false")
                        {
                            // Sets the value of the variable to the given string.
                            PVP = "False";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("pvp=", "") == "true")
                        {
                            // Sets the value of the variable to the given string.
                            PVP = "True";
                        }
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("max-players=") == true)
                    {
                        // Sets the value of the variable to the current line.
                        MaxPlayers = line.Replace("max-players=", "");
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("max-build-height=") == true)
                    {
                        // Sets the value of the variable to the current line.
                        BuildLimit = line.Replace("max-build-height=", "");
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("generate-structures=") == true)
                    {
                        // Runs code if condition is met.
                        if (line.Replace("generate-structures=", "") == "false")
                        {
                            // Sets the value of the variable to the given string.
                            GenerateStructures = "False";
                        }

                        // Runs code if condition is met.
                        else if (line.Replace("generate-structures=", "") == "true")
                        {
                            // Sets the value of the variable to the given string.
                            GenerateStructures = "True";
                        }
                    }

                    // Runs code if condition is met.
                    else if (line.Contains("view-distance=") == true)
                    {
                        // Sets the value of the variable to the current line.
                        ViewDistance = line.Replace("view-distance=", "");
                    }
                }

                // Sets the value of OppedPayers to the json in the given file, parses the JSON through the JObject class and sets the value of the variable to null.
                string OppedPlayers = File.ReadAllText(FolderPath + "\\ops.json");
                JArray JSON = JArray.Parse(OppedPlayers);
                Ops = null;

                // Runs code for every line in the array.
                for (int x = 0; x < JSON.Count; x++)
                {
                    // Sets the value of the variable to the current line.
                    Ops += Environment.NewLine + JSON[x]["name"].Value<string>();
                }

                // Sets the value of BannedPlayers to the json in the given file, parses the JSON through the JObject class and sets the value of the variable to null.
                string BannedPlayers = File.ReadAllText(FolderPath + "\\banned-players.json");
                JSON = JArray.Parse(BannedPlayers);
                Bans = null;

                // Runs code for every line in the array.
                for (int x = 0; x < JSON.Count; x++)
                {
                    // Sets the value of the variable to the current line.
                    Bans += Environment.NewLine + JSON[x]["name"].Value<string>();
                }

                // Sets the value of the variable to null.
                Mods = null;

                // Runs code for all directories in the file path.
                foreach (var directory in Directory.GetDirectories(FolderPath + "\\Mods"))
                {
                    // Runs code if condition is met.
                    if (directory.Replace(FolderPath + "\\Mods\\", "") != "1.7.10")
                    {
                        // Sets the value of the variable to the current line.
                        Mods += Environment.NewLine + directory.Replace(FolderPath + "\\Mods\\", "");
                    }
                }

                // Runs code for all files in the file path.
                foreach (var file in Directory.GetFiles(FolderPath + "\\Mods"))
                {
                    // Sets the value of the variable to the current line.
                    Mods += Environment.NewLine + file.Replace(FolderPath + "\\Mods\\", "");
                }

                // Assigns Drobox all the properties of the DropboxClient class, stores the dropbox folder path, stores the name of the update zip file,
                // Stores its local file path.
                DropboxClient Dropbox = new DropboxClient("HT2yFlPkZAMAAAAAAAAAAShPNIPtHXWex651zisQZP-X-3v_CdL6iC0t3xysiorO");
                string Folder = "Games/1.7.10";
                string FileName = "Global Server Config.config";
                string FilePath = ".\\Configuration\\Global Server Config.config";

                // Downloads the file.
                using (var response = await Dropbox.Files.DownloadAsync("/" + Folder + "/" + FileName))
                {
                    // Moves the file to the specified file path.
                    using (var fileStream = File.Create(FilePath))
                    {
                        // Waits for the download to finish.
                        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                    }
                }

                // Loads the XML of the given file, sets the DateLMServer variable to the value in the given XML node and sets the ServerPlayed variable to the value in the given XML node.
                XML.Load(@".\Configuration\Global Server Config.config");
                DateLMServer = XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText;
                string ServerOpenGlobal = XML.SelectSingleNode("Servers/Minecraft-1.7.10/ServerOpen").InnerText;

                // Runs code if condition is met.
                if ((DateLMServer.Contains("AM") == true) || (DateLMServer.Contains("PM") == true))
                {
                    // Converts the string to the accepted format.
                    DateLMServer = DateTime.ParseExact(DateLMServer, "dd/MM/yyyy hh:mm:ss tt", null).ToString();
                }

                // Runs code if condition is met.
                if ((ServerOpenGlobal == "True") && (ServerOpenLocal == "True"))
                {
                    // Sets the value of the ServerStatus to the given string and changes the value of the ServerRunning variable to true.
                    ServerStatus = "Running";
                    ServerRunning = true;
                }

                // Runs code if condition is met.
                else if ((ServerOpenGlobal == "True") && (ServerOpenLocal == "False"))
                {
                    // Sets the value of the ServerStatus to the given string and changes the value of the ServerRunning variable to true.
                    ServerStatus = "Open";
                    ServerRunning = true;
                }

                // Runs code if condition is met.
                else if ((ServerOpenGlobal == "False") && (ServerOpenLocal == "True"))
                {
                    // Sets the value of the ServerStatus to the given string and changes the value of the ServerRunning variable to true.
                    ServerStatus = "Running";
                    ServerRunning = true;
                }

                // Runs code if condition is met.
                else
                {
                    // Sets the value of the ServerStatus to the given string and changes the value of the ServerRunning variable to false.
                    ServerStatus = "Stopped";
                    ServerRunning = false;
                }

                // Deletes the GCF file and sets the Variables variable to false.
                File.Delete(FilePath);
                Variables = false;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Variable Population complete for the MinecraftV1 class.";

                // Passes a value to the _SM.FMV1 get set.
                _SM.FMV1 = true;
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\MV1FillVariables_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to fill the variables for the Minecraft 1.7.10 tab:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to fill the variables for the Minecraft 1.7.10 tab, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to fill the variables for the Minecraft 1.7.10 tab, see error log for details.";
                }
            }
        }

        // Runs code when the method is called.
        private async void ServerStatusChange()
        {
            // Runs code even if error may occur.
            try
            {
                // Runs code if condition is met.
                if (ServerStatus == "Running")
                {
                    // Loads the XML of the given file, changes the ServerOpen true false flag and saves the file.
                    XML.Load(@".\Configuration\Server Config.config");
                    XML.SelectSingleNode("Servers/Minecraft-1.7.10/ServerOpen").InnerText = "True";
                    XML.Save(@".\Configuration\Server Config.config");

                    // Assigns Drobox all the properties of the DropboxClient class, stores the dropbox folder path, stores the name of the update zip file,
                    // Stores its local file path.
                    DropboxClient Dropbox = new DropboxClient("HT2yFlPkZAMAAAAAAAAAAShPNIPtHXWex651zisQZP-X-3v_CdL6iC0t3xysiorO");
                    string Folder = "Games/1.7.10";
                    string FileName = "Global Server Config.config";
                    string FilePath = ".\\Configuration\\Global Server Config.config";

                    // Downloads the file.
                    using (var Response = await Dropbox.Files.DownloadAsync("/" + Folder + "/" + FileName))
                    {
                        // Moves the file to the specified file path.
                        using (var FileStream = File.Create(FilePath))
                        {
                            // Waits for the download to finish.
                            (await Response.GetContentAsStreamAsync()).CopyTo(FileStream);
                        }
                    }

                    // Loads the XML of the given file, changes the ServerOpen true false flag and saves the file.
                    XML.Load(@".\Configuration\Global Server Config.config");
                    XML.SelectSingleNode("Servers/Minecraft-1.7.10/ServerOpen").InnerText = "True";
                    XML.Save(@".\Configuration\Global Server Config.config");

                    // Passes a string to the _SM.L get set.
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Uploading altered Global Server Config file.";

                    // Reads the file into a stream.
                    using (var MemoryStream = new MemoryStream(File.ReadAllBytes(FilePath)))
                    {
                        // Uploads the file to dropbox.
                        var Result = await Dropbox.Files.UploadAsync("/" + Folder + "/" + FileName, WriteMode.Overwrite.Instance, body: MemoryStream);
                    }

                    // Deletes the GCF file.
                    File.Delete(FilePath);

                    // Passes a string to the _SM.L get set.
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Uploading of altered Global Server Config file is complete.";
                }

                // Runs code if condition is met.
                else
                {
                    // Loads the XML of the given file, changes the ServerOpen true false flag and saves the file.
                    XML.Load(@".\Configuration\Server Config.config");
                    XML.SelectSingleNode("Servers/Minecraft-1.7.10/ServerOpen").InnerText = "False";
                    XML.Save(@".\Configuration\Server Config.config");

                    // Assigns Drobox all the properties of the DropboxClient class, stores the dropbox folder path, stores the name of the update zip file,
                    // Stores its local file path.
                    DropboxClient Dropbox = new DropboxClient("HT2yFlPkZAMAAAAAAAAAAShPNIPtHXWex651zisQZP-X-3v_CdL6iC0t3xysiorO");
                    string Folder = "Games/1.7.10";
                    string FileName = "Global Server Config.config";
                    string FilePath = ".\\Configuration\\Global Server Config.config";

                    // Downloads the file.
                    using (var Response = await Dropbox.Files.DownloadAsync("/" + Folder + "/" + FileName))
                    {
                        // Moves the file to the specified file path.
                        using (var FileStream = File.Create(FilePath))
                        {
                            // Waits for the download to finish.
                            (await Response.GetContentAsStreamAsync()).CopyTo(FileStream);
                        }
                    }

                    // Loads the XML of the given file, changes the ServerOpen true false flag and saves the file.
                    XML.Load(@".\Configuration\Global Server Config.config");
                    XML.SelectSingleNode("Servers/Minecraft-1.7.10/ServerOpen").InnerText = "False";
                    XML.Save(@".\Configuration\Global Server Config.config");

                    // Passes a string to the _SM.L get set.
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Uploading altered Global Server Config file.";

                    // Reads the file into a stream.
                    using (var MemoryStream = new MemoryStream(File.ReadAllBytes(FilePath)))
                    {
                        // Uploads the file to dropbox.
                        var Result = await Dropbox.Files.UploadAsync("/" + Folder + "/" + FileName, WriteMode.Overwrite.Instance, body: MemoryStream);
                    }

                    // Deletes the GCF file.
                    File.Delete(FilePath);

                    // Passes a string to the _SM.L get set.
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Uploading of altered Global Server Config file is complete.";
                }
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\MV1UpdateServerStatus_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to update the server status for the Minecraft 1.7.10 tab:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to update the server status for the Minecraft 1.7.10 tab, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to update the server status for the Minecraft 1.7.10 tab, see error log for details.";
                }
            }
        }

        // Runs code when the method is called.
        private async void Check()
        {
            // Runs code even if error may occur.
            try
            {
                // Sets the value of the SyncStatus Variable to the given string and starts the timer.
                SyncStatus = "Checking  ";
                _SM.MV1SST = true;

                // Runs code if condition is met.
                if (ServerRunning == false)
                {
                    // Passes a string to the _SM.L get set.
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Checking for an update to the minecraft 1.7.10 server.";

                    // Assigns Drobox all the properties of the DropboxClient class, stores the dropbox folder path, stores the name of the update zip file,
                    // Stores its local file path.
                    DropboxClient Dropbox = new DropboxClient("HT2yFlPkZAMAAAAAAAAAAShPNIPtHXWex651zisQZP-X-3v_CdL6iC0t3xysiorO");
                    string Folder = "Games/1.7.10";
                    string FileName = "Global Server Config.config";
                    string FilePath = ".\\Configuration\\Global Server Config.config";

                    // Downloads the file.
                    using (var response = await Dropbox.Files.DownloadAsync("/" + Folder + "/" + FileName))
                    {
                        // Moves the file to the specified file path.
                        using (var fileStream = File.Create(FilePath))
                        {
                            // Waits for the download to finish.
                            (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                        }
                    }

                    // Passes a string to the _SM.L get set.
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Checking local last modified against global last modified.";

                    // Loads the XML of the given file and sets the DateLM to the value of the XML node.
                    XML.Load(@".\Configuration\Server Config.config");
                    string DateLM = XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText;

                    // Runs code if condition is met.
                    if ((DateLM.Contains("AM") == true) || (DateLM.Contains("PM") == true))
                    {
                        // Converts the string to the accepted format.
                        DateLM = DateTime.ParseExact(DateLM, "dd/MM/yyyy hh:mm:ss tt", null).ToString();
                    }

                    // Loads the XML of the given file and sets the DateLMServer variable to the value in the given XML node.
                    XML.Load(@".\Configuration\Global Server Config.config");
                    DateLMServer = XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText;

                    // Runs code if condition is met.
                    if ((DateLMServer.Contains("AM") == true) || (DateLMServer.Contains("PM") == true))
                    {
                        // Converts the string to the accepted format.
                        DateLMServer = DateTime.ParseExact(DateLMServer, "dd/MM/yyyy hh:mm:ss tt", null).ToString();
                    }

                    // Runs code if condition met.
                    if (DateLM != DateLMServer)
                    {
                        // Calls the Download method.
                        Download();

                        // Sets the value of the SyncStatus Variable to the given string and sets the UpdateCheck variable to false.
                        SyncStatus = "Syncing  ";
                        UpdateCheck = false;
                    }

                    // Runs code if condition met.
                    else
                    {
                        // Obatins last modified date of selected file.
                        string SLM = File.GetLastWriteTime(Path.Combine(ServerLocation, "world\\level.dat")).ToString();

                        // Runs code if condition is met.
                        if ((SLM.Contains("AM") == true) || (SLM.Contains("PM") == true))
                        {
                            // Converts the string to the accepted format.
                            SLM = DateTime.ParseExact(SLM, "dd/MM/yyyy hh:mm:ss tt", null).ToString();
                        }

                        // Runs code if condition met.
                        if (DateLM != SLM)
                        {
                            // Calls the Upload method.
                            Upload();

                            // Sets the value of the SyncStatus Variable to the given string and sets the UpdateCheck variable to false.
                            SyncStatus = "Syncing  ";
                            UpdateCheck = false;
                        }

                        // Runs code if condition met.
                        else
                        {
                            // Passes a string to the _SM.L get set.
                            _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Update check complete, the minecraft 1.7.10 server is up to date.";

                            // Deletes the DateLMServer file.
                            File.Delete(".\\Configuration\\Global Server Config.config");

                            // Sets the value of the SyncStatus Variable to the given string, stops the timer, sets the UpdateCheck variable to false and calls the FillVariables method.
                            SyncStatus = "Up To Date";
                            _SM.MV1SST = false;
                            UpdateCheck = false;
                            FillVariables();
                        }
                    }
                }

                // Runs code if condition met.
                else
                {
                    // Sets the value of the SyncStatus Variable to the given string, stops the timer, sets the UpdateCheck variable to false and calls the FillVariables method.
                    SyncStatus = "Up To Date";
                    _SM.MV1SST = false;
                    UpdateCheck = false;
                    FillVariables();
                }
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\MV1UpdateCheck_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to check if an update is required for the Minecraft 1.7.10 tab:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to check if an update is required for the Minecraft 1.7.10 tab, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to check if an update is required for the Minecraft 1.7.10 tab, see error log for details.";
                }
            }
        }

        // Runs code when the method is called.
        private async void Upload()
        {
            // Runs code even if error may occur.
            try
            {
                // Stops the timer.
                _SM.MV1ST = false;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Local Minecraft 1.7.10 server has been updated or a manual sync has been triggered, beginning upload.";

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Starting upload of Minecraft 1.7.10 server.";

                // Zips save files into data folder.
                ZipFile.CreateFromDirectory(ServerLocation, ".\\Data\\Title In Development.zip");

                // Assigns Drobox all the properties of the DropboxClient class, stores the dropbox folder path, stores the name of the update zip file.
                DropboxClient Dropbox = new DropboxClient("HT2yFlPkZAMAAAAAAAAAAShPNIPtHXWex651zisQZP-X-3v_CdL6iC0t3xysiorO");
                string Folder = "Games/1.7.10";
                string FileName = "Title In Development.zip";

                // Chunk size is 10MB.
                const int ChunkSize = 10 * 1024 * 1024;

                // Loads the file.
                var FileContent = File.ReadAllBytes(".\\Data\\Title In Development.zip");

                // Reads the file into a stream.
                using (var Stream = new MemoryStream(FileContent))
                {
                    // Calculates the number of required chunks, estimated upload time and passes a string to the _SM.L get set.
                    int NumChunks = (int)Math.Ceiling((double)Stream.Length / ChunkSize);
                    int UploadTime = 6 * NumChunks;
                    Time = TimeSpan.FromSeconds(UploadTime);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - File has been split into " + NumChunks + " chunks, this will take approximately " + Time.ToString(@"hh\:mm\:ss") + " seconds.";

                    // Creates the chunks.
                    byte[] Buffer = new byte[ChunkSize];
                    string SessionId = null;

                    // Loops through all the chunks.
                    for (var x = 0; x < NumChunks; x++)
                    {
                        // Passes a string to the _SM.L get set and reads the current chunk.
                        _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Uploading chunk " + x + ".";
                        var ByteRead = Stream.Read(Buffer, 0, ChunkSize);

                        // Reads the chunk into a stream.
                        using (MemoryStream MemStream = new MemoryStream(Buffer, 0, ByteRead))
                        {
                            // Runs code if condition met.
                            if (x == 0)
                            {
                                // Starts the upload of chunks.
                                var Result = await Dropbox.Files.UploadSessionStartAsync(body: MemStream);
                                SessionId = Result.SessionId;
                            }

                            // Runs code if condition met.
                            else
                            {
                                // Creates an upload session for the current chunk.
                                UploadSessionCursor Cursor = new UploadSessionCursor(SessionId, (ulong)(ChunkSize * x));

                                // Runs code if condition met.
                                if (x == NumChunks - 1)
                                {
                                    // Uploads the chunk to dropbox.
                                    await Dropbox.Files.UploadSessionFinishAsync(Cursor, new CommitInfo("/" + Folder + "/" + FileName, mode: WriteMode.Overwrite.Instance), body: MemStream);
                                }

                                // Runs code if condition met.
                                else
                                {
                                    // Uploads the chunk to dropbox.
                                    await Dropbox.Files.UploadSessionAppendV2Async(Cursor, body: MemStream);
                                }
                            }
                        }
                    }
                }

                // Deletes the zip file.
                File.Delete(".\\Data\\Title In Development.zip");

                // Sets the variable to the time of the last modified of the given file.
                string LastWriteTime = File.GetLastWriteTime(Path.Combine(ServerLocation, "world\\level.dat")).ToString();

                // Runs code if condition is met.
                if ((LastWriteTime.Contains("AM") == true) || (LastWriteTime.Contains("PM") == true))
                {
                    // Converts the string to the accepted format.
                    LastWriteTime = DateTime.ParseExact(LastWriteTime, "dd/MM/yyyy hh:mm:ss tt", null).ToString();
                }

                // Loads the XML of the given file, sets the DateLM to the value of the XML node and saves the XML of the given file.
                XML.Load(@".\Configuration\Server Config.config");
                XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText = LastWriteTime;
                XML.Save(@".\Configuration\Server Config.config");

                string FilePath = ".\\Configuration\\Global Server Config.config";

                if (File.Exists(FilePath) == true)
                {
                    // Loads the XML of the given file, sets the DateLM to the value of the XML node and saves the XML of the given file.
                    XML.Load(@".\Configuration\Global Server Config.config");
                    XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText = LastWriteTime;
                    XML.Save(@".\Configuration\Global Server Config.config");
                }

                else
                {
                    // Stores the dropbox folder path and stores the name of the update file,
                    Folder = "Games/1.7.10";
                    FileName = "Global Server Config.config";

                    // Downloads the file.
                    using (var response = await Dropbox.Files.DownloadAsync("/" + Folder + "/" + FileName))
                    {
                        // Moves the file to the specified file path.
                        using (var fileStream = File.Create(FilePath))
                        {
                            // Waits for the download to finish.
                            (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                        }
                    }

                    // Loads the XML of the given file, sets the DateLM to the value of the XML node and saves the XML of the given file.
                    XML.Load(@".\Configuration\Global Server Config.config");
                    XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText = LastWriteTime;
                    XML.Save(@".\Configuration\Global Server Config.config");
                }

                // Stores the dropbox folder path, stores the name of the update text file.
                FileName = "Global Server Config.config";

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Uploading altered Global Server Config file.";

                // Reads the file into a stream.
                using (var MemoryStream = new MemoryStream(File.ReadAllBytes(FilePath)))
                {
                    // Uploads the file to dropbox.
                    var Result = await Dropbox.Files.UploadAsync("/" + Folder + "/" + FileName, WriteMode.Overwrite.Instance, body: MemoryStream);
                }

                // Deletes the GCF file.
                File.Delete(FilePath);

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Uploading of altered Global Server Config file is complete.";

                // Starts the timer.
                _SM.MV1ST = true;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Upload for the minecraft 1.7.10 server is complete.";

                // Sets the value of the SyncStatus Variable to the given string, stops the timer, sets the UploadUpdate variable to false and calls the FillVariables method.
                SyncStatus = "Up To Date";
                _SM.MV1SST = false;
                UploadUpdate = false;
                FillVariables();
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\MV1Upload_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to upload an update for the Minecraft 1.7.10 server:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to upload an update for the Minecraft 1.7.10 server, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to upload an update for the Minecraft 1.7.10 server, see error log for details.";
                }
            }
        }

        // Runs code when the method is called.
        private async void Download()
        {
            // Runs code even if error may occur.
            try
            {
                // Stops the timer.
                _SM.MV1ST = false;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Update for the minecraft 1.7.10 server is required, beginning update.";

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Starting download of update files for the minecraft 1.7.10 server.";

                // Assigns Drobox all the properties of the DropboxClient class, stores the dropbox folder path, stores the name of the update zip file,
                // Stores its local file path.
                DropboxClient Dropbox = new DropboxClient("HT2yFlPkZAMAAAAAAAAAAShPNIPtHXWex651zisQZP-X-3v_CdL6iC0t3xysiorO");
                string Folder = "Games/1.7.10";
                string FileName = "Title In Development.zip";
                string FilePath = ".\\Data\\Title In Development.zip";

                // Downloads the file.
                using (var response = await Dropbox.Files.DownloadAsync("/" + Folder + "/" + FileName))
                {
                    // Moves the file to the specified file path.
                    using (var fileStream = File.Create(FilePath))
                    {
                        // Waits for the download to finish.
                        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                    }
                }

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Download of update files for the minecraft 1.7.10 server is complete.";

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Debug - Extracting the update files for the minecraft 1.7.10 server.";

                // Deletes all files and folders in the save folder.
                Process.Start("cmd.exe", string.Format("/C RD /S /Q \"{0}", ServerLocation));

                // Pauses the process.
                Thread.Sleep(10000);

                // Creates the save folder.
                Directory.CreateDirectory(ServerLocation);

                // Extracts the ZIP file to the given path, deletes the zip file and moves the extracted files to the program's directory.
                ZipFile.ExtractToDirectory(FilePath, ServerLocation);
                File.Delete(FilePath);
                FilePath = FilePath.Replace("Title In Development.zip", "");

                // Loads the XML of the given file, sets the ServerProp to the value of the XML node and moves the server properties file to the server folder.
                XML.Load(@".\Configuration\Server Config.config");
                string ServerProp = XML.SelectSingleNode("Servers/Minecraft-1.7.10/Location").Attributes[1].Value;
                File.Copy(ServerProp + "\\server.properties", ServerLocation + "\\server.properties", true);

                // Updates the DateLM to match the DateLMServer and updates the config file.
                XML.SelectSingleNode("Servers/Minecraft-1.7.10/LastUpdate").InnerText = DateLMServer;
                XML.Save(@".\Configuration\Server Config.config");

                // Deletes the Global Config file.
                File.Delete(".\\Configuration\\Global Server Config.config");

                // Starts the timer.
                _SM.MV1ST = true;

                // Passes a string to the _SM.L get set.
                _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Info - Update for the minecraft 1.7.10 server is complete.";

                // Sets the value of the SyncStatus Variable to the given string, stops the timer, sets the DownloadUpdate variable to false and calls the FillVariables method.
                SyncStatus = "Up To Date";
                _SM.MV1SST = false;
                DownloadUpdate = false;
                FillVariables();
            }

            // Runs code if an error occurs.
            catch (Exception ex)
            {
                // Creates a file path and name for the error log and creates the error message.
                string ErrorLog = @".\Logs\Error Logs\MV1Download_Error." + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
                string ErrorMsg = "The following error occured while trying to download an update for the Minecraft 1.7.10 server:" + Environment.NewLine + ex.ToString();

                // Runs code if condition is met.
                if (File.Exists(ErrorLog) == true)
                {
                    // Writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.WriteAllText(ErrorLog, File.ReadAllText(ErrorLog) + Environment.NewLine + Environment.NewLine + ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to download an update for the Minecraft 1.7.10 server, see error log for details.";
                }

                // Runs code if condition is met.
                else
                {
                    // Creates the file, writes the error message to the log file, changes the value of the InternetConnected variable and passes a string to the _SM.L get set.
                    File.Create(ErrorLog).Dispose();
                    File.WriteAllText(ErrorLog, ErrorMsg);
                    _SM.L = Environment.NewLine + DateTime.Now.ToString() + " - Error - An error occured while trying to download an update for the Minecraft 1.7.10 server, see error log for details.";
                }
            }
        }
    }
}
