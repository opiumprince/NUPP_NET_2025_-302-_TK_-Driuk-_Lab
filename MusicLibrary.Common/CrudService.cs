using System.Text.Json;

namespace MusicLibrary.Common;

public class CrudService<T> : ICrudService<T> where T : Entity
{
    private readonly Dictionary<Guid, T> _storage = new();

    public void Create(T element)
    {
        _storage[element.Id] = element;
    }

    public T Read(Guid id)
    {
        return _storage.TryGetValue(id, out var value) ? value : null!;
    }

    public IEnumerable<T> ReadAll() => _storage.Values;

    public void Update(T element)
    {
        if (_storage.ContainsKey(element.Id))
        {
            _storage[element.Id] = element;
        }
    }

    public void Remove(T element)
    {
        _storage.Remove(element.Id);
    }

    public void Save(string filePath)
    {
        var json = JsonSerializer.Serialize(_storage.Values);
        File.WriteAllText(filePath, json);
    }

    public void Load(string filePath)
    {
        if (!File.Exists(filePath)) return;
        var json = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<List<T>>(json);
        if (data != null)
        {
            _storage.Clear();
            foreach (var item in data)
            {
                _storage[item.Id] = item;
            }
        }
    }
}