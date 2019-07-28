using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    /// <summary>
    /// Integer type Considered as Double
    /// </summary>
    public class IntegerType : IType
    {
        public bool ValidateExpression(string value1, string value2, string relation)
        {
            var integerValue1 = double.Parse(value1);
            var integerValue2 = double.Parse(value2);
            switch (relation)
            {
                case Constants.IsEqualTo:
                    return integerValue1 == integerValue2;
                case Constants.IsNotEqualTo:
                    return integerValue1 != integerValue2;
                case Constants.IsGreaterThan:
                    return integerValue1 > integerValue2;
                case Constants.IsLessThan:
                    return integerValue1 < integerValue2;
                default:
                    return false;
            }
        }
    }
}
