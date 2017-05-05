using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        /// <summary>
        ///     Сериализация из контейнера в двоичный файл
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="fileName">Название файла</param>
        /// <param name="container">Контейнер</param>
        public static void SerializeBin<T>(string fileName, ref T container)
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