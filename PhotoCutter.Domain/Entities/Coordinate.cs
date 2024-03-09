using PhotoCutter.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Entities
{
    public class Coordinate: IEntity
    {
        private int _horizontalCoordinate;
        private int _verticalCoordinate;

        public int HorizontalCoordinate 
        {
            get 
            {
                return _horizontalCoordinate;
            }

            init
            {
                if (value < 0) value = -value;
                _horizontalCoordinate = value;
            }
        }

        public int VerticalCoordinate
        {
            get
            {
                return _verticalCoordinate;
            }

            init
            {
                if (value < 0) value = -value;
                _verticalCoordinate = value;
            }
        }


        public Coordinate(int horizontalCoordinate, int verticalCoordinate) 
        {
            HorizontalCoordinate = horizontalCoordinate;
            VerticalCoordinate = verticalCoordinate;
        }
    }
}
