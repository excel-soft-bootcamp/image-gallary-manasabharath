using System;

namespace ImageGalleryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery _Gallery = new ImageGallery( _mailAccount);
            _Gallery.Share();

            Bluetooth _blueToothDevice = new Bluetooth();
            ImageGallery _Gallerybluetooth = new ImageGallery(_blueToothDevice);
            _Gallerybluetooth.Share();

            WhatsUp _messanger = new WhatsUp();
            ImageGallery _GalleryWatsUp = new ImageGallery(_messanger);
            _GalleryWatsUp.Share();
        }
    }
}
