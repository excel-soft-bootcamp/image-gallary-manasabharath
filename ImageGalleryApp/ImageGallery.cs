using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryApp
{
    public class ImageGallery
    {
        IShare _share;

        public ImageGallery(IShare share)
        {
            this._share = share;
        }


        public void Share()
        {
            _share.Send();

        }
    }
}
