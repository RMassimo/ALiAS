using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alias
{
    public partial class frmSettings : Form
    {

        //  *** VARIABILI ***

        public int height = 107;
        public int width = 230;

        // *** CODICE ***

        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCheckResolution_Click(object sender, EventArgs e)
        {
            // Se e' checkato il radio button della larghezza
            if (rdbWidth.Checked) {
                // Calcola altezza
                height = (int)nudGameLogoWidth.Value * 107 / 230;
                // Controllo i vari parametri
                if (height > nudGameLogoHeight.Maximum)
                    nudGameLogoHeight.Value = nudGameLogoHeight.Maximum;
                else if (height < nudGameLogoHeight.Minimum)
                    nudGameLogoHeight.Value = nudGameLogoHeight.Minimum;
                else
                    nudGameLogoHeight.Value = height;
            } else if (rdbHeight.Checked) {
                // Calcola larghezza
                width  = (int)nudGameLogoHeight.Value * 230 / 107;
                // Controllo gli altri parametri
                if (width > nudGameLogoWidth.Maximum)
                    nudGameLogoWidth.Value = nudGameLogoWidth.Maximum;
                else if (width < nudGameLogoWidth.Minimum)
                    nudGameLogoWidth.Value = nudGameLogoWidth.Minimum;
                else
                    nudGameLogoWidth.Value = width;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Collego alla mainForm
            frmMain MainForm = new frmMain();
            // Teoricamente dovrebbe aumentare o diminuire la dimensione delle picturebox
            foreach(PictureBox GameLogo in MainForm.flpGames.Controls)
            {
                GameLogo.Width = (int)nudGameLogoWidth.Value;
                GameLogo.Height = (int)nudGameLogoHeight.Value;
            }
            // [BUG] NON FUNZIONA NULLA - RMassimo
        }
    }
}
