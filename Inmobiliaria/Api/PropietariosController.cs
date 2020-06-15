using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Inmobiliaria.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Inmobiliaria.Api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class PropietariosController : ControllerBase
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;
       

        public PropietariosController(DataContext contexto,IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }


        // GET: api/Propietarios
        [HttpGet]
        //[AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            try
            {
                var usuario = User.Identity.Name;
                return Ok(contexto.Propietarios.SingleOrDefault(x => x.Mail == usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        // GET: api/Propietarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Propietario>> Get(int id)//me devuelve un propietario segun el id
        {
            try
            {
                if (id <= 0)
                {

                    return NotFound();
                }
                else {
                    return  contexto.Propietarios.First(x => x.IdPropietario == id);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST: api/Propietarios
        [HttpPost("login")]
       [AllowAnonymous]
        public async Task<IActionResult> Login(LoginView loginView)
        {
            try
            {

                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: loginView.Clave,
                    salt: System.Text.Encoding.ASCII.GetBytes(config["Salt"]),
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 1000,
                    numBytesRequested: 256 / 8));
                var u = contexto.Usuarios.FirstOrDefault(x => x.Mail == loginView.Mail);
                //var u = contexto.Usuarios.FirstOrDefault(x => x.Clave == loginView.Clave);// el propietario ahora es un usuario
                if (u == null || u.Clave != hashed)
                {
                    return BadRequest("Nombre de usuario o clave incorrecta");
                }
                else
                {
                    var p = contexto.Propietarios.FirstOrDefault(x => x.Mail == u.Mail);
                    var key = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(config["TokenAuthentication:SecretKey"]));
                    var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, p.Mail),
                        new Claim("FullName", p.Nombre + " " + p.Apellido),
                        new Claim(ClaimTypes.Role, "Propietario"),
                    };

                    var token = new JwtSecurityToken(
                        issuer: config["TokenAuthentication:Issuer"],
                        audience: config["TokenAuthentication:Audience"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: credenciales
                    );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Propietarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Propietario propietario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //propietario.IdPropietario = id;
                    contexto.Propietarios.Update(propietario);
                    contexto.SaveChanges();
                    return Ok(propietario);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
