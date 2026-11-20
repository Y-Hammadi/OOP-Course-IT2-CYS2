
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ClientManagement.Models;

public abstract class BaseModel<T> where T : class
{
  // Stored objects
  private List<T> _items = new();

  // Next ID
  private int _nextId = 1;

  // JSON file path
  private readonly string _filePath;

  protected BaseModel(string fileName)
  {
    string dataFolder = Path.Combine(
        Directory.GetCurrentDirectory(),
        "Data"
    );

    Directory.CreateDirectory(dataFolder);

    _filePath = Path.Combine(dataFolder, fileName);
  }

  // Generate a new ID
  private int GenerateNewId()
  {
    return _nextId++;
  }

  // Get object ID
  protected abstract int GetId(T item);

  // Create object with ID
  protected abstract T CreateWithId(T item, int id);

  // Create
  public T Create(T item)
  {
    T newItem = CreateWithId(item, GenerateNewId());

    _items.Add(newItem);

    return newItem;
  }

  // Update
  public bool Update(int id, T updatedItem)
  {
    int index = _items.FindIndex(
        item => GetId(item) == id
    );

    if (index == -1)
      return false;

    _items[index] = CreateWithId(updatedItem, id);

    return true;
  }

  // Delete
  public bool Delete(int id)
  {
    T? item = _items.FirstOrDefault(
        item => GetId(item) == id
    );

    if (item == null)
      return false;

    return _items.Remove(item);
  }

  // Get all
  public IReadOnlyList<T> GetAll()
  {
    return _items.AsReadOnly();
  }

  // Save to JSON
  public void Save()
  {
    string json = JsonSerializer.Serialize(
        _items,
        new JsonSerializerOptions
        {
          WriteIndented = true
        }
    );

    File.WriteAllText(_filePath, json);
  }

  // Load from JSON
  public void Load()
  {
    if (!File.Exists(_filePath))
      return;

    string json = File.ReadAllText(_filePath);

    if (string.IsNullOrWhiteSpace(json))
      return;

    List<T>? data = JsonSerializer.Deserialize<List<T>>(json);

    if (data == null)
      return;

    _items = data;

    _nextId = _items.Count == 0
        ? 1
        : _items.Max(item => GetId(item)) + 1;
  }
}
