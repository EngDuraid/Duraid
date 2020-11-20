using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Duraid.Infrastructure.Services.Data.PostCategories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Duraid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCategoriesController : ControllerBase
    {
        readonly IPostCategoryServices _postCategoryServices;
        readonly IPostCategoryCommanderServices _postCategoryCommaderServices;

        public PostCategoriesController(IPostCategoryServices postCategoryServices,
            IPostCategoryCommanderServices postCategoryCommaderServices)
        {
            _postCategoryServices = postCategoryServices;
            _postCategoryCommaderServices = postCategoryCommaderServices;
        }
        //TODO : you  must get PostCategories by either PostId or CategoryId

        [HttpGet("p/{id}")]
        public async Task<IActionResult> GetByPostId(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                    return NotFound();
                return Ok(await _postCategoryServices.GetPostCategoriesByPostIdAsync(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("c/{id}")]

        public async Task<IActionResult> GetByCategoryId(Guid id)
        {
            try
            {
                return Ok(await _postCategoryServices.GetPostCategoriesByCategoryIdAsync(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostCategoryDTO model)
        {
            try
            {
                await _postCategoryCommaderServices.CreateAsync(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _postCategoryCommaderServices.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
