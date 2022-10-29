
using music.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace music
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page 
    {
        private ObservableCollection<Media> media;

        public MainPage()
        {
            this.InitializeComponent();
          // player = new MediaPlayer();
          media=new ObservableCollection<Media>();
            MediaManager.GetAllMedia(media);
        }

        private void MusicGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
          var music= (Media) e.ClickedItem;


            SoundMedia.Source = new Uri(this.BaseUri, music.MediaFile);

        }

       


        // private void OpenFile_Click(object sender, RoutedEventArgs e)
        //{

        // MediaPlayer player = new MediaPlayer();
        //player.Source=MediaSource. CreateFromUri(new Uri(@"C: \Users\srava\source\repos\Kalclasses\music\Assets\MusicFile\maa.mp3"));
        //CreateFromUri(new Uri("ms-appx:////Assets/MusicFile//mantra.mp3"));
        // player.Source = new Uri(data: "ms-appx:////Assets/MusicFile//mantra.mp3"));
        // media.Play();
        // media.Dispose();
        //player.Play();
        //player.Dispose();



        // }


    }
}
