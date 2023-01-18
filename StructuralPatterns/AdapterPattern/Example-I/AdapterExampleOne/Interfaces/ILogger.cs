using AdapterExampleOne.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExampleOne.Interfaces
{
    public interface ILogger
    {
        void Log(LogEntry entry);
    }
}
