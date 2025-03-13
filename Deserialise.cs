using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace InterviewTestQA
{
    // Define the JSONTest class that matches the structure of the JSON data
    public class JSONTest
    {
        public string YearId { get; set; }
        public int GeoRegionId { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        public int SchemeId { get; set; }
        public int SchmTypeId { get; set; }
        public double Cost { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // JSON array string (as provided)
            string jsonArray = "[ { \"YearId\": \"2015\", \"GeoRegionId\": 0, \"CountryId\": 0, \"RegionId\": 0, \"SchemeId\": 40, \"SchmTypeId\": 1, \"Cost\": 0.0000000 }, { \"YearId\": \"2015\", \"GeoRegionId\": 0, \"CountryId\": 0, \"RegionId\": 0, \"SchemeId\": 43, \"SchmTypeId\": 1, \"Cost\": 0.0000000 }, { \"YearId\": \"2015\", \"GeoRegionId\": 150, \"CountryId\": 40, \"RegionId\": 0, \"SchemeId\": 4, \"SchmTypeId\": 1, \"Cost\": 2229.4381180 }, { \"YearId\": \"2015\", \"GeoRegionId\": 150, \"CountryId\": 100, \"RegionId\": 0, \"SchemeId\": 40, \"SchmTypeId\": 1, \"Cost\": 0.0 }, { \"YearId\": \"2015\", \"GeoRegionId\": 150, \"CountryId\": 233, \"RegionId\": 0, \"SchemeId\": 43, \"SchmTypeId\": 1, \"Cost\": 0.0 }, { \"YearId\": \"2015\", \"GeoRegionId\": 150, \"CountryId\": 276, \"RegionId\": 0, \"SchemeId\": 10, \"SchmTypeId\": 1, \"Cost\": 7326.7167085 }, { \"YearId\": \"2015\", \"GeoRegionId\": 150, \"CountryId\": 276, \"RegionId\": 0, \"SchemeId\": 30, \"SchmTypeId\": 1, \"Cost\": 363.2831627 }, { \"YearId\": \"2015\", \"GeoRegionId\": 150, \"CountryId\": 276, \"RegionId\": 0, \"SchemeId\": 116, \"SchmTypeId\": 1, \"Cost\": 7877.8909096 }, { \"YearId\": \"2015\", \"GeoRegionId\": 150, \"CountryId\": 642, \"RegionId\": 0, \"SchemeId\": 41, \"SchmTypeId\": 1, \"Cost\": 230.4874592 }, { \"YearId\": \"2016\", \"GeoRegionId\": 0, \"CountryId\": 0, \"RegionId\": 0, \"SchemeId\": 8, \"SchmTypeId\": 1, \"Cost\": 69437.0683739 }]";

            // Deserialize the JSON array to a list of JSONTest objects
            List<JSONTest> jSONTest = JsonConvert.DeserializeObject<List<JSONTest>>(jsonArray);

            // Output the deserialized objects
            foreach (var schemeCost in jSONTest)
            {
                Console.WriteLine($"YearId: {schemeCost.YearId}, GeoRegionId: {schemeCost.GeoRegionId}, CountryId: {schemeCost.CountryId}, RegionId: {schemeCost.RegionId}, SchemeId: {schemeCost.SchemeId}, SchmTypeId: {schemeCost.SchmTypeId}, Cost: {schemeCost.Cost}");
            }
        }
    }
}
