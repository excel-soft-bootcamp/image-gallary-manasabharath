using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryApp
{
    public class WhatsUp : IShare
    {
        public void Send()
        {
            Console.WriteLine("watsup");
        }
    }
}
