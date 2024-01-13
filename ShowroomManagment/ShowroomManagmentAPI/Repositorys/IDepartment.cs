using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositorys
{
    public interface IDepartment
    {
        public Task<ResponseDTO> GetDepartment();
        public Task<ResponseDTO> DeleteDepartment(int id);
        public Task<ResponseDTO> InsertDepartment(Department department);
        public Task<ResponseDTO> UpdateDepartment(Department department);
    }
}
