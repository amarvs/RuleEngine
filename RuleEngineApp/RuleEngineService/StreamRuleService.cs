using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    /// <summary>
    /// Provides all stream and rule related Service.
    /// </summary>
    public class StreamRuleService
    {
        /// <summary>
        /// Gets all data stream from file.
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <returns>List of Stream Data</returns>
        public List<StreamData> GetAllStreamData(string filePath)
        {
            List<StreamData> streamData = new List<StreamData>();
            using (var reader = new StreamReader(filePath))
            {
                string jsonString = reader.ReadToEnd();
                reader.Close();

                streamData = MyJsonConverter.DeSerialize<StreamData>(jsonString);
            }
            return streamData;
        }

        /// <summary>
        /// Gets all the rules from the file.
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <returns>List of Rules</returns>
        public List<Rule> GetAllRules(string filePath)
        {
            List<Rule> rules = new List<Rule>();
            using (var streamReader = new StreamReader(filePath))
            {
                string jsonRuleString = streamReader.ReadToEnd();
                streamReader.Close();
                rules = MyJsonConverter.DeSerialize<Rule>(jsonRuleString);
            }
            return rules;
        }

        /// <summary>
        /// Stores all the rules in the file.
        /// </summary>
        /// <param name="rules">List of Rules to store.</param>
        /// <param name="filePath">File Path</param>
        public void SetRules(List<Rule> rules, string filePath)
        {
            var jsonCfg = MyJsonConverter.Serialize(rules);
            using (var writer = new StreamWriter(filePath))
            {
                writer.Write(jsonCfg);
                writer.Close();
            }
        }

        /// <summary>
        /// Apply Rules on Stream data.
        /// </summary>
        /// <param name="stream">List of Stream Data</param>
        /// <param name="rules">List of Rules</param>
        /// <returns>List of Stream data which violates rules</returns>
        public IEnumerable<StreamData> ApplyRules(List<StreamData> streamData, List<Rule> rules)
        {
            List<StreamData> tream = new List<StreamData>();
            foreach (var stream in streamData)
            {
                var rule = rules.FirstOrDefault(item => item.SignalID == stream.Signal && item.ValueTYpe == stream.Value_Type);
                if (rule != null)
                {
                    var validdationService = GetRuleValidationService(rule.ValueTYpe);
                    if (!validdationService.ValidateRule(stream.Value, rule.value, rule.RuleRelation))
                        yield return stream;
                }
            }
        }

        private RuleValidationService GetRuleValidationService(string valueType)
        {
            switch (valueType)
            {

                case Constants.Integer:
                    return new RuleValidationService(new IntegerType());
                case Constants.Datetime:
                    return new RuleValidationService(new DatetimeType());
                default:
                    return new RuleValidationService(new StringType());

            }
        }
    }
}
