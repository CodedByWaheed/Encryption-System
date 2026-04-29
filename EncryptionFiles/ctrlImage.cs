using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionFiles
{
    public partial class ctrlImage: UserControl
    {
        string _ImageLocation;
        public string ImageLocation
        {
            get {  return _ImageLocation; }
        }
        public ctrlImage()
        {
            InitializeComponent();
        }
        public class PicturPoxEventArgs : EventArgs
        {
            string _ImageLocation;
            public string ImageLocation
            {
                get { return _ImageLocation; }
            }
            public PicturPoxEventArgs(string ImageLocation)
            {
                _ImageLocation = ImageLocation;
            }
        }

        public event EventHandler<PicturPoxEventArgs> DoupleClickOnPicturePox;
        public void OnDoupleClickOnPicturePox(string ImageLocation)
        {
            OnDoupleClickOnPicturePox(new PicturPoxEventArgs(_ImageLocation));
        }
        protected virtual void OnDoupleClickOnPicturePox(PicturPoxEventArgs e)
        {
            DoupleClickOnPicturePox?.Invoke(this, e);
        }
        public void Source(string Path)
        {
            _ImageLocation = Path;
            pbImage.ImageLocation = _ImageLocation;
        }

        private void pbImage_DoubleClick(object sender, EventArgs e)
        {
            OnDoupleClickOnPicturePox(_ImageLocation);
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }
}
