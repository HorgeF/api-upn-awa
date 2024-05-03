using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using net5_webapi.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace net5_webapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AwaController : ControllerBase
    {

        private readonly IDBEngine db;

        public AwaController(IDBEngine DBEngine)
        {
            db = DBEngine;
        }


        public class AwaBody
        {
            [Required]
            public string id { get; set; }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await db.Json("EXEC DASHBOARD_AWA_CAB  @ID_USUARIO = @id", new { id }));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AwaBody body)
        {
            string user = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return Ok(await db.Json("EXEC REGISTRAR_LOG @ID_USUARIO = @id", new { body.id }));
        }


    }
}
