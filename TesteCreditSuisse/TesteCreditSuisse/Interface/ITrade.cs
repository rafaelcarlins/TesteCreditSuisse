using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCreditSuisse.Model;

namespace TesteCreditSuisse.Interface
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        void addPortfolio(List<Trade> trades);
    }
}
