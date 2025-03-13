using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using University.Models.Dtos.Teacher;
using University.Service.Interfaces;


namespace University.API.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    //[Authorize]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        /// <summary>
        /// მასწავლებლის დამატება
        /// </summary>
        /// <param name="model">ახალი მასწავლებლის DTO</param>
        /// <returns>Task IActionReult</returns>
        [HttpPost]
        public async Task<IActionResult> AddTeacher([FromForm] TeacherForCreatingDto model)
        {
            await _teacherService.AddNewTeacher(model);
            await _teacherService.SaveTeacher();

            ApiResponse response = new(ApiResponseMessage.SuccessMessage, model, 201, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }

        /// <summary>
        /// მასწავლებლის წაშლა
        /// </summary>
        /// <param name="id">მასწავლებლის id</param>
        /// <returns>Task IActionResult</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher([FromRoute] int id)
        {
            await _teacherService.DeleteTeacher(id);
            await _teacherService.SaveTeacher();

            ApiResponse response = new(ApiResponseMessage.SuccessMessage, id, 204, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }

        /// <summary>
        /// მასწავლებლის განახლება
        /// </summary>
        /// <param name="model">განახლების DTO</param>
        /// <returns>Task IActionResult</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateTeacher([FromBody] TeacherForUpdatingDto model)
        {
            await _teacherService.UpdateTeacher(model);
            await _teacherService.SaveTeacher();

            ApiResponse response = new(ApiResponseMessage.SuccessMessage, model, 200, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }


        /// <summary>
        /// ყველა მასწავლებელი
        /// </summary>
        /// <returns>Task IActionResult</returns>
        [HttpGet]
        public async Task<IActionResult> GetTeachers([FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            var result = await _teacherService.GetAllTeachers(pageNumber, pageSize);
            ApiResponse response = new(ApiResponseMessage.SuccessMessage, result, 200, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }


        /// <summary>
        /// კონკრეტული მასწავლებელი
        /// </summary>
        /// <param name="id">მასწავლების id</param>
        /// <returns>Task IActionResult</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacher([FromRoute] int id)
        {
            var result = await _teacherService.GetSingleTeacher(id);
            ApiResponse response = new(ApiResponseMessage.SuccessMessage, result, 200, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }
    }
}
