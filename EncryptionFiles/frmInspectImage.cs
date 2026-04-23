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
    public partial class frmInspectImage: Form
    {
       
        public frmInspectImage(string Path)
        {
            InitializeComponent();
            pbImage.ImageLocation = Path;
        }

         
    }
}
