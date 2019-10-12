using System;
using System.Collections.Generic;
using System.Text;

namespace Spoty.ModeI
{
    class Spot
    {
        private string name;
        private List<SpotCategory> categories;
        private string slug;
        private string shortDesc;
        private string longDesc;
        private float latitude;
        private float longitude;

        public Spot(string name, List<SpotCategory> categories, string slug, string shortDesc, string longDesc, float latitude, float longitude)
        {
            this.Name = name;
            this.Categories = categories;
            this.Slug = slug;
            this.ShortDesc = shortDesc;
            this.LongDesc = longDesc;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public string Name { get => name; set => name = value; }
        public string Slug { get => slug; set => slug = value; }
        public string ShortDesc { get => shortDesc; set => shortDesc = value; }
        public string LongDesc { get => longDesc; set => longDesc = value; }
        public float Latitude { get => latitude; set => latitude = value; }
        public float Longitude { get => longitude; set => longitude = value; }
        internal List<SpotCategory> Categories { get => categories; set => categories = value; }
    }

    enum SpotCategory
    {
        Gaps,
        Ledges,
        Rails,
        Others
    }
}
