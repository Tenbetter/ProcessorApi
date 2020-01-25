using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessorApi.Application;
using ProcessorApi.Models;

namespace ProcessorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        
        [HttpPost]
        public async Task PostAsync([FromBody] TheObject theObject)
        {
            IFileCompleter completer = new FileCompleter();

            //Use a discard variable to prevent warnings from not using an await
            _= Task.Run(() => completer.ObjectCompleter(theObject));
            
            
        }

       
    }
}
