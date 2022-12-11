using System;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace KIP_ASE
{
    public class FileMenager
    {
        string dataPath = $@"{Directory.GetCurrentDirectory()}\data";
        
        public bool checkFolder()
        {
            if (!Directory.Exists(dataPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(dataPath);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                return false;
            }
            return true;
        }
        //TODO dodać catche
        public bool saveData(Data data)
        {
            if(checkFolder())
            {
                string serializedData = JsonConvert.SerializeObject(data);
                File.WriteAllText($@"{dataPath}\data.json",serializedData);
                return true;
            }
            return false;
        }

        public Data readData()
        {
            if (checkFolder())
            {
                string serializedData = File.ReadAllText($@"{dataPath}\data.json");
                return JsonConvert.DeserializeObject<Data>(serializedData);
            }
            return null;
        }
    }
}
