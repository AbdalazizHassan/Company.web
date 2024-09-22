
using Combany.Data.Models;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;

namespace Company.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepoitory _departmentRepoitory;

        public DepartmentService(IDepartmentRepoitory departmentRepoitory)
        {
            _departmentRepoitory = departmentRepoitory;
        }

        public void Add(Department department)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
            var departments = _departmentRepoitory.GetAll();
            return departments;     
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
