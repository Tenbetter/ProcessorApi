using ProcessorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessorApi.Application
{
    interface IFileCompleter
    {
        public Task ObjectCompleter(TheObject theObject);
    }
}
