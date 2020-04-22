using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace PokeAPI
{
    internal static class Cacher
    {
        internal static List<Cache> cache;
        internal static string FileName;
        internal static void Initialize()
        {
            FileName = Connector.CacheFolder + "data.bin";
            if (!Directory.Exists(Connector.CacheFolder))
                Directory.CreateDirectory(Connector.CacheFolder);
            if (File.Exists(FileName))
                cache = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cache>>(File.ReadAllText(FileName));
            else { cache = new List<Cache>(); SaveCacheData(); };
            
        }
        internal static void Cache(string resource, int id, object data, bool force = false)
        {
            string dir = Connector.CacheFolder + resource + "//";
            string file = dir + id.ToString() + ".json";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            if (HasEntry(resource, id) && !force)
                return;
            cache.Add(new PokeAPI.Cache()
            {
                date = DateTime.Now,
                fileName = file,
                id = id,
                resource = resource
            });
            File.WriteAllText(file, Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented));
            SaveCacheData();
        }
        internal static bool HasEntry(string resource,int id)
        {
            var c = cache.Any(x => x.resource == resource && x.id == id);
            if(c)
            {
                if (File.Exists(cache.Single(x => x.resource == resource && x.id == id).fileName))
                { return true; }
                else
                {
                    cache.RemoveAll(x => x.resource == resource && x.id == id);
                    SaveCacheData();
                    return false;
                }
            }
            return false;

        }
        internal static void SaveCacheData()
        {
            File.WriteAllText(FileName, Newtonsoft.Json.JsonConvert.SerializeObject(cache, Newtonsoft.Json.Formatting.Indented));
        }
        internal static string Read(string resource, int id)
        {
            return cache.Single(x => x.resource == resource && x.id == id).fileName;
        }
    }
}
