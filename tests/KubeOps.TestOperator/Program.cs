﻿using System.Threading.Tasks;
using KubeOps.Operator;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace KubeOps.TestOperator;

public class Program
{
    static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }

    public static async Task Main(string[] args)
    {
        await CreateHostBuilder(args).Build().RunOperatorAsync(args);
    }
}
