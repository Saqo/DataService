using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientProxy
{

    public class DataServiceClient : IDataService
    {
        IDataService dataServiceChannel = null;
        public DataServiceClient(string endpointName)
        {
            dataServiceChannel = new ChannelFactory<IDataService>(endpointName).CreateChannel();
        }


        public int[] GetData()
        {
            return dataServiceChannel.GetData();
        }
    }
}
