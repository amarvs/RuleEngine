using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    /// <summary>
    /// JSon Data Serialization and DeSerialization.
    /// </summary>
    public static class MyJsonConverter
    {
        /// <summary>
        /// Converts list of objects into Json String.
        /// </summary>
        /// <param name="dataObject">List of Objects to convert into string.</param>
        /// <returns>Json format string</returns>
        public static string Serialize(List<Rule> dataObject)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("[");
            var dataObjectLength = dataObject.Count;
            for (int i = 0; i < dataObjectLength; i++)
            {
                builder.AppendLine("\t{");

                var properties = dataObject[i].GetType().GetProperties();
                var propLength = properties.Length;
                for (int j = 0; j < propLength; j++)
                {
                    builder.Append($"\t\t\"{properties[j].Name}\":\"{properties[j].GetValue(dataObject[i])}\"");
                    if (j + 1 < propLength)
                        builder.AppendLine(",");
                }
                builder.AppendLine();
                if (i + 1 < dataObjectLength)
                    builder.AppendLine("\t},");
                else
                    builder.AppendLine("\t}");
            }

            builder.AppendLine("]");

            return builder.ToString();
        }

        /// <summary>
        /// Converts JSon format string into list of objects
        /// </summary>
        /// <typeparam name="T">Type of Object to convert</typeparam>
        /// <param name="dataString">Json format String</param>
        /// <returns></returns>
        public static List<T> DeSerialize<T>(string dataString) where T : new()
        {
            dataString = dataString.Replace("\n", string.Empty);
            dataString = dataString.Replace("\t", string.Empty);
            dataString = dataString.Replace("\r", string.Empty);
            string[] splitObject = new string[] { "},", "} ," };
            string[] splitData = new string[] { ":\"", ": \"" };
            List<T> listData = new List<T>();

            var dataCollection = dataString.Split(splitObject, StringSplitOptions.RemoveEmptyEntries);

            foreach (var data in dataCollection)
            {
                T instance = new T();
                var objectData = data.Replace("[", string.Empty);
                objectData = objectData.Replace("]", string.Empty);
                objectData = objectData.Replace("{", string.Empty);
                objectData = objectData.Replace("}", string.Empty);
                var propData = objectData.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (propData.Length > 0)
                {
                    for (int i = 0; i < propData.Length; i++)
                    {

                        var property = instance.GetType().GetProperties()[i];

                        var propValue = propData[i].Split(splitData, StringSplitOptions.RemoveEmptyEntries);

                        instance.GetType().GetProperty(property.Name).SetValue(instance, propValue[1].Replace("\"", string.Empty));
                    }
                    listData.Add(instance);
                }
            }

            return listData;
        }
    }
}
