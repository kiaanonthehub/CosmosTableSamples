using System;

namespace CosmosTableSamples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Azure Cosmos Table Samples");
            BasicSamples basicSamples = new BasicSamples();
            basicSamples.RunSamples().Wait();

            //AdvancedSamples advancedSamples = new AdvancedSamples();
            //advancedSamples.RunSamples().Wait();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}

/*
 * ICE 2: Microsoft documentation
 * Source code available at : https://docs.microsoft.com/en-us/azure/cosmos-db/table/tutorial-develop-table-dotnet
 * 
 * Extensions (PMC): 
 *Install-Package Microsoft.Azure.Cosmos.Table -Version 1.0.8
 *Install-Package Microsoft.Extensions.Configuration -Version 5.0.0
 *Install-Package Microsoft.Extensions.Configuration.Json -Version 5.0.0
 *Install-Package Microsoft.Extensions.Configuration.Binder -Version 5.0.0
 */