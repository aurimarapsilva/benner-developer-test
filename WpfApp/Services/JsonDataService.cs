using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WpfApp.Services.Interfaces;

namespace WpfApp.Services
{
    public class JsonDataService<T> : IDataService<T> where T : class
    {
        private readonly string _filePath;
        private int _nextId = 1; // Para simular IDs automáticos

        public JsonDataService(string fileName)
        {
            // Define o caminho do arquivo na pasta Data
            var dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            if (!Directory.Exists(dataFolderPath))
            {
                Directory.CreateDirectory(dataFolderPath);
            }

            _filePath = Path.Combine(dataFolderPath, fileName);
            
            InitializeNextId();
        }

        private void InitializeNextId()
        {
            var entities = GetAll();
            if (entities != null && entities.Any())
            {
                // Tenta encontrar a propriedade 'Id' e obter o maior valor
                var idProperty = typeof(T).GetProperty("Id");
                if (idProperty != null && idProperty.PropertyType == typeof(int))
                {
                    _nextId = entities.Max(e => (int)idProperty.GetValue(e)) + 1;
                }
            }
        }

        public void Add(T entity)
        {
            var entities = (GetAll()).ToList();
            
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null && idProperty.PropertyType == typeof(int))
            {
                idProperty.SetValue(entity, _nextId++);
            }
            entities.Add(entity);

            SaveAll(entities);
        }

        public void Delete(int id)
        {
            var entities = (GetAll()).ToList();

            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null && idProperty.PropertyType == typeof(int))
            {
                var entityToRemove = entities.FirstOrDefault(e => (int)idProperty.GetValue(e) == id);
                if (entityToRemove != null)
                {
                    entities.Remove(entityToRemove);
                }
            }

            SaveAll(entities);
        }

        public IEnumerable<T> GetAll()
        {
            if (!File.Exists(_filePath))
            {
                return new List<T>();
            }

            try
            {
                var json = File.ReadAllText(_filePath);

                return null; //JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Erro ao deserializar JSON de {_filePath}: {ex.Message}");

                return new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler arquivo {_filePath}: {ex.Message}");

                return new List<T>();
            }
        }

        public T GetById(int id)
        {
            var entities = GetAll();
            
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null && idProperty.PropertyType == typeof(int))
            {
                return entities.FirstOrDefault(e => (int)idProperty.GetValue(e) == id);
            }
            return null;
        }

        public void SaveAll(IEnumerable<T> entities)
        {
            using (StreamWriter file = System.IO.File.CreateText(_filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, entities);
            }
        }

        public void Update(T entity)
        {
            var entities = (GetAll()).ToList();

            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null && idProperty.PropertyType == typeof(int))
            {
                var existingEntity = entities.FirstOrDefault(e => (int)idProperty.GetValue(e) == (int)idProperty.GetValue(entity));
                if (existingEntity != null)
                {
                    // Remove o antigo e adiciona o atualizado
                    entities.Remove(existingEntity);
                    entities.Add(entity);
                }
            }
            
            SaveAll(entities);
        }
    }
}
