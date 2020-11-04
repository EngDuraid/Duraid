using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.API.Connector;
using Duraid.Common.DTO;
using Duraid.Infrastructure.Services.Data.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace Duraid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        readonly ICategoryServices _categoryServices;
        readonly ICategoryCommander _categoryCommander;
        readonly IHubContext<HubConnector, IHubConnector> hub;
        //   readonly ILogger _logger;

        public CategoriesController(ICategoryServices categoryServices,
            /*ILogger logger,*/ ICategoryCommander categoryCommander, IHubContext<HubConnector, IHubConnector> hub)
        {
            _categoryServices = categoryServices;
            _categoryCommander = categoryCommander;
            this.hub = hub;
            //_logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var categories = await _categoryServices.GetCategoriesAsync();
                await hub.Clients.All.GetMessage(categories);
                return Ok(categories);
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
                var category = await _categoryServices.GetCategoryAsync(id);
                return Ok(category);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryDTO dto)
        {
            try
            {
                bool inserted = await _categoryCommander.CreateCategoryAsync(dto);
                return CreatedAtAction(nameof(Get), new { id = dto.CategoryId }, dto);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception");
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CategoryDTO dto)
        {
            try
            {
                if (id != dto.CategoryId)
                    return BadRequest();

                var category = await _categoryCommander.UpdateCategoryAsync(dto);
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
                if (await _categoryCommander.DeleteCategoryAsync(id))
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
