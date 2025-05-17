namespace fPOP_REST.Utilities;

public class TmdbStart(ITmdbCacher tmdbCacher) : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await tmdbCacher.RefreshAsync();
    }
    
    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}