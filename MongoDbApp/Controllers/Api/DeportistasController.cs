using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDbApp.Models;
using MongoDbApp.Models.Comun;
using MongoDbApp.Repositorio.DeportistasES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeportistasController : ControllerBase
    {
        private readonly IDeportistasContratoCollection _repositoryDeportistas;
        public DeportistasController()
        {
            _repositoryDeportistas = new DeportistasRepositorioCollection();
        }


        [Route("[action]", Name = "GetAllListDeportistas")]
        [HttpGet]
        public async Task<IActionResult> GetAllListDeportistas()
        {
            bool ok = false;
            string mensaje = "Sin Datos";
            var Deportistas = await Task.Run(() => _repositoryDeportistas.GetListDeportistas());
            if (Deportistas != null || Deportistas.Count()>0)
            {
                mensaje = "ok";
                ok = true;
            }
            var data = new { Deportistas, ok, mensaje };
            return Ok(data);
        }

        [Route("[action]", Name = "GetUnDeportistaById")]
        [HttpGet]
        public async Task<IActionResult> GetUnDeportistaById(string id)
        {
            ResponseApp response = new ResponseApp()
            {
                Message = "Ups!. Tu Solicitud No Pudo ser Procesada",
                Ok = false
            };
            if (!string.IsNullOrWhiteSpace(id))
            {
                var Deportista = await Task.Run(() => _repositoryDeportistas.GetDeportistasById(id));
                if (Deportista != null)
                {
                    response.Message = "ok";
                    response.Ok = true;
                }
                var data = new { Deportista, response };
                return Ok(data);
            }
            else
            {
                response.Message = "Debes enviar un id";
            }
            return BadRequest(response);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> CreateDeportista([FromBody] Deportistas entidad)
        {
            ResponseApp data = new ResponseApp()
            {
                Message = "Ups!. Tu Solicitud No Pudo ser Procesada",
                Ok = false
            };
            try
            {
                if (ModelState.IsValid)
                {
                     await Task.Run(() => _repositoryDeportistas.InsertDeportistas(entidad));
                }
                else
                {
                    foreach (var item in ModelState.Values)
                    {
                        if (item.Errors[0].ErrorMessage == "")
                        {
                            data.Message += item.Errors[0].Exception.Message + " ";
                        }
                        else
                        {
                            data.Message += item.Errors[0].ErrorMessage + " ";
                        }
                    }
                    ModelState.AddModelError("Nombre",data.Message);
                }
                return Created("Created",true);
            }
            catch (Exception x)
            {
                data.Message = "Ups!. Algo salio mal!. Error interno. " + x.HResult;
                return BadRequest(data);
            }
        }

        [Route("[action]")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDeportista([FromBody] Deportistas entidad,string id)
        {
            ResponseApp data = new ResponseApp()
            {
                Message = "Ups!. Tu Solicitud No Pudo ser Procesada",
                Ok = false
            };
            try
            {
                if (ModelState.IsValid)
                {
                    entidad.id =new MongoDB.Bson.ObjectId(id);
                    await Task.Run(() => _repositoryDeportistas.UpdateDeportistas(entidad));
                }
                else
                {
                    foreach (var item in ModelState.Values)
                    {
                        if (item.Errors[0].ErrorMessage == "")
                        {
                            data.Message += item.Errors[0].Exception.Message + " ";
                        }
                        else
                        {
                            data.Message += item.Errors[0].ErrorMessage + " ";
                        }
                    }
                    ModelState.AddModelError("Nombre", data.Message);
                }
                return Created("Created", true);
            }
            catch (Exception x)
            {
                data.Message = "Ups!. Algo salio mal!. Error interno. " + x.HResult;
                return BadRequest(data);
            }
        }
        [Route("[action]")]
        [HttpDelete]
        public async Task<IActionResult> DeleteDeportista(string id)
        {
            await Task.Run(() => _repositoryDeportistas.DeleteDeportistas(id));
            return NoContent();
        }
    }
}
