using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_LAB_W14.Interfaces
{
    public interface INewsObserver
    {
        void update(string newstype);
    }
}
