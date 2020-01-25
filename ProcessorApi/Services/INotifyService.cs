using ProcessorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessorApi.Services
{
    interface INotifyService
    {
        public void Notify(TheObject theObject);
    }
}
