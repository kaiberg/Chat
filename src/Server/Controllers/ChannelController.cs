using AutoMapper;
using chat.Server.Data;
using chat.Server.Models;
using chat.Shared;
using chat.Shared.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chat.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ChannelController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<ChannelDto> Get()
        {
            var channel = _context.Channels.Include(c => c.Messages).ThenInclude(m => m.Sender).First(); 
            return Ok(_mapper.Map<ChannelDto>(channel));
        }
    }
}
