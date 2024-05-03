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
    public class AwaDetailController : Controller
    {

        private readonly IDBEngine db;

        public AwaDetailController(IDBEngine DBEngine)
        {
            db = DBEngine;
        }

        public class AwaDetail
        {
            [Required]
            public string id { get; set; }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await db.JsonArray("EXEC DASHBOARD_AWA_DET @ID_USUARIO = @id", new { id }));
        }

    }
}
