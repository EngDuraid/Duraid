using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.API.Connector;
using Duraid.Common.DTO;
using Duraid.Infrastructure.Services.Data.Images;
using Duraid.Infrastructure.Services.Data.Posts;
using Microsoft.AspNetCore.SignalR;

namespace Duraid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        readonly IImageServices _imageServices;
        readonly IHubContext<HubConnector, IHubConnector> _hub;
        readonly IImageCommanderServices _imageCommanderServices;
        public ImagesController(IImageServices imageServices, IHubContext<HubConnector, IHubConnector> hub,
            IImageCommanderServices imageCommanderServices)
        {
            _imageServices = imageServices;
            _hub = hub;
            _imageCommanderServices = imageCommanderServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var images = await _imageServices.GetImagesAsync();
                await _hub.Clients.All.GetMessage(images);
                return Ok(images);
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
                var image = await _imageServices.GetImageAsync(id);
                return Ok(image);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ImageDto dto)
        {
            try
            {
                bool inserted = await _imageCommanderServices.CreateAsync(dto);
                return CreatedAtAction(nameof(Get), new { id = dto.ImageId }, dto);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] ImageDto dto)
        {
            try
            {
                if (id != dto.ImageId)
                    return BadRequest();

                var category = await _imageCommanderServices.UpdateAsync(dto);
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
                if (await _imageCommanderServices.DeleteAsync(id))
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
