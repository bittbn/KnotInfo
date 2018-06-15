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
    public partial class KnotEdit : Form
    {
        private bool _update;
        private int _knotId;
        private string _typeName;
        private string _knotName;
        private string _knotComment;
        private string _guideComment;
        private Binary _knotBinary;
        private Binary _guideBinary;

        public KnotEdit()
        {
            InitializeComponent();
            _update = false;
        }

        public KnotEdit(int knotId)
        {
            InitializeComponent();
            _update = true;
            _knotId = knotId;
            StructGuideKnot structGuideKnot = DataMethods.GetKnot(_knotId);
            _knotName = structGuideKnot.knotName;
            _knotComment = structGuideKnot.knotComment;
            _guideComment = structGuideKnot.guideComment;
            _knotBinary = structGuideKnot.knotBinary;
            _guideBinary = structGuideKnot.guideBinary;
            _typeName = structGuideKnot.typeName;
        }

        private void FillForms()
        {
            comboBoxTypes.DataSource = DataMethods.GetTypes();
            comboBoxTypes.DisplayMember = "name";
            comboBoxTypes.ValueMember = "id";

            if (_update == true)
            {
                Text = "Изменение";
                buttonEdit.Text = "Изменить";
                textBoxName.Text = _knotName;
                comboBoxTypes.Text = _typeName;
                richTextBoxKnot.Text = _knotComment;
                richTextBoxGuide.Text = _guideComment;
                pictureBoxKnot.Image = ImageMethods.BinaryToImage(_knotBinary);
                pictureBoxGuide.Image = ImageMethods.BinaryToImage(_guideBinary);
            }
            else
            {
                Text = "Добавление";
                buttonEdit.Text = "Добавить";
                CleanerForms();
            }
        }

        private void CleanerForms()
        {
            textBoxName.Text = "";
            richTextBoxKnot.Text = "";
            richTextBoxGuide.Text = "";
            pictureBoxKnot.Image = null;
            pictureBoxGuide.Image = null;
            _knotBinary = null;
            _guideBinary = null;
        }

        private Binary GetBinary(PictureBox pictureBox, Binary binary)
        {
            Image image = ImageMethods.GetDirectoryImage();
            pictureBox.Image = image;
            return image != null ? binary = ImageMethods.ImageToBinary(image) : null;
        }

        private void AddTypes_Load(object sender, EventArgs e)
        {
            pictureBoxKnot.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGuide.SizeMode = PictureBoxSizeMode.StretchImage;
            FillForms();
        }

        private void buttonKnotImage_Click(object sender, EventArgs e)
        {
            _knotBinary = GetBinary(pictureBoxKnot, _knotBinary);
        }

        private void buttonGuideImage_Click(object sender, EventArgs e)
        {
            _guideBinary = GetBinary(pictureBoxGuide, _guideBinary);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && pictureBoxKnot.Image!=null && comboBoxTypes.Text != "")
            {
                if (_update == true)
                {
                    DataMethods.UpdateKnot(_knotId, textBoxName.Text, richTextBoxKnot.Text, _knotBinary, richTextBoxGuide.Text, _guideBinary, (int)comboBoxTypes.SelectedValue);
                }
                else
                {
                    DataMethods.InsertKnot(textBoxName.Text, richTextBoxKnot.Text, _knotBinary, richTextBoxGuide.Text, _guideBinary, (int)comboBoxTypes.SelectedValue);
                    FillForms();
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить *обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
