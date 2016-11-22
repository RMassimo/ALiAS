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
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCheckResolution_Click(object sender, EventArgs e)
        {
            if (rdbWidth.Checked) {
                int height = (int)nudGameLogoWidth.Value * 107 / 230;

                if (height > nudGameLogoHeight.Maximum)
                    nudGameLogoHeight.Value = nudGameLogoHeight.Maximum;
                else if (height < nudGameLogoHeight.Minimum)
                    nudGameLogoHeight.Value = nudGameLogoHeight.Minimum;
            } else if (rdbHeight.Checked) {
                int width  = (int)nudGameLogoHeight.Value * 230 / 107;

                if (width > nudGameLogoWidth.Maximum)
                    nudGameLogoWidth.Value = nudGameLogoWidth.Maximum;
                else if (width < nudGameLogoWidth.Minimum)
                    nudGameLogoWidth.Value = nudGameLogoWidth.Minimum;
            }
        }
    }
}
