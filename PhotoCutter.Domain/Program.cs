using PhotoCutter.Domain.Entities;
using PhotoCutter.Domain.Services;
using System.Drawing;

///Качается фотка в спец папку. Нам известен путь к изображению.
///Сервис разрезает Изображение и создаёт объект типа CutsList:
///1. Получает поток байтов из сохраненного Изображения, создаёт объект Photo
///2. Режет изображение:
///2.1. Получает объект Cut, добавляет координаты к фото.
///2.2. Добавить в CutsList
///2.3. Повторить пока не получит все разрезы.
///2.4. Вернуть CutsList
///
///Сервис имеет своего Художника, PhotoContainer и единственный метод Cut, который получает на вход Photo и выдаёт CutsList
///Photo имеет массив байт. Создаётся с помощью путя к изображению. +++
///CutsList имеет список из Cut, родителя кусков Photo и метод Add()
///Cut имеет набор байт, координаты и идентификатор
///Artist имеет метод ArtCoordinates(), который принимает объект Cut
///
var service1 = new DownloaderService("C:\\dev\\projects\\CSharp\\PhotoCutter\\PhotoCutter.Domain\\pictures\\");
var service2 = new PhotoService();
Bitmap bmp = service1.LoadPicture(new Uri("https://cameralabs.org/media/k2/items/cache/56e156ae7a9fb41309794613e883bfc0_L.jpg"));
Photo savedPhoto = new Photo(bmp);
CutsList list = service2.CutPhoto(savedPhoto, 3, 2);
int i = 0;
foreach (var item in list.Cuts)
{
    item.Bitmap.Save($"C:\\dev\\projects\\CSharp\\PhotoCutter\\PhotoCutter.Domain\\pictures\\pic{i}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
    i++;
}