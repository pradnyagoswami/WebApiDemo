using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Sevices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly IEmployeService service;
        public EmployeController(IEmployeService service)
        {
            this.service = service;
        }


        // GET: api/Employe/GetEmployes
        [HttpGet]
        [Route("GetEmployes")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetEmployes();
                return new ObjectResult(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
        }


        // GET api/Employe/GetEmployeById/1
        [HttpGet]
        [Route("GetBookById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetEmployeById(id);
                if (model != null)
                    return new ObjectResult(model);
                else
                    return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        // POST api/Employe/AddEmploye
        [HttpPost]
        [Route("AddEmploye")]
        public IActionResult Post([FromBody] Employe employe)// from body of HTTP
        {
            try
            {
                int result = service.AddEmploye(employe);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        // PUT api/Employe/UpdateEmploye
        [HttpPut]
        [Route("UpdateEmploye")]
        public IActionResult Put([FromBody] Employe employe)
        {
            try
            {
                int result = service.UpdateEmploye(employe);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        // DELETE api/<EmployeController>/5
        [HttpDelete]
        [Route("DeleteEmploye/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteEmploye(id);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }
}
