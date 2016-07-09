using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MusicPlayer
{
    public class WindowSettings
    {
        // Will be obsolete once we add more functionality to the bootstrapper

        public int Height { get; set; }

        public int Width { get; set; }

        public SizeToContent SizeToContent { get; set; }

        public WindowSettings(int height, int width, SizeToContent sizeToContent)
        {
            Height = height;
            Width = width;
            SizeToContent = sizeToContent;
        }

        public Dictionary<string, object> Get()
        {
            return new Dictionary<string, object>
            {
                    { "SizeToContent", SizeToContent },
                    { "Height" , Height  },
                    { "Width"  , Width },
            };
        }
    }
}
