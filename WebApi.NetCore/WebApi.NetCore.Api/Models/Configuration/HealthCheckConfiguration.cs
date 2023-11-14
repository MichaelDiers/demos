﻿namespace WebApi.NetCore.Api.Models.Configuration
{
    using WebApi.NetCore.Api.Contracts.Configuration;

    /// <inheritdoc cref="IHealthCheckConfiguration" />
    public class HealthCheckConfiguration : IHealthCheckConfiguration
    {
        /// <summary>
        ///     Gets or sets the description of the documentation health check.
        /// </summary>
        public string DocumentationDescription { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the documentation URL.
        /// </summary>
        public string DocumentationUrl { get; set; } = string.Empty;
    }
}
