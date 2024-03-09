using PhotoCutter.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Entities
{
    public class CutsList: IEntity
    {
        public List<Cut> Cuts { get; set; }
        public Photo BasePhoto { get; init; }
        private int HorizontalCount { get; set; }
        private int VerticalCount { get; set; }


        public CutsList(Photo basePhoto, int horizontalCount, int verticalCount) 
        {
            BasePhoto = basePhoto;
            HorizontalCount = horizontalCount;
            VerticalCount = verticalCount;
            Cuts = new List<Cut>(); 
            Fill(BasePhoto);

        }


        private void Fill(Photo basePhoto)
        {
            int verticalStep = basePhoto.Bitmap.Height / VerticalCount;
            int horizontalStep = basePhoto.Bitmap.Width / HorizontalCount;

            for (int i = 0; i < HorizontalCount; i++)
            {
                for (int j = 0; j < VerticalCount; j++)
                {
                    Rectangle rect = new Rectangle(new Point(i * horizontalStep, j * verticalStep), new Size(horizontalStep, verticalStep));
                    Bitmap crop = CropBitmap(basePhoto.Bitmap, rect);
                    Cut cut = new Cut(crop, new Coordinate(i * horizontalStep, j * verticalStep));
                    Cuts.Add(cut);
                }
            }
        }

        private Bitmap CropBitmap(Bitmap src, Rectangle rect)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height); //создаем битмап

            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(src, 0, 0, rect, GraphicsUnit.Pixel); //перерисовываем с источника по координатам

            return bmp;
        }
    }
}
