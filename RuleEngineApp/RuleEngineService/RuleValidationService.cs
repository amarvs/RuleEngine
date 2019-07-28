using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineService
{
    public class RuleValidationService
    {
        private readonly IType _valueTypeService;
        public RuleValidationService(IType valueType)
        {
            _valueTypeService = valueType;
        }

        /// <summary>
        /// Validare Rule
        /// </summary>
        /// <param name="value1">Value1</param>
        /// <param name="value2">Value2</param>
        /// <param name="relation">Rule Relation</param>
        /// <returns></returns>
        public bool ValidateRule(string value1, string value2, string relation)
        {
            return _valueTypeService.ValidateExpression(value1, value2, relation);
        }

    }
}
