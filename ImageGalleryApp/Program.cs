using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ImageGalleryApp
{
    static void Main(string[] args)
    {
        Gmail _mailAccount = new Gmail();
        ImageGallery _Gallery = new ImageGallery();
        _Gallery.Share(_mailAccount);

            Bluetooth _blueToothDevice = new Bluetooth();
        _Gallery.Share(_blueToothDevice);

            WhatsUp _messanger = new WhatsUp();
        _Gallery.Share(_messanger);        
    }
}
