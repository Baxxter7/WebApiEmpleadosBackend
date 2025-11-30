using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiEmpleados.Models;

namespace WebApiEmpleados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly EmpleadosDbcrudContext _context;

        public EmpleadoController(EmpleadosDbcrudContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empleado>>> Get() => await _context.Empleados.ToListAsync();

    }
}
