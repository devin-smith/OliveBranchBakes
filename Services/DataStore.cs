using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class DataStore
    {
        // Store data outside the application installation
        // folder so it survives rebuilding and restarting.
        private readonly string _filePath;

        private readonly JsonSerializerOptions _jsonOptions =
            new JsonSerializerOptions
            {
                WriteIndented = true
            };

        public DataStore()
        {
            string dataFolder = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "OliveBranchBakes"
            );

            Directory.CreateDirectory(dataFolder);

            _filePath = Path.Combine(
                dataFolder, "bakerydata.json");
        }

        // Saves all bakery data to a JSON file.
        public void Save(BakeryData data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            string json = JsonSerializer.Serialize(
                data, _jsonOptions);

            File.WriteAllText(_filePath, json);
        }

        // Loads saved data or returns an empty data object.
        public BakeryData Load()
        {
            if (!File.Exists(_filePath))
            {
                return new BakeryData();
            }

            string json = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new BakeryData();
            }

            BakeryData? data =
                JsonSerializer.Deserialize<BakeryData>(
                    json, _jsonOptions);

            return data ?? new BakeryData();
        }

        // Returns the location of the saved JSON file.
        public string GetFilePath()
        {
            return _filePath;
        }


        // Checks whether the bakery JSON file already exists.
        public bool DataFileExists()
        {
            return File.Exists(_filePath);
        }

    }
}
