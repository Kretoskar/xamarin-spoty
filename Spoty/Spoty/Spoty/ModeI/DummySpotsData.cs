using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Spoty.ModeI
{
    public class DummySpotsData
    {
        public List<Spot> Spots { get; set; }

        public DummySpotsData()
        {
            string json;
            using (var sr = new StreamReader("Model/spoty.json"))
            {
                json = sr.ReadToEnd();
            }
            Spots = JsonConvert.DeserializeObject<List<Spot>>(json);
        }

        public static void SetupDatabase()
        {
            if (!File.Exists(App.DatabasaLocation))
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
                {
                    DummySpotsData dummySpotsData = new DummySpotsData();
                    foreach (Spot spot in dummySpotsData.Spots)
                    {
                        conn.CreateTable<Spot>();
                        conn.Insert(spot);
                    }
                    string connstr = conn.ToString();
                }
            }
        }
        public static List<Spot> Read()
        {
            List<Spot> categorySpots = new List<Spot>();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
            {
                conn.CreateTable<Spot>();
                var spots = conn.Table<Spot>().ToList();
                foreach (Spot spot in spots)
                {
                    categorySpots.Add(spot);
                }
            }
            return categorySpots;
        }

        public static List<Spot> Read(SpotCategory category)
        {
            List<Spot> categorySpots = new List<Spot>();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
            {
                conn.CreateTable<Spot>();
                var spots = conn.Table<Spot>().ToList();
                foreach (Spot spot in spots)
                {
                    if (spot.Categories == category)
                        categorySpots.Add(spot);
                }
            }
            return categorySpots;
        }
    }
}