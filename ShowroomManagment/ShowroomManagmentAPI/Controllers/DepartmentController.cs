using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.Repositorys;

namespace ShowroomManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _Service;
        public DepartmentController(IDepartment Service)
        {
            this._Service = Service;
        }

        [HttpGet("GetDepartment")]
        public async Task<string> GetDepartment()
        {
            var data = await _Service.GetDepartment();
            var responsedata = JsonConvert.SerializeObject(data);
            return responsedata;
        }

        [HttpGet("DeleteDepartment")]
        public async Task<string> DeleteDepartment()
        {
            var data = await _Service.DeleteDepartment(1);
            var responsedata = JsonConvert.SerializeObject(data);
            return responsedata;
        }

        [HttpGet("InsertDepartment")]
        public async Task<string> InsertDepartment()
        {
            var department = new Department()
            {
                Name = "IT",
                Description = "This is sample",
            };
            var data = await _Service.InsertDepartment(department);
            var responsedata = JsonConvert.SerializeObject(data);
            return responsedata;
        }

        [HttpGet("UpdateDepartment")]
        public async Task<string> UpdateDepartment()
        {
            var department = new Department()
            {
                PkId = 3,
                Name = "complines",
                Description = "This is complines department sample",

            };
            var data = await _Service.UpdateDepartment(department);
            var responsedata = JsonConvert.SerializeObject(data);
            return responsedata;

        }

    }
}
