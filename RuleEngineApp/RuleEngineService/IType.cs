using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    /// <summary>
    /// Validate expression on type
    /// </summary>
    public interface IType
    {
        /// <summary>
        /// Validate expression
        /// </summary>
        /// <param name="value1">Value1</param>
        /// <param name="value2">Value2</param>
        /// <param name="relation">Expression Relation</param>
        /// <returns></returns>
        bool ValidateExpression(string value1, string value2, string relation);
    }
}
