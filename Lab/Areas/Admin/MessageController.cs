using System.Linq;
using Lab.Database;
using Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Areas.Admin
{
    public class MessageController : AdminControllerBase
    {
        public MessageController(AdminDbContext adminDbContext) : base(adminDbContext)
        {
        }

        /// <summary>
        /// Get a list of messages
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public JsonResult Index()
        {
            return new JsonResult(_adminDbContext.Messages.ToList());
        }

        /// <summary>
        /// Create an instance of a message
        /// </summary>
        /// <param name="createMessageDto"></param>
        /// <returns>New Message</returns>
        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult Create([FromBody] CreateMessageDto createMessageDto)
        {
            _adminDbContext.Messages.Add(new Message
            {
                Content = createMessageDto.Content
            });

            _adminDbContext.SaveChanges();
            
            return Ok();
        }
    }
}