
using System.Text.Json;

namespace Exchange_Rate.Services;

public sealed class CurrenciesStore
{
    private readonly string _path = Path.Combine(FileSystem.AppDataDirectory, "currencies.json");

    public async Task SaveAsync(IEnumerable<string> codes, CancellationToken ct = default)
    {
        var json = JsonSerializer.Serialize(codes.Distinct().ToArray(),
            new JsonSerializerOptions { WriteIndented = true });
        using var w = File.CreateText(_path);
        await w.WriteAsync(json);
    }

    public async Task<IReadOnlyList<string>> LoadAsync(CancellationToken ct = default)
    {
        if (!File.Exists(_path)) return Array.Empty<string>();
        using var r = File.OpenText(_path);
        var json = await r.ReadToEndAsync();
        var codes = JsonSerializer.Deserialize<string[]>(json) ?? Array.Empty<string>();
        return codes;
    }
}
