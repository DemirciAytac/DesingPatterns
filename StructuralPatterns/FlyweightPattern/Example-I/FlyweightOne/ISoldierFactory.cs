using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightOne
{
    public interface ISoldierFactory
    {
        Soldier GetSoldier(SoldierType sType);
    }
}
