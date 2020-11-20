using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverPhotoBrowser
{
    class RoverPhoto
    {
        public string Url { get; set; }
        public string Filename
        {
            get { return this.Url.Substring(this.Url.LastIndexOf("/") + 1); }
        }
    }
}
