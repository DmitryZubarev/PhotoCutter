using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Abstract
{
    public interface IPhoto: IEntity
    {
        public Bitmap Bitmap { get; }
    }
}
