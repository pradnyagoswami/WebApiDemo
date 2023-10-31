using WebApiDemo.Models;
using WebApiDemo.Repositories;

namespace WebApiDemo.Sevices
{
    public class EmployeService : IEmployeService
    {
        private readonly IEmployeRepository repo;

        public EmployeService(IEmployeRepository repo)
        {

            this.repo = repo;
        }


        public int AddEmploye(Employe employe)
        {
            return repo.AddEmploye(employe);
        }

        public int DeleteEmploye(int id)
        {
            return repo.DeleteEmploye(id);
        }

        public Employe GetEmployeById(int id)
        {
            return repo.GetEmployeById((int)id);
        }

        public IEnumerable<Employe> GetEmployes()
        {
           return repo.GetEmployes();
        }

        public int UpdateEmploye(Employe employe)
        {
            return repo.UpdateEmploye(employe);
        }
    }
}
