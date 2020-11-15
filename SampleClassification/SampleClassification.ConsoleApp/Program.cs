//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleClassification.Model;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Rev_id = 666674800F,
                Comment = @"  ==He is a Rapist!!!!!== Please edit the article to include this important fact. Thank You.  — Preceding unsigned comment added by   •   ",
                Year = 2015F,
                Logged_in = @"True",
                Ns = @"article",
                Sample = @"blocked",
                Split = @"train",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
            Console.WriteLine($"Rev_id: {sampleData.Rev_id}");
            Console.WriteLine($"Comment: {sampleData.Comment}");
            Console.WriteLine($"Year: {sampleData.Year}");
            Console.WriteLine($"Logged_in: {sampleData.Logged_in}");
            Console.WriteLine($"Ns: {sampleData.Ns}");
            Console.WriteLine($"Sample: {sampleData.Sample}");
            Console.WriteLine($"Split: {sampleData.Split}");
            Console.WriteLine($"\n\nPredicted Label value {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
