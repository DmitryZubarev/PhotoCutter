using PhotoCutter.Domain.Abstract;
using PhotoCutter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Services
{
    public class PhotoService: IService
    {
        private Artist _artist;
        

        public PhotoService() 
        {
            _artist = new Artist();
        }

        public CutsList CutPhoto(Photo basePhoto, int horizontalCount, int verticalCount)
        {
            //разрезает
            CutsList cuts = new CutsList(basePhoto, horizontalCount, verticalCount);
            SetCoordinates(cuts);
            return cuts;
        }

        private void SetCoordinates(CutsList cutsList)
        {
            _artist.SetCoordinates(cutsList);
        }
    }
}
