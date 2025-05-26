using Asp.DataBase.Storages;
using Asp.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Controllers
{
    [Route("api/lessons/")]
    [ApiController]
    
    public class LessonController : ControllerBase
    {
        LessonStorage storage = new LessonStorage();

        [HttpPost("create")]
        [Authorize(Roles = $"Admin")]
        public async Task<IActionResult> Create(LessonDTO dto)
        {
            try
            {
                LessonDTO? res = storage.create(dto);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("delete/{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                LessonDTO? res = storage.delete(id);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("update")]
        [Authorize]
        public async Task<IActionResult> Update(LessonDTO dto)
        {
            try
            {
                LessonDTO? res = storage.update(dto);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                LessonDTO? res = storage.getById(id);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("page/{id}")]
        [Authorize]
        public async Task<IActionResult> GetByPage(int id)
        {
            try
            {
                List<LessonDTO>? res = storage.getByPage(id);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

