using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositorys;

namespace ShowroomManagmentAPI.Models
{
    public class DepartmentModel : IDepartment
    {
        private readonly ApplicationDbContext _dbcontext;

        public DepartmentModel(ApplicationDbContext dbContext)
        {
            this._dbcontext = dbContext;
        }

        public async Task<ResponseDTO> DeleteDepartment(int id)
        {
            var response = new ResponseDTO();    
            try
            {
               var data = await _dbcontext.Departments.Where(x => x.PkId == id).FirstOrDefaultAsync();
              response.Response = _dbcontext.Departments.Remove(data);
              await _dbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;          
             }
            return response;
        }


        public async Task<ResponseDTO> GetDepartment()
        {
            var Response = new ResponseDTO();
            try
            {
               Response.Response = await _dbcontext.Departments.ToListAsync();
            }
            catch (Exception ex)
            {
                Response.ErrorMessage = ex.Message;
            }
            return Response;
        }

        public async Task<ResponseDTO> InsertDepartment(Department department)
        {
             var respnce = new ResponseDTO();
            try
            {
               respnce.Response = await _dbcontext.Departments.AddAsync(department);
               await _dbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                respnce.ErrorMessage = ex.Message;
            }
            return respnce;
        }

        public async Task<ResponseDTO> UpdateDepartment(Department department)
        {
            var response = new ResponseDTO();
            try
            {
                response.Response =  _dbcontext.Departments.Update(department);
                await _dbcontext.SaveChangesAsync();

             }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
