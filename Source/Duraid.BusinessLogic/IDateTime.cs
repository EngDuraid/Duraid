using System;

namespace Duraid.BusinessLogic.Data
{
    public interface IDateTime
    {
        public DateTime Now { get;}
    }

    class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now; 
    }
}