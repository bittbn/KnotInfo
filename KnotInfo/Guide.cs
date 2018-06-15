using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace KnotInfo
{
    public partial class Guide : Form
    {
        private int _knotID;
        private string _knotName;
        private string _guideComment;
        private Binary _guideBinary;

        public Guide(int knotId)
        {
            InitializeComponent();
            _knotID = knotId;
        }

        private void Guide_Load(object sender, EventArgs e)
        {
            pictureBoxGuide.SizeMode = PictureBoxSizeMode.StretchImage;
            StructGuide structGuide = DataMethods.GetGuide(_knotID);
            pictureBoxGuide.Image = ImageMethods.BinaryToImage(structGuide.guideBinary);
            richTextBoxGuide.Text = structGuide.guideComment;
            structGuide.guideBinary = _guideBinary;
        }
    }
}
