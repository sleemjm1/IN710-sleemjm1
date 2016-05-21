using DogSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogSelector.Controllers
{
    public class DogController : Controller
    {
        private List<Dog> allDogs;
        // GET: Dog
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(bool goodWithChildren, bool drools, ELength coatlength, 
            EScale activityLevel, EScale sheddingLevel,  EScale groomingLevel,
            EScale intelligenceLevel, ESize size)
        {
            Dog requestedDog = new Dog
            {
                GoodWithChildren = goodWithChildren,
                Drools = drools,
                Coatlength = coatlength,
                ActivityLevel = activityLevel,
                SheddingLevel = sheddingLevel,
                GroomingLevel = groomingLevel,
                IntelligenceLevel = intelligenceLevel,
                Size = size
            };
            Dog returnDog = findDogRecommendation(requestedDog);
            if (returnDog.BreedName != null)
                return View("DogRecommendation", returnDog);
            else
                return View("NoDogRecommendation");
        }

        public ActionResult DogRecommendation()
        {
            return View("Index");
        }


        // Display all dogs -- Just use to check list
        public ActionResult DisplayAll()
        {
            allDogs = makeDatabase();
            return View(allDogs);
        }

        // Return a Dog that is closest to the features of the requested dog
        private Dog findDogRecommendation(Dog requestedDog)
        {
            allDogs = makeDatabase();       // Fake Database

            Dog topDog = null;              // Dog instance that we will store our current best candidate in
            double topDogScore = 0;         // Score that this dog has - The current top score

            foreach (Dog dog in allDogs)
            {
                double dogScore = DogCompatibility(requestedDog, dog);  // Get dog compatibility score
                if (dogScore > topDogScore)                             // If we score higher than current top dog
                {
                    topDog = dog;                                       // We ar the top dog
                    topDogScore = dogScore;                             // And hold the new high score
                }
       
            }

            return topDog; 
        }

        private double DogCompatibility(Dog requestedDog, Dog dogFromList)
        {
            double returnValue = 0;

            // Dogs need to pass both boolean tests before being considered a match
            if (requestedDog.Drools == dogFromList.Drools && requestedDog.GoodWithChildren == dogFromList.GoodWithChildren)   
            {
                // Create a list to store the dog scores 
                // We will populate this list by using two methods to compute a score for each feature
                List<int> scores = new List<int>();

                // For the fields without a NoPreference Enum, we can just use calculateFeaturreCompatibility
                scores.Add(calculateFeatureCompatibility((int)dogFromList.Coatlength, (int)requestedDog.Coatlength));
                scores.Add(calculateFeatureCompatibility((int)dogFromList.Size, (int)requestedDog.Size));

                // With the fields using a NoPreference Enum, we need to use another method that will filter first
                scores.Add(calculateLevelFeatures((int)dogFromList.ActivityLevel, (int)requestedDog.ActivityLevel));
                scores.Add(calculateLevelFeatures((int)dogFromList.SheddingLevel, (int)requestedDog.SheddingLevel));
                scores.Add(calculateLevelFeatures((int)dogFromList.GroomingLevel, (int)requestedDog.GroomingLevel));
                scores.Add(calculateLevelFeatures((int)dogFromList.IntelligenceLevel, (int)requestedDog.IntelligenceLevel));

                // Because we use a list, we can use .Average()
                returnValue = scores.Average();
            }
            else
                returnValue = 0;    // If we don't pass boolean test, we're not compatible at all

            return returnValue;

        }

        // CalculateLevelFeatures is used only on features that have a NoPreference Enum
        private int calculateLevelFeatures(int ourFeature, int requestedFeature)
        {
            if (requestedFeature == 0)  // NoPreference is 0, check for that - Not sure how to compare to actual Enum
                return 10;              // If they have no preference for this feature, return 10
            else                        // Else we will pass our features through calculateFeatureCompatibility method
                return calculateFeatureCompatibility(ourFeature, requestedFeature);
        }

        // Returns value 0, 5 or 10 based on how compatible two ints are

        private int calculateFeatureCompatibility(int feature1, int feature2)
        {
            int returnValue = 0;
            int full = 0;
            int close = 1;

            int compatibilityScore = Math.Abs(feature1 - feature2);

            if (compatibilityScore == full)         // If we are fully compatible
                returnValue = 10;                   // Ten points for you
            else if (compatibilityScore > close)    // If we are outside the threshold
                returnValue = 0;                    // We get nothing
            else                                    // Otherwise we were close
                returnValue = 5;                    // So we get five points

            return returnValue;
        }


        // Patricia's Method -- will make a list to act as a database
        private List<Dog> makeDatabase()
        {
            List<Dog> newDatabase = new List<Dog>();

            Dog afghanHound = new Dog();
            afghanHound.BreedName = "afghanHound";
            afghanHound.DisplayName = "Afghan Hound";
            afghanHound.ActivityLevel = EScale.High;
            afghanHound.Coatlength = ELength.Long;
            afghanHound.Drools = false;
            afghanHound.GoodWithChildren = false;
            afghanHound.GroomingLevel = EScale.High;
            afghanHound.IntelligenceLevel = EScale.Low;
            afghanHound.SheddingLevel = EScale.High;
            afghanHound.Size = ESize.Large;
            afghanHound.ImageName = "AfghanHound.jpg";
            newDatabase.Add(afghanHound);


            Dog bassetHound = new Dog();
            bassetHound.BreedName = "BassetHound";
            bassetHound.DisplayName = "Basset Hound";
            bassetHound.ActivityLevel = EScale.Medium;
            bassetHound.Coatlength = ELength.Short;
            bassetHound.Drools = true;
            bassetHound.GoodWithChildren = true;
            bassetHound.GroomingLevel = EScale.Low;
            bassetHound.IntelligenceLevel = EScale.Medium;
            bassetHound.SheddingLevel = EScale.Low;
            bassetHound.Size = ESize.Medium;
            bassetHound.ImageName = "BassetHound.jpg";
            newDatabase.Add(bassetHound);

            Dog beagle = new Dog()
            {
                BreedName = "Beagle",
                DisplayName = "Beagle",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "Beagle.jpg"
            };
            newDatabase.Add(beagle);

            Dog bichonFrise = new Dog()
            {
                BreedName = "BichonFrise",
                DisplayName = "Bichon Frise",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Small,
                ImageName = "Bichonfrise.jpg"
            };
            newDatabase.Add(bichonFrise);



            Dog borzoi = new Dog()
            {
                BreedName = "Borzoi",
                DisplayName = "Borzoi",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "Borzoi.jpg"
            };
            newDatabase.Add(borzoi);

            Dog bulldog = new Dog()
            {
                BreedName = "Bulldog",
                DisplayName = "Bull Dog",
                ActivityLevel = EScale.Medium,
                Coatlength = ELength.Short,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "Bulldog.jpg"
            };
            newDatabase.Add(bulldog);


            Dog cav = new Dog()
            {
                BreedName = "CavalierKingCharlesSpaniel",
                DisplayName = "Cavalier King Charles Spaniel",
                ActivityLevel = EScale.Medium,
                Coatlength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "CavalierKingCharlesSpaniel.jpg"
            };
            newDatabase.Add(cav);


            Dog chowchow = new Dog()
            {
                BreedName = "Chowchow",
                DisplayName = "Chow Chow",
                ActivityLevel = EScale.Medium,
                Coatlength = ELength.Long,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "Chowchow.jpg"
            };
            newDatabase.Add(chowchow);

            Dog dalmation = new Dog()
            {
                BreedName = "Dalmation",
                DisplayName = "Dalmation",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Short,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Large,
                ImageName = "Dalmation.jpg"
            };
            newDatabase.Add(dalmation);

            Dog goldenRetriever = new Dog()
            {
                BreedName = "GoldenRetriever",
                DisplayName = "Golden Retriever",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "GoldenRetriever.jpg"
            };
            newDatabase.Add(goldenRetriever);

            Dog maltese = new Dog()
            {
                BreedName = "Maltese",
                DisplayName = "Maltese",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Miniature,
                ImageName = "Maltese.jpg"
            };
            newDatabase.Add(maltese);

            Dog newfoundland = new Dog()
            {
                BreedName = "Newfoundland",
                DisplayName = "Newfoundland",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "newfoundland.jpg"
            };
            newDatabase.Add(newfoundland);

            Dog oldEnglishSheepdog = new Dog()
            {
                BreedName = "OldEnglishSheepdog",
                DisplayName = "Old English Sheepdog",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "OldEnglishSheepdog.jpg"
            };
            newDatabase.Add(oldEnglishSheepdog);

            Dog pug = new Dog()
            {
                BreedName = "Pug",
                DisplayName = "Pug",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Low,
                SheddingLevel = EScale.Low,
                Size = ESize.Miniature,
                ImageName = "Pug.jpg"
            };
            newDatabase.Add(pug);


            Dog westHighlandWhiteTerrier = new Dog()
            {
                BreedName = "WestHighlandWhiteTerrier",
                DisplayName = "West Highland White Terrier",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "WestHighlandWhiteTerrier.jpg"
            };
            newDatabase.Add(westHighlandWhiteTerrier);

            return newDatabase;
        }
    }
}