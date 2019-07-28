using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    /// <summary>
    /// Datetime type
    /// </summary>
    public class DatetimeType : IType
    {
        public bool ValidateExpression(string value1, string value2, string relation)
        {
            var datetimeValue1 = DateTime.Parse(value1);
            var datetimeValue2 = DateTime.Parse(value2);
            var dateCompareValue = DateTime.Compare(datetimeValue1, datetimeValue2);
            switch (relation)
            {
                case Constants.IsEqualTo:
                    return dateCompareValue == 0;
                case Constants.IsNotEqualTo:
                    return dateCompareValue == 0;
                case Constants.IsGreaterThan:
                    return dateCompareValue > 0;
                case Constants.IsLessThan:
                    return dateCompareValue < 0;
                default:
                    return false;
            }
        }
    }
}
