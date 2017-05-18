using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ResizeImage
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Drawing.Image image;
            int newwidthimg = 200;
            float AspectRatio = (float)image.Size.Width / (float)image.Size.Height;
            int newHeight = 200;
            Bitmap bitMAP1 = new Bitmap(newwidthimg, newHeight);
            Graphics imgGraph = Graphics.FromImage(bitMAP1);
            bitMAP1.
            bitMAP1.imgQuality = CompositingQuality.HighQuality;
            bitMAP1.SmoothingMode = SmoothingMode.HighQuality;
            bitMAP1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imgDimesions = new Rectangle(0, 0, newwidthimg, newHeight);
            bitMAP1.DrawImage(image, imageRectangle);
            bitMAP1.Save(Server.MapPath("images/Shops/" + fileupload1.filename), ImageFormat.Jpeg);
            bitMAP1.Dispose();
            bitMAP1.Dispose();
            image.Dispose();

            if (System.IO.File.Exists(Server.MapPath("images/tempImage/" + fileupload1.FileName)))
            {
                System.IO.File.Delete(Server.MapPath("images/tempImage/" + fileupload1.FileName));
            }
        }
    }
}
