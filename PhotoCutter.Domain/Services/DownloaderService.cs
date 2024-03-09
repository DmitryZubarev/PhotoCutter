using PhotoCutter.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCutter.Domain.Services
{
    public class DownloaderService: IService
    {
        WebClient _client;

        string SavePath { get; set; }

        public DownloaderService(string savePath)
        {
            _client = new WebClient();
            SavePath = savePath;
        }

        public Bitmap LoadPicture(Uri uri)
        {
            _client.DownloadFile(uri, $"{SavePath}picture.jpg");
            Bitmap bmp = new Bitmap(Image.FromFile($"{SavePath}picture.jpg"));
            return bmp;
        }
    }
}
