using Business_layer.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public abstract class BusinessObject
    {
        List<BusinessRule> myBusinessRules = new List<BusinessRule>();
        public bool IsValid()
        {
            bool valid = true;

            foreach (var item in myBusinessRules)
            {
                if (!item.Validate(this))
                {
                    valid = false;
                }
            }           
            
            return valid;
        }
    }
}
