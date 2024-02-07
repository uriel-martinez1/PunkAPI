﻿using System;
using System.Collections.Generic;

namespace Capstone.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime FirstBrewed { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public float Abv { get; set; }
        public float Ibu { get; set; }
        public float TargetFg { get; set; }
        public float TargetOg { get; set; }
        public float Ebc { get; set; }
        public float Srm { get; set; }
        public float Ph { get; set; }
        public float AttentionLevel { get; set; }
        public Measurement Volume { get; set; }
        public Measurement BoilVolume { get; set; }
        public Method Method { get; set; }
        public Ingredients Ingredients { get; set; }
        public List<string> FoodPairing { get; set; }
        public string BrewersTips { get; set; }
        public string ContributingBy { get; set; }
    }
}
