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

//изменение, гайды, проверка пустоты полей
//вопросы: получение id, одна форма для вставки/изменения, получение коллекции из запроса, 
namespace KnotInfo
{
    public partial class Main : Form
    {
        private int _knotId;
        private Image _knotImage;
        private Binary _knotBinary;
        private string _knotName;
        private string _knotComment;
        private string _typeName;

        public Main()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dataGridViewKnots.DataSource = DataMethods.GetKnots();
        }

        private void FillForms(Binary knotBinary, string knotComment)
        {
            pictureBoxKnot.Image = knotBinary != null ? _knotImage = ImageMethods.BinaryToImage(knotBinary) : null;
            richTextBoxComment.Text = knotComment;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshTable();
            pictureBoxKnot.SizeMode = PictureBoxSizeMode.StretchImage;

            dataGridViewKnots.Columns[0].Visible = false;
            dataGridViewKnots.Columns[1].Visible = false;
        }

        private void buttonAddTypes_Click(object sender, EventArgs e)
        {
            (new KnotEdit()).ShowDialog();
        }

        private void dataGridViewKnots_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _knotId = (int)dataGridViewKnots.Rows[e.RowIndex].Cells[0].Value;
            _knotBinary = (Binary)dataGridViewKnots.Rows[e.RowIndex].Cells[1].Value;
            _knotName = (string)dataGridViewKnots.Rows[e.RowIndex].Cells[2].Value;
            _knotComment = (string)dataGridViewKnots.Rows[e.RowIndex].Cells[3].Value;
            _typeName = (string)dataGridViewKnots.Rows[e.RowIndex].Cells[4].Value;

            FillForms(_knotBinary, _knotComment);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно желаете удалить узел <" + _knotName + ">", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataMethods.DeleteKnot(_knotId);
                RefreshTable();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void addKnotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new KnotEdit()).ShowDialog();
            RefreshTable();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new KnotEdit(_knotId)).ShowDialog();
            RefreshTable();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewKnots.DataSource = DataMethods.SearchKnots(textBoxSearch.Text);
        }

        private void dataGridViewKnots_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            (new Guide(_knotId)).ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataMethods.DisposeDB();
        }
    }
}
