using System;
using System.Collections.Generic;
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
    /// Interaction logic for VideoWindow.xaml
    /// </summary>
    public partial class VideoWindow : UserControl
    {
        private string _filePath;
        public VideoWindow(ScreenConfiguration screenConfiguration, bool showControls)
        {
            InitializeComponent();
            Width = screenConfiguration.Width;
            Height = screenConfiguration.Height;
            Video.Width = screenConfiguration.Width;
            Video.Height = screenConfiguration.Height;
            Name = screenConfiguration.ID;

            if (!showControls)
            {
                Controls.Visibility = Visibility.Hidden;
            }

            FilePath.Text = screenConfiguration.VideoFilePath;
            Video.Source = new Uri(FilePath.Text);
            Video.IsMuted = !screenConfiguration.PlaySound;
        }

        private void PlayButton_OnClick(object sender, RoutedEventArgs e)
        {
            Video.Visibility = Visibility.Visible;
            Video.Play();
        }

        private void StopButton_OnClick(object sender, RoutedEventArgs e)
        {
            Video.Stop();
            Video.Visibility = Visibility.Hidden;
        }

        private void LoadButton_OnClick(object sender, RoutedEventArgs e)
        {
            Video.Source = new Uri(_filePath = FilePath.Text);
        }

    }
}
