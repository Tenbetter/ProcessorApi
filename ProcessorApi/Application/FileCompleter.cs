using ProcessorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessorApi.Application
{
    public class FileCompleter : IFileCompleter
    {

        public async Task ObjectCompleter(TheObject theObject)
        {
            theObject.Identifier = Guid.NewGuid().ToString();
            theObject.DateCompleted = DateTime.Now.ToString();
            System.Threading.Thread.Sleep(40000);
            Console.WriteLine("DateCompleted = " + theObject.DateCompleted);

            //call Notify service
        }


        
       
    }
}
