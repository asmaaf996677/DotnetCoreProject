[using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using DotnetCoreProject.Models;

namespace DotnetCoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        public CharacterController()
        {
        }

        private static Character knight= new Character();
        public IActionResult Get()
        {
            return OK(knight);
        }

    }
}]