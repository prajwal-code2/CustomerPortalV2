var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.CustomerPortalV2_ApiService>("apiservice");

builder.AddProject<Projects.CustomerPortalV2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
