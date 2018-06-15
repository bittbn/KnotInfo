using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace KnotInfo
{
    class ImageMethods
    {
        public static Image GetDirectoryImage()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файлы изображений (*.gif; *.jpg; *.png; *.bmp)|*.gif;*.jpg;*.png;*.bmp";
                openFileDialog.Multiselect = false;
                openFileDialog.ShowDialog();
                string path = openFileDialog.FileName;

                if (path != "")
                    return Image.FromFile(path);
                else
                    return null;
            }
        }

        public static Binary ImageToBinary(Image image)
        {
            using (var memoryStream = new MemoryStream())
            {
                Image resizeImage = ResizeImage(image);
                resizeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        public static Image BinaryToImage(Binary binary)
        {
            using (var memoryStream = new MemoryStream(binary.ToArray()))
            {
                return Image.FromStream(memoryStream);
            }
        }

        private static Image ResizeImage(Image image)
        {
            Image resizeImage = new Bitmap(1280, 720);

            using (Graphics graphics = Graphics.FromImage(resizeImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, 1280, 720);
                graphics.Dispose();
                return resizeImage;
            }
        }
    }
}
