var builder = DistributedApplication.CreateBuilder(args);

var rendimentosApi = builder.AddProject<Projects.Rendimentos_Api>("rendimentos")
    .WithExternalHttpEndpoints();

builder.AddNpmApp("angular", "../../Rendimentos.Angular")
    .WithReference(rendimentosApi)
    .WaitFor(rendimentosApi)
    .WithHttpEndpoint(targetPort: 4200)
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();
