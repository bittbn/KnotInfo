namespace KnotInfo
{
    partial class KnotEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxKnot = new System.Windows.Forms.RichTextBox();
            this.pictureBoxKnot = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.buttonKnotImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxKnot = new System.Windows.Forms.GroupBox();
            this.groupBoxGuide = new System.Windows.Forms.GroupBox();
            this.richTextBoxGuide = new System.Windows.Forms.RichTextBox();
            this.pictureBoxGuide = new System.Windows.Forms.PictureBox();
            this.buttonGuideImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnot)).BeginInit();
            this.groupBoxKnot.SuspendLayout();
            this.groupBoxGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxKnot
            // 
            this.richTextBoxKnot.Location = new System.Drawing.Point(212, 88);
            this.richTextBoxKnot.MaxLength = 250;
            this.richTextBoxKnot.Name = "richTextBoxKnot";
            this.richTextBoxKnot.Size = new System.Drawing.Size(342, 110);
            this.richTextBoxKnot.TabIndex = 5;
            this.richTextBoxKnot.Text = "";
            // 
            // pictureBoxKnot
            // 
            this.pictureBoxKnot.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxKnot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKnot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKnot.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxKnot.Name = "pictureBoxKnot";
            this.pictureBoxKnot.Size = new System.Drawing.Size(200, 150);
            this.pictureBoxKnot.TabIndex = 2;
            this.pictureBoxKnot.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(278, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(276, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(278, 45);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(276, 21);
            this.comboBoxTypes.TabIndex = 3;
            // 
            // buttonKnotImage
            // 
            this.buttonKnotImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonKnotImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKnotImage.Location = new System.Drawing.Point(6, 175);
            this.buttonKnotImage.Name = "buttonKnotImage";
            this.buttonKnotImage.Size = new System.Drawing.Size(200, 23);
            this.buttonKnotImage.TabIndex = 6;
            this.buttonKnotImage.Text = "*Выбрать изображение";
            this.buttonKnotImage.UseVisualStyleBackColor = false;
            this.buttonKnotImage.Click += new System.EventHandler(this.buttonKnotImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "*Тип:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(366, 476);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Действие";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBoxKnot
            // 
            this.groupBoxKnot.Controls.Add(this.richTextBoxKnot);
            this.groupBoxKnot.Controls.Add(this.pictureBoxKnot);
            this.groupBoxKnot.Controls.Add(this.buttonKnotImage);
            this.groupBoxKnot.Controls.Add(this.label3);
            this.groupBoxKnot.Controls.Add(this.label4);
            this.groupBoxKnot.Controls.Add(this.label1);
            this.groupBoxKnot.Controls.Add(this.comboBoxTypes);
            this.groupBoxKnot.Controls.Add(this.textBoxName);
            this.groupBoxKnot.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKnot.Name = "groupBoxKnot";
            this.groupBoxKnot.Size = new System.Drawing.Size(560, 220);
            this.groupBoxKnot.TabIndex = 10;
            this.groupBoxKnot.TabStop = false;
            this.groupBoxKnot.Text = "Узел";
            // 
            // groupBoxGuide
            // 
            this.groupBoxGuide.Controls.Add(this.richTextBoxGuide);
            this.groupBoxGuide.Controls.Add(this.pictureBoxGuide);
            this.groupBoxGuide.Controls.Add(this.buttonGuideImage);
            this.groupBoxGuide.Controls.Add(this.label2);
            this.groupBoxGuide.Location = new System.Drawing.Point(12, 238);
            this.groupBoxGuide.Name = "groupBoxGuide";
            this.groupBoxGuide.Size = new System.Drawing.Size(560, 220);
            this.groupBoxGuide.TabIndex = 15;
            this.groupBoxGuide.TabStop = false;
            this.groupBoxGuide.Text = "Руководство";
            // 
            // richTextBoxGuide
            // 
            this.richTextBoxGuide.Location = new System.Drawing.Point(212, 35);
            this.richTextBoxGuide.MaxLength = 1024;
            this.richTextBoxGuide.Name = "richTextBoxGuide";
            this.richTextBoxGuide.Size = new System.Drawing.Size(342, 163);
            this.richTextBoxGuide.TabIndex = 9;
            this.richTextBoxGuide.Text = "";
            // 
            // pictureBoxGuide
            // 
            this.pictureBoxGuide.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGuide.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxGuide.Name = "pictureBoxGuide";
            this.pictureBoxGuide.Size = new System.Drawing.Size(200, 150);
            this.pictureBoxGuide.TabIndex = 7;
            this.pictureBoxGuide.TabStop = false;
            // 
            // buttonGuideImage
            // 
            this.buttonGuideImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonGuideImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuideImage.Location = new System.Drawing.Point(6, 175);
            this.buttonGuideImage.Name = "buttonGuideImage";
            this.buttonGuideImage.Size = new System.Drawing.Size(200, 23);
            this.buttonGuideImage.TabIndex = 10;
            this.buttonGuideImage.Text = "Выбрать изображение";
            this.buttonGuideImage.UseVisualStyleBackColor = false;
            this.buttonGuideImage.Click += new System.EventHandler(this.buttonGuideImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Описание:";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(472, 476);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 23);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(9, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "*Обязательные к заполнению поля";
            // 
            // KnotEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxGuide);
            this.Controls.Add(this.groupBoxKnot);
            this.Controls.Add(this.buttonEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KnotEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Действие над узлом";
            this.Load += new System.EventHandler(this.AddTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnot)).EndInit();
            this.groupBoxKnot.ResumeLayout(false);
            this.groupBoxKnot.PerformLayout();
            this.groupBoxGuide.ResumeLayout(false);
            this.groupBoxGuide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxKnot;
        private System.Windows.Forms.PictureBox pictureBoxKnot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Button buttonKnotImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBoxKnot;
        private System.Windows.Forms.GroupBox groupBoxGuide;
        private System.Windows.Forms.RichTextBox richTextBoxGuide;
        private System.Windows.Forms.PictureBox pictureBoxGuide;
        private System.Windows.Forms.Button buttonGuideImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label5;
    }
}