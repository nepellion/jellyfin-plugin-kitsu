using System;

namespace Jellyfin.Plugin.Kitsu.Providers.KitsuIO.ApiClient.Models
{
    public class KitsuSeriesAttributes
    {
        public string Synopsis { get; set; }
        public KitsuTitles Titles { get; set; }
        public string AverageRating { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public KitsuImage PosterImage { get; set; }
        public KitsuImage CoverImage { get; set; }
    }
}
