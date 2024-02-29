using System;
using System.Collections.Generic;
using AutoMapper;
using AGIRA_INTERVIEW_BACKEND.Dtos;
using AGIRA_INTERVIEW_BACKEND.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AGIRA_INTERVIEW_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportunitiesController : ControllerBase
    {
        private readonly OpportunityContext _context;
        private readonly IMapper _mapper;

        public OpportunitiesController(OpportunityContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // POST: api/Opportunities
        [HttpPost]
        public ActionResult<OpportunityDto> PostOpportunity(OpportunityDto opportunityDto)
        {
            var opportunity = _mapper.Map<Opportunities>(opportunityDto);

            _context.Opportunities.Add(opportunity);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetOpportunity), new { id = opportunity.OpportunityId }, opportunityDto);
        }
        // GET: api/Opportunities
        [HttpGet]
        public ActionResult<IEnumerable<Opportunities>> GetOpportunities()
        {
            return _context.Opportunities;
        }

        // GET: api/Opportunities/5
        [HttpGet("{id}")]
        public ActionResult<Opportunities> GetOpportunity(int id)
        {
            var opportunity = _context.Opportunities.Find(id);

            if (opportunity == null)
            {
                return NotFound();
            }

            return opportunity;
        }

        // POST: api/Opportunities
        [HttpPost]
        public ActionResult<Opportunities> PostOpportunity(Opportunities opportunity)
        {
            _context.Opportunities.Add(opportunity);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetOpportunity), new { id = opportunity.OpportunityId }, opportunity);
        }

        // PUT: api/Opportunities/5
        [HttpPut("{id}")]
        public IActionResult PutOpportunity(int id, Opportunities opportunity)
        {
            if (id != opportunity.OpportunityId)
            {
                return BadRequest();
            }

            _context.Entry(opportunity).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Opportunities/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOpportunity(int id)
        {
            var opportunity = _context.Opportunities.Find(id);

            if (opportunity == null)
            {
                return NotFound();
            }

            _context.Opportunities.Remove(opportunity);
            _context.SaveChanges();

            return NoContent();
        }
    }
}