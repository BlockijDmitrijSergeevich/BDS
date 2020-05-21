using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer.Rules
{
    public abstract class BusinessRule
    {
        public BusinessRule()
        {

        }
        public abstract bool Validate(BusinessObject businessObject);
    }
}
