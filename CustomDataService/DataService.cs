using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomDataService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class DataService : IDataService
    {
        int counter;
        public int[] GetData()
        {
            return new int[] { counter++, 1, 2, 3, 4, 5, 6 };
        }
    }
}
