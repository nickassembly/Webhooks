﻿using AirlineSendAgent.App;
using AirlineSendAgent.Client;
using AirlineSendAgent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) => 
{
    services.AddSingleton<IAppHost, AppHost>();
    services.AddDbContext<SendAgentDbContext>(opt => 
    {
        opt.UseSqlServer(context.Configuration.GetConnectionString("AirlineConnection"));      
    });
    services.AddSingleton<IWebhookClient, WebhookClient>();
    services.AddHttpClient();

}).Build();

host.Services.GetService<IAppHost>()?.Run();

