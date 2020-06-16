using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inmobiliaria.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Inmobiliaria.Api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class InmueblesController : ControllerBase
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;


        public InmueblesController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }

        // GET: api/Inmuebles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inmueble>>> Get()
        {
            try
            {
                var usuario = User.Identity.Name;
                return Ok(contexto.Inmuebles.Include(x => x.Propietario).Where(x => x.Propietario.Mail == usuario));
            }
            catch (Exception e)
            {
                
                throw;
            }
             
            
            //return Ok(contexto.Inmuebles.Include(x=>x.Propietario).Where(x=>x.IdPropietario==10));
        }

        // GET: api/Inmuebles/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inmuebles
        [HttpPost()]
        public async Task<IActionResult> Post(Inmueble entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    entidad.IdPropietario = contexto.Propietarios.AsNoTracking().Single(x=> x.Mail == User.Identity.Name).IdPropietario;
                    entidad.Propietario = null;
                    //entidad.IdPropietario = 10;
                    contexto.Inmuebles.Add(entidad);
                    contexto.SaveChanges();
                    /// return CreatedAtAction(nameof(Get), new { id = entidad.IdPropietario }, entidad);
                    return Ok(entidad);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Inmuebles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put( Inmueble entidad)
        {
            try
            {
                if (ModelState.IsValid && contexto.Inmuebles.AsNoTracking().Include(x => x.Propietario).FirstOrDefault(x => x.Propietario.Mail == User.Identity.Name) != null)
                {
                    entidad.IdPropietario = contexto.Propietarios.AsNoTracking().Single(x => x.Mail == User.Identity.Name).IdPropietario;
                    //entidad.IdPropietario = id;
                    contexto.Inmuebles.Update(entidad);
                    contexto.SaveChanges();
                    return Ok(entidad);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        // DELETE: api/Inmuebles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entidad = contexto.Inmuebles.Include(x => x.Propietario).FirstOrDefault(x => x.IdInmueble == id && x.Propietario.Mail == User.Identity.Name);
                if (ModelState.IsValid)
                
                {
                   
                    contexto.Inmuebles.Remove(entidad);
                    contexto.SaveChanges();
                    return Ok(entidad);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
