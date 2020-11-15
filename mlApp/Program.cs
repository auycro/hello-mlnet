using System;
using System.IO;
using SampleClassification.Model;

namespace mlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            input.Comment = "This is heaven";

            // Load model and predict output of sample data
            string path = @"../SampleClassification/SampleClassification.Model/MLModel.zip";
            ConsumeModel.MLNetModelPath = Path.GetFullPath(path);
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.Comment}\nIs Toxic: {result.Prediction}");
        }
    }
}
