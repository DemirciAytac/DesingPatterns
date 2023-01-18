using AdapterExampleOne.Entities;
using AdapterExampleOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExampleOne.Concretes
{
    public class FileLogger : ILogger
    {
        public void Log(LogEntry entry)
        {
            //log {entry.Text} and {entry.Time} to file
        }
    }
}
