using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VideoPlayer.Properties;

namespace VideoPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var screensConfiguration = Settings.Default.ScreensConfiguration;

            Top = screensConfiguration.MainWindowTop;
            Left = screensConfiguration.MainWindowLeft;
            Width = screensConfiguration.MainWindowWidth;
            Height = screensConfiguration.MainWindowHeight;

            foreach (var screen in screensConfiguration.Screens)
            {
                var videoWindow = new VideoWindow(screen, screensConfiguration.ShowControls);

                Canvas.SetTop(videoWindow, screen.Top);
                Canvas.SetLeft(videoWindow, screen.Left);

                MainCanvas.Children.Add(videoWindow);
            }
        }


    }
}
