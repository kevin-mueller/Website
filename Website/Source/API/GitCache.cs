using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text.Json;
using Newtonsoft.Json;
using Website.Data.Models;
using JsonException = System.Text.Json.JsonException;

namespace Website.Source.API
{
    public class GitCache
    {
        private const string CACHE_FILE_PATH = "data.cache";

        public static List<Repository> GetCache()
        {
            return File.Exists(CACHE_FILE_PATH) ? JsonConvert.DeserializeObject<List<Repository>>(File.ReadAllText(CACHE_FILE_PATH)) : null;
        }

        public static void WriteCache(List<Repository> data)
        {
            File.WriteAllText(CACHE_FILE_PATH, JsonConvert.SerializeObject(data));
        }

        public static bool ShouldRenewCache()
        {
            return (DateTime.Now - File.GetLastWriteTime(CACHE_FILE_PATH)).TotalMinutes >= 1.2;
        }
    }
}