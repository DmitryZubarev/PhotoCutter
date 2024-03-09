using PhotoCutter.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Entities
{
    public class Artist: IEntity
    {
        Font Font {  get; set; }
        SolidBrush Brush { get; set; }


        public Artist() 
        {
            Font = new Font("Arial", 13, FontStyle.Bold);
            Brush = new SolidBrush(Color.Blue);
        }
        public void SetCoordinates(CutsList cutsList)
        {
            foreach (var item in cutsList.Cuts) 
            {
                Bitmap currentBitmap = item.Bitmap;
                Graphics g = Graphics.FromImage(currentBitmap);
                g.DrawString($"{item.Coordinate.HorizontalCoordinate},{item.Coordinate.VerticalCoordinate}",
                    Font, Brush,
                    new RectangleF(0, 0, 0, 340),
                    new StringFormat(StringFormatFlags.NoWrap));
            }
        }
    }
}
