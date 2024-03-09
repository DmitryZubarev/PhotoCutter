using PhotoCutter.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Entities
{
    public class Photo: IPhoto
    {
        public Bitmap Bitmap { get; init; }

        public Photo(Bitmap bitmap) 
        {
            Bitmap = bitmap;
        }
    }
}
