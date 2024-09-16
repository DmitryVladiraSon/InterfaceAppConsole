using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAppConsole.Navigator
{
    internal class Navegator
    {
public int GetNavigate(IGetTime getTime, double km)
{
    return getTime.GetTime(km);
}

    }
}
