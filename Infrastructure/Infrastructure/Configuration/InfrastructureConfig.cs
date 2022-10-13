namespace Infrastructure.Configuration;

public class InfrastructureConfig
{
    public string BasePath { get; set; } = null!;

    public string BasketApi { get; set; } = null!;

    public string CatalogApi { get; set; } = null!;

    public string GlobalUrl { get; set; } = null!;

    public string HttpLogging { get; set; } = null!;

    public string SpaUrl { get; set; } = null!;
}
