using AdapterExampleOne.Entities;
using AdapterExampleOne.Interfaces;
using AdapterExampleOne.third_party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExampleOne
{
    public class DatabaseLoggerAdapter : ILogger
    {
        private DatabaseLogger _databaseLogger = new DatabaseLogger();
        public void Log(LogEntry entry)
        {
            string text = $"{entry.Text} logged at {entry.Time}.";
            _databaseLogger.Log(text);
        }
    }
}
