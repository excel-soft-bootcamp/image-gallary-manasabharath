using System;

namespace ImageGalleryApp
{
    public class ImageGallery
    {
        IShare share;
        public void Share(IShare share)
        {
            share.Send();

        }
    }
}

