using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyConcept
{
    public class Context
    {
        IStrategy strategy;

        public void DoBusinessLogic()
        {
            //strategy.RunAlgorithm(object data);
        }
    }
}
