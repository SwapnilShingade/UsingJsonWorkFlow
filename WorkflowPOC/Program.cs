using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCorePOC.Steps;
using WorkflowCore.Services.DefinitionStorage;

namespace WorkflowPOC
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();

            //start the workflow host
            var host = serviceProvider.GetService<IWorkflowHost>();
            var loader = serviceProvider.GetService<IDefinitionLoader>();
            var workFlow = string.Empty;

            //loading workflow from JSON
            using (var streamReader = new StreamReader("C:\\Users\\Admin\\Downloads\\WorkflowPOC\\WorkflowPOC\\workflowthorough.json"))
            {
                workFlow = streamReader.ReadToEnd();              
            }

            loader.LoadDefinition(workFlow, Deserializers.Json);                     
            host.Start();
            host.StartWorkflow("ABCBanking");

            Console.ReadLine();
            host.Stop();
        }
                
        private static IServiceProvider ConfigureServices()
        {
            //setup dependency injection
            IServiceCollection services = new ServiceCollection();
            services.AddLogging();
            services.AddWorkflow(x => x.UseSqlServer(@"Server=.;Database=WorkflowCore;Trusted_Connection=True;", true, true));
            services.AddWorkflowDSL();
            
            services.AddTransient<GoodbyeWorld>();
            
            var serviceProvider = services.BuildServiceProvider();
           
            return serviceProvider;
        }


    }
}
