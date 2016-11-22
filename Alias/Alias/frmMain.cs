using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Alias
{
    public partial class frmMain : Form
    {

        //  *** VARIABILI GLOBALI ***

        public string root = "C:/ProgramData/Hydra-Studio/Alias/";
        public string[] games = new string[65536];
        public int index = 0;
        public int width = 230, height = 107;
        public List<string> libraryGames = new List<string>();

        //  *** INIZIO CODICE ***

        public frmMain()
        {
            InitializeComponent();
        }

        public void UpdateGames()
        {
            // Creo un array da un elemento per contenere il contenuto del file *root*/User/path.usr
            string[] steampath = new string[3];
            // Ottengo la path di steam
            steampath = File.ReadAllLines(root + "/path.usr", Encoding.UTF8);
            // Trovo tutti gli appmanifest nella steampath
            for (int paths = 0; paths < 3; paths++)
            {
                if (steampath[paths] != "")
                {
                    string[] appmanifest = System.IO.Directory.GetFiles(steampath[paths]);
                    // Resetto l' indice
                    index = 0;
                    // Cicla le appmanifest_%id% e le mette nell' array games
                    for (int i = 0; i < appmanifest.Length; i++)
                    {
                        if (appmanifest[i].StartsWith(steampath[paths] + "\appmanifest_"))
                        {
                            string fileName = appmanifest[i];
                            games[index] = fileName.Substring(11);
                            index++;
                        }
                    }
                    // E aggiunge i nuovi giochi nella libreria
                    for (int i = 0; i < appmanifest.Length; i++)
                    {
                        try
                        {
                            appmanifest[i] = appmanifest[i].Substring(appmanifest[i].LastIndexOf('_') + 1);
                            appmanifest[i] = appmanifest[i].Remove(appmanifest[i].LastIndexOf(".acf"));
                            libraryGames.Add("steam://rungameid/" + appmanifest[i]);
                        }
                        catch
                        {
                            // Niente per il momento, a dire la verita' mi sono dimenticato quello che volevo fare. Vado avanti -.-
                        }
                    }
                }
            }
        }

        public void RefreshGames()
        {
            for (int i = 0; i < libraryGames.Count; i++)
            {
                // Inizializza la foto dei giochi
                PictureBox game = new PictureBox();
                game.Parent = flpGames;
                game.Click += gameLaunch;
                // Modifica alcune sue proprieta'
                game.Name = "game_" + i;
                // VECCHIO METODO ->    game.Tag = lbxLibrary.Items[i].ToString();
                game.Tag = libraryGames[i];
                game.Width = 230;
                game.Height = 107;
                game.SizeMode = PictureBoxSizeMode.StretchImage;
                // Ricava lo steam Id
                // VECCHIO METODO ->    string gameName = lbxLibrary.Items[i].ToString();
                string gameName = libraryGames[i];
                string steamid = gameName.Substring(gameName.LastIndexOf("/") + 1);
                // Carica immagine
                game.Load("http://cdn.akamai.steamstatic.com/steam/apps/" + steamid + "/header.jpg"); ;
            }
        }

        public void gameLaunch(object sender, EventArgs e)
        {
            PictureBox game = (PictureBox)sender;
            Process p = new Process();
            // Starta il processo scritto nel tag
            p.StartInfo = new ProcessStartInfo(game.Tag.ToString());
            p.Start();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // Controlla se ha gia' avviato ALiAS
            if (!System.IO.Directory.Exists(root))
            {
                frmChooseFolders chooseFolders = new frmChooseFolders();
                chooseFolders.ShowDialog();
            } else {    // Altrimenti se ha almeno una volta avviato ALiAS
                UpdateGames();
                RefreshGames();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings();
            Settings.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateGames();
            RefreshGames();
        }
    }
}
