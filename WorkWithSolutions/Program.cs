using CrmEarlyBound;
using System;
using WorkWithSolutions.Services;

namespace WorkWithSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisherService = new PublisherService();
            var solutionService = new SolutionService();
            var entityService = new EntityService();

            Console.WriteLine($"Default publisher: {publisherService.RetrieveTheDefaultPublisher().FriendlyName}");

            var solution = solutionService.RetrieveSolution("samplesolution");
            Console.WriteLine($"{solution.FriendlyName} - {solution.Id}");

            publisherService.CreatePublisher();
            solutionService.CreateSolution("samplesolution", "Sample Solution");

            solutionService.DeleteSolution("samplesolution");
            solutionService.CreateSolution("samplesolution", "Sample Solution");

            entityService.AddExistingEntity(new_order.EntityLogicalName, true, false);
            entityService.AddExistingEntity(new_order.EntityLogicalName, false, true);

            entityService.AddNewOptionSet();

            Console.WriteLine("Press to exit..");
            Console.ReadKey();
        }
    }
}
