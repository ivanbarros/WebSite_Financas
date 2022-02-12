using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Controllers
{
    public class CalendarEventsController : ControllerBase
    {
        private readonly ICalendarEventServiceApplication _serviceApplication;
        private readonly SqlContext _context;
        IHttpContextAccessor _httpContextAccessor;
        public CalendarEventsController(ICalendarEventServiceApplication serviceApplication, IHttpContextAccessor httpContextAccessor, SqlContext context)
        {
            _serviceApplication = serviceApplication;
            _httpContextAccessor = httpContextAccessor;
            _context = context;

        }

        //// GET: CalendarEventEntitysController
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CalendarEventEntity>>> GetEvents([FromQuery] string start, [FromQuery] string end)
        //{
        //    string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
        //    var idUsuario = Convert.ToInt32(id_usuario_logado);
        //    var result = await _serviceApplication.GetAll(start,end, idUsuario);
        //    return result.ToList();
        //}

        //// GET: api/CalendarEventEntitys/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CalendarEventEntity>> GetCalendarEventEntity(int id)
        //{
        //    string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
        //    var idUsuario = Convert.ToInt32(id_usuario_logado);
        //    var CalendarEventEntity =  await _serviceApplication.Get(id);

        //    if (CalendarEventEntity == null)
        //    {
        //        return NotFound();
        //    }

        //    return CalendarEventEntity;
        //}

        //// PUT: api/CalendarEventEntitys/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCalendarEventEntity(int id, CalendarEventEntity CalendarEventEntity)
        //{
        //    if (id != CalendarEventEntity.Id)
        //    {
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        await _serviceApplication.Update(CalendarEventEntity);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CalendarEventEntityExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/CalendarEventEntitys
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<CalendarEventEntity>> PostCalendarEventEntity(CalendarEventEntity CalendarEventEntity)
        //{
        //     _serviceApplication.Insert(CalendarEventEntity);

        //    return CreatedAtAction("GetCalendarEventEntity", new { id = CalendarEventEntity.Id }, CalendarEventEntity);
        //}

        //// DELETE: api/CalendarEventEntitys/5
        //[HttpDelete("{id}")]
        //public  IActionResult DeleteCalendarEventEntity(int id)
        //{
        //     _serviceApplication.Excluir(id);
        //    return NoContent();



        //}

        //private bool CalendarEventEntityExists(int id)
        //{
        //    return _context.Calendar.Any(e => e.Id == id);
        //}
       
        public System.Web.Mvc.JsonResult GetEvents()
        {
            using (SqlContext dc = new SqlContext())
            {
                var events = dc.Events.ToList();
                return new System.Web.Mvc.JsonResult { Data = events, JsonRequestBehavior = System.Web.Mvc.JsonRequestBehavior.AllowGet };
            }
        }

        // GET: api/CalendarEventEntitys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarEventEntity>> GetCalendarEventEntity(int id)
        {
            var CalendarEventEntity = await _context.Events.FindAsync(id);

            if (CalendarEventEntity == null)
            {
                return NotFound();
            }

            return CalendarEventEntity;
        }

        // PUT: api/CalendarEventEntitys/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalendarEventEntity(int id, CalendarEventEntity CalendarEventEntity)
        {
            if (id != CalendarEventEntity.Id)
            {
                return BadRequest();
            }

            _context.Entry(CalendarEventEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarEventEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CalendarEventEntitys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CalendarEventEntity>> PostCalendarEventEntity(CalendarEventEntity CalendarEventEntity)
        {
            _context.Events.Add(CalendarEventEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalendarEventEntity", new { id = CalendarEventEntity.Id }, CalendarEventEntity);
        }

        // DELETE: api/CalendarEventEntitys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalendarEventEntity(int id)
        {
            var CalendarEventEntity = await _context.Events.FindAsync(id);
            if (CalendarEventEntity == null)
            {
                return NotFound();
            }

            _context.Events.Remove(CalendarEventEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CalendarEventEntityExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
//    }
//}
