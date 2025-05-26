using Asp.DataBase.Storages;
using Asp.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Controllers
{
    [Route("api/users_lessons/")]
    [ApiController]
    public class UserLessonController : ControllerBase
    {
        UserLessonStorage storage = new UserLessonStorage();

        [HttpPost("create")]
        [Authorize]
        public async Task<IActionResult> Create(User_LessonDTO dto)
        {
            try
            {
                User_LessonDTO? res = storage.create(dto);
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
                User_LessonDTO? res = storage.delete(id);
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
                User_LessonDTO? res = storage.getById(id);
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
                List<User_LessonDTO>? res = storage.getAll(id);
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
