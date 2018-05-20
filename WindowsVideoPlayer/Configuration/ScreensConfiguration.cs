
using System.Collections.Generic;
using System.Security.AccessControl;

namespace VideoPlayer
{
    public class ScreensConfiguration
    {
        public int MainWindowTop { get; set; }
        public int MainWindowLeft { get; set; }
        public int MainWindowWidth { get; set; }
        public int MainWindowHeight { get; set; }
        public bool ShowControls { get; set; }

        public ScreenConfiguration[] Screens { get; set; }
    }

    public class ScreenConfiguration
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ID { get; set; }
        public string VideoFilePath { get; set; }
        public bool PlaySound { get; set; }

    }
}