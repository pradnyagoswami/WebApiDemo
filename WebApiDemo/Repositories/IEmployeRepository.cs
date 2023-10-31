using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public interface IEmployeRepository
    {
        IEnumerable<Employe> GetEmployes();

        Employe GetEmployeById(int id);

        int AddEmploye(Employe Employe);
        int UpdateEmploye(Employe employe);

        int DeleteEmploye(int id);




    }
}
