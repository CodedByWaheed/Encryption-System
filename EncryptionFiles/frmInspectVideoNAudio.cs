using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionFiles
{
    public partial class frmInspectVideoNAudio: Form
    {
       
       
        public frmInspectVideoNAudio(string Path)
        {
            InitializeComponent();
          
            RunPath(Path);
        }
        private void RunPath(string Path)
        {
            axWindowsMediaPlayer1.URL = Path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.stretchToFit = true;
        }

     

        
    }
}
