using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGenerator
{
    class ForSerializationAndDeserialization
    {
        private static string faiilikPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SaveTests.json");

        public static void Serialize<Test>(Test data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(faiilikPath, json);
        }

        public static Test Deserialize<Test>()
        {
            if (File.Exists(faiilikPath))
            {
                string jsonSave = File.ReadAllText(faiilikPath);
                return JsonConvert.DeserializeObject<Test>(jsonSave);
            }
            else
            {
                File.Create(faiilikPath).Close();
                return default(Test);
            }
        }
    }
}
