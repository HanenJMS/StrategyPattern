using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyConcept
{
    internal class StrategyA : IStrategy
    {
        public object RunAlgorithm(object data)
        {
            return data;
        }
    }
}
