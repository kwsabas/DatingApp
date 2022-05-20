using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
     [ApiController]
    // So using [api/[controller] we achieve to have https://localhost:5001 from launchSettings.json
    // and basically connect our methods to https://localhost:5001/api/ClassName-ControllerWord
     [Route("api/[controller]")]
    // We make a connection with the Class ControllerBase and as a resutl
    // we can use connections like [HttpGet] etc.
    public class BaseApiController : ControllerBase
    {
        
    }
}