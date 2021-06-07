using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace FileSystem
{
    public class ReadWrite
    {
        public static void WriteJson(object data, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
            }
        }

        public static void ReadJson<T>(ref T data, string filePath)
        {
            data = JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        }

        public static T ReadJson<T>(string filePath)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        }
        public static void ReadJsontoList<T>(ref List<T> data, string filePath)
        {
            data = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath));
        }
        public static List<T> ReadJsontoList<T>(string filePath)
        {
            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath));
        }
    }
}
