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

namespace Alias
{
    public partial class mainForm : Form
    {

        //  *** VARIABILI GLOBALI ***

        public string root = "C:/ProgramData/Hydra-Studio/Alias/";

        //  *** INIZIO CODICE ***

        public mainForm()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // Controlla se ha gia' avviato ALiAS
            if (!System.IO.Directory.Exists(root))
            {
                chooseFolders chooseFolders = new chooseFolders();
                chooseFolders.ShowDialog();
            } else {    // Altrimenti se ha almeno una volta avviato ALiAS
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
