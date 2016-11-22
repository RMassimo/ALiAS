using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alias
{
    public partial class frmChooseFolders : Form
    {

        //  *** VARIABILI ***

        public string root = "C:/ProgramData/Hydra-Studio/Alias/";

        //  *** CODICE ***

        public frmChooseFolders()
        {
            InitializeComponent();
        }

        private void btnFolder1_Click(object sender, EventArgs e)
        {
            // Faccio scegliere all utente la cartella "steamapps"
            DialogResult r = folder1.ShowDialog();
            // Non appena fa click su OK
            if(r==DialogResult.OK)
            {
                // Prima di tutto controlla se la cartella e' corretta
                string folder = folder1.SelectedPath;
                if (folder.EndsWith("steamapps"))   // Se finisce con "steamapps"
                {
                    lblFolder1.Text = folder;
                    btnFolder2.Enabled = true;
                } else {    // Se non finisce con "steamapps"
                    MessageBox.Show("The selected folder is not correct!\nIs this a bug? Contact randon.massimo999@gmail.com", "Error");
                    btnFolder2.Enabled = false;
                    btnFolder3.Enabled = false;
                }
            }
        }

        private void btnFolder2_Click(object sender, EventArgs e)
        {
            // Faccio scegliere all utente la cartella "steamapps"
            DialogResult r = folder2.ShowDialog();
            // Non appena fa click su OK
            if (r == DialogResult.OK)
            {
                // Prima di tutto controlla se la cartella e' corretta
                string folder = folder2.SelectedPath;
                if (folder.EndsWith("steamapps"))   // Se finisce con "steamapps"
                {
                    lblFolder2.Text = folder;
                    btnFolder3.Enabled = true;
                }
                else
                {    // Se non finisce con "steamapps"
                    MessageBox.Show("The selected folder is not correct!\nIs this a bug? Contact randon.massimo999@gmail.com", "Error");
                    btnFolder3.Enabled = false;
                }
            }
        }

        private void btnFolder3_Click(object sender, EventArgs e)
        {
            // Faccio scegliere all utente la cartella "steamapps"
            DialogResult r = folder3.ShowDialog();
            // Non appena fa click su OK
            if (r == DialogResult.OK)
            {
                // Prima di tutto controlla se la cartella e' corretta
                string folder = folder3.SelectedPath;
                if (folder.EndsWith("steamapps"))   // Se finisce con "steamapps"
                {
                    lblFolder3.Text = folder;
                }
                else
                {    // Se non finisce con "steamapps"
                    MessageBox.Show("The selected folder is not correct!\nIs this a bug? Contact randon.massimo999@gmail.com", "Error");
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (lblFolder1.Text != "")  // Se seleziona almeno una cartella
            {
                // Crea la cartella per l' utente
                System.IO.Directory.CreateDirectory(root);
                // Scrivo tre linee vuote per evitare bug
                using (StreamWriter sw = File.CreateText(root + "path.usr"))
                {
                    sw.WriteLine(lblFolder1.Text);
                    sw.WriteLine(lblFolder2.Text);
                    sw.WriteLine(lblFolder3.Text);
                }
                MessageBox.Show("Ok then!");
            } else {    // Se non seleziona nessuna cartella
                MessageBox.Show("The selected folders are not correct!\nIs this a bug? Contact randon.massimo999@gmail.com", "Error");
            }
        }
    }
}
