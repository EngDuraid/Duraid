using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.API.Connector;
using Duraid.Common.DTO;
using Duraid.Infrastructure.Services.Data.Posts;
using Microsoft.AspNetCore.SignalR;
using Duraid.Infrastructure.Services.Data.PostImages;

namespace Duraid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostImagesController : ControllerBase
    {
        readonly IPostImageServices _postImageServices;
        readonly IHubContext<HubConnector, IHubConnector> _hub;
        readonly IPostImageCommanderServices _postImageCommanderServices;
        public PostImagesController(IPostImageServices postImageServices, IHubContext<HubConnector, IHubConnector> hub,
            IPostImageCommanderServices postImageCommanderServices)
        {
            _postImageServices = postImageServices;
            _hub = hub;
            _postImageCommanderServices = postImageCommanderServices;
        }
            
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var post = await _postImageServices.GetPostImageAsync(id);
                return Ok(post);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostImageDto dto)
        {
            try
            {
                bool inserted = await _postImageCommanderServices.CreateAsync(dto);
                return CreatedAtAction(nameof(Get), new { id = dto.PostImageId }, dto);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] PostImageDto dto)
        {
            try
            {
                if (id != dto.PostImageId)
                    return BadRequest();

                var category = await _postImageCommanderServices.UpdateAsync(dto);
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
                if (await _postImageCommanderServices.DeleteAsync(id))
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
