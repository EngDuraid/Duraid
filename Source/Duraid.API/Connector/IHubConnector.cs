using System;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.API.Connector
{
    public interface IHubConnector
    {
        Task GetMessage<T>(T models);
    }
}
