using System;
using System.IO;
using Domain;
using YamlDotNet.Serialization;

namespace Data_Layer
{
    public class ConfigSerializer : IConfigSerializer
    {
        private readonly string _dir;
        private readonly string _filepath;

        public ConfigSerializer(string path)
        {
            _dir = path;
            _filepath = Path.Combine(path, "config.yml");
        }

        public void Save(Config config)
        {
            //serialize the object
            var serializer = new SerializerBuilder().Build();
            var configFile = serializer.Serialize(config);
            if (File.Exists(_filepath))
            {
                File.Delete(_filepath);
            }
            else
            {
                Directory.CreateDirectory(_dir);
            }
            //delete the old config
            //write the new config
            File.WriteAllText(new FileInfo(_filepath).FullName,configFile );
        }

        public Config Load()
        {
            Config config;
            try
            {
                var file = File.ReadAllText(_filepath);
                var deserializer = new DeserializerBuilder().Build();
                config = deserializer.Deserialize<Config>(file);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                config = new ConfigDetector().MakeAutoConfig();
            }
            
            return config;
        }
        
    }
}