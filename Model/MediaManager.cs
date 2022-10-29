using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Capture;

namespace music.Model
{
    internal static class MediaManager
    {
        public static void GetAllMedia(ObservableCollection<Media> media)
        {
            var allMedia = getMedias();
            media.Clear();
            allMedia.ForEach(sound => media.Add(sound));

        }
        public static void GetAllMediaByCategory(ObservableCollection<Media> media ,MusicCategory category)
        {

            var allMedia= getMedias();
            media.Clear();
            var filteredSounds = allMedia.Where(sound=>sound.Category==category).ToList();
            filteredSounds.ForEach(sound => media.Add(sound));
        }
        private static List<Media> getMedias()
        {
            var media = new List<Media>();
            media.Add(new Media("flute", MusicCategory.Instruments));
            media.Add(new Media("daysofweek", MusicCategory.Kids));
            //media.Add(new Media("flute.png", MusicCategory.instrument));
            // media.Add(new Media("flute.png", MusicCategory.instrument));
            return media;
        }
    }
}
