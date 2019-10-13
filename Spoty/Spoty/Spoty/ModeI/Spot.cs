using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoty.ModeI
{
    public class Spot
    {
        private int id;
        private string name;
        private SpotCategory categories;
        private string slug;
        private string shortDesc;
        private string longDesc;
        private float latitude;
        private float longitude;

        [PrimaryKey, AutoIncrement]
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Slug { get => slug; set => slug = value; }
        public string ShortDesc { get => shortDesc; set => shortDesc = value; }
        public string LongDesc { get => longDesc; set => longDesc = value; }
        public float Latitude { get => latitude; set => latitude = value; }
        public float Longitude { get => longitude; set => longitude = value; }
        public SpotCategory Categories { get => categories; set => categories = value; }
    }

    public enum SpotCategory
    {
        Gaps,
        Ledges,
        Rails,
        Others
    }
}
