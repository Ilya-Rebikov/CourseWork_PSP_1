﻿// <copyright file="ConfigureDalServices.cs" company="IlyaRebikau">
// Copyright (c) IlyaRebikau. All rights reserved.
// </copyright>

namespace CourseWork.DAL.Configuration
{
    using CourseWork.DAL.Interfaces;
    using CourseWork.DAL.Models;
    using CourseWork.DAL.Services;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Configure services from DAL.
    /// </summary>
    public static class ConfigureDalServices
    {
        /// <summary>
        /// Extension method for IServiceCollection to add DAL services.
        /// </summary>
        /// <param name="services">Services.</param>
        /// <returns>Added services.</returns>
        public static IServiceCollection AddDalServices(this IServiceCollection services)
        {
            services.AddScoped<ISerializer<Matrix>, MyXmlSerializer<Matrix>>();
            services.AddScoped<ISerializer<Vector>, MyXmlSerializer<Vector>>();
            return services;
        }
    }
}
