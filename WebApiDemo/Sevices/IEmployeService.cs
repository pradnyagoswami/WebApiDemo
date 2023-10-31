using WebApiDemo.Models;

namespace WebApiDemo.Sevices
{
    public interface IEmployeService
    {
        IEnumerable<Employe> GetEmployes();

        Employe GetEmployeById(int id);

        int AddEmploye(Employe employe);
        int UpdateEmploye(Employe employe);

        int DeleteEmploye(int id);


    }
}
