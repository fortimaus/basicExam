using Asp.DataBase.Storages;
using Asp.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Controllers
{
    [Route("api/trainings/")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        TrainingStorage storage = new TrainingStorage();
        
        [HttpPost("create")]
        [Authorize]
        public async Task<IActionResult> Create(TrainingDTO dto)
        {
            try
            {
                TrainingDTO? res = storage.create(dto);
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
                TrainingDTO? res = storage.delete(id);
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
        public async Task<IActionResult> Update(TrainingDTO dto)
        {
            try
            {
                TrainingDTO? res = storage.update(dto);
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
                TrainingDTO? res = storage.getById(id);
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
                List<TrainingDTO>? res = storage.getByPage(id);
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
