using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCreditSuisse.Interface
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}
