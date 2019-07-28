using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    /// <summary>
    /// String type
    /// </summary>
    public class StringType : IType
    {
        public bool ValidateExpression(string value1, string value2, string relation)
        {
            switch (relation)
            {
                case Constants.IsEqualTo:
                    return string.Equals(value1, value2);
                case Constants.IsNotEqualTo:
                    return !string.Equals(value1, value2);
                case Constants.Contains:
                    return value1.Contains(value2);
                default:
                    return false;
            }
        }
    }
}
