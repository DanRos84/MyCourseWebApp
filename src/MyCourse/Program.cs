﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyCourse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webHostBuilder => {
                    webHostBuilder.UseStartup<Startup>();
            })

            // per configurare la DI in un'app consolle devo usare:
            //.ConfigureServices

            //Posso ridefinire l'elenco dei provider di default
            /*.ConfigureLogging((context, builder) => {
                builder.ClearProviders();
                builder.AddConsole();
                builder.Add...;
            })*/

            //Posso ridefinire l'elenco delle fonti di configurazione con ConfigureAppConfiguration
            /*.ConfigureAppConfiguration((context, builder) => {
                builder.Sources.Clear();
                builder.AddJsonFile("appsettings.json", optional:true, reloadOnChange: true);
                builder.AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);
                //Qui altre fonti...
            })*/
                
            ;


    }
}
