using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class EmployeRepository : IEmployeRepository
    {

        private readonly ApplicationDbContext db;

        public EmployeRepository(ApplicationDbContext db)
        {

            this.db = db;
        }


        public int AddEmploye(Employe employe)
        {
            db.Employes.Add(employe);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmploye(int id)
        {
            int res = 0;
            var result = db.Employes.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Employes.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public Employe GetEmployeById(int id)
        {
            var result = db.Employes.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Employe> GetEmployes()
        {
            return db.Employes.ToList();
        }

        public int UpdateEmploye(Employe employe)
        {
            int res = 0;
            var result = db.Employes.Where(x => x.Id == employe.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = employe.Name;
                result.Email = employe.Email;
                result.Age = employe.Age;
                result.Salary = employe.Salary;

                res = db.SaveChanges();
            }

            return res;
        }
    }
}
