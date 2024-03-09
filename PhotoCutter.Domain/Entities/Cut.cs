using PhotoCutter.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Entities
{
    public class Cut: IPhoto
    {
        public Bitmap Bitmap { get; set; }
        public Coordinate Coordinate { get; init; }

        public Cut(Bitmap bitmap, Coordinate coordinate)
        {
            Bitmap = bitmap;
            Coordinate = coordinate;
        }
    }
}
