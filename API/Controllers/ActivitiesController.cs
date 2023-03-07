using Persistence;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] // api/activities
        public async Task<ActionResult<List<Activity>>> GetActivites()
        {
            return await _context.Activites.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities/id
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activites.FindAsync(id);
        }

    }
}