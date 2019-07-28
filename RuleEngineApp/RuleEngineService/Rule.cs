using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    public class Rule
    {
        public string SignalID { get; set; }
        public string ValueTYpe { get; set; }
        public string RuleRelation { get; set; }
        public string value { get; set; }

        public override string ToString()
        {
            return $"{SignalID} -> {ValueTYpe} -> {RuleRelation} -> {value}";
        }
    }
}
