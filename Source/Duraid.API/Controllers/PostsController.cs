using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.API.Connector;
using Duraid.Common.DTO;
using Duraid.Infrastructure.Services.Data.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Duraid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        readonly IPostServices _postServices;
        readonly IHubContext<HubConnector, IHubConnector> _hub;
        readonly IPostCommanderServices _postCommanderServices;
        public PostsController(IPostServices postServices, IHubContext<HubConnector, IHubConnector> hub, 
            IPostCommanderServices postCommanderServices)
        {
            _postServices = postServices;
            _hub = hub;
            _postCommanderServices = postCommanderServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var posts = await _postServices.GetPostsAsync();
                await _hub.Clients.All.GetMessage(posts);
                return Ok(posts);
            }
            catch (Exception ex)
            {
                // _logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var post = await _postServices.GetPostAsync(id);
                return Ok(post);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostDTO dto)
        {
            try
            {
                bool inserted = await _postCommanderServices.CreateAsync(dto);
                return CreatedAtAction(nameof(Get), new { id = dto.PostId }, dto);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] PostDTO dto)
        {
            try
            {
                if (id != dto.PostId)
                    return BadRequest();

                var category = await _postCommanderServices.UpdateAsync(dto);
                return Ok(dto);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                if (await _postCommanderServices.DeleteAsync(id))
                    return NoContent();
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
