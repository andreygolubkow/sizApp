using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using Newtonsoft.Json;

namespace Tools
{
    public static class DataSerializer
    {
        /// <summary>
        ///     Десериализация из двоичного файла в контейнер
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="fileName">Файл</param>
        /// <param name="container">Контейнер</param>
        public static void DeserializeBin<T>(string fileName, ref T container)
        {
            var formatter = new BinaryFormatter();
            using (var deserializeFile = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (deserializeFile.Length > 0)
                {
                    container = (T)formatter.Deserialize(deserializeFile);
                    deserializeFile.Close();
                }
                else
                {
                    deserializeFile.Close();
                    throw new ArgumentException("Файл пустой");
                }
            }
                
        }

        public static void DeserializeJSON<T>(string fileName, ref T container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            container = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName), new JsonSerializerSettings
                                                                                     {
                                                                                         TypeNameHandling = TypeNameHandling.Auto,
                                                                                         NullValueHandling = NullValueHandling.Ignore,
                                                                                     });
        }

        public static void SerializeJson<T>(string fileName, ref T container)
        {

            var serializer = new JsonSerializer();
            //serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.Auto;
            serializer.Formatting = Formatting.Indented;

            using (var sw = new StreamWriter(fileName))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, container, typeof(T));
                }
            }

        }

        /// <summary>
        ///     Сериализация из контейнера в двоичный файл
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="fileName">Название файла</param>
        /// <param name="container">Контейнер</param>
        public static void SerializeBin<T>(string fileName, T container)
        {
            var formatter = new BinaryFormatter();
            using (var serializeFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(serializeFileStream, container);
                serializeFileStream.Close();
            }
        }
    }
}