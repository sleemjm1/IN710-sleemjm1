using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector.Models
{
    public enum EScale { NoPreference, Low, Medium, High };
    public enum ELength { Short, Medium, Long };
    public enum ESize { Miniature, Small, Medium, Large, Giant };
   
    public class Dog
    {
        // Personal Info
        public string BreedName { get; set; }
        public string DisplayName { get; set; }
        public string ImageName { get; set; }


        // High priority Qualities
        public bool GoodWithChildren { get; set; }
        public bool Drools { get; set; }
        
        // Other Qualities
        public EScale ActivityLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public ELength Coatlength { get; set; }
        public ESize Size { get; set; }

    }
}