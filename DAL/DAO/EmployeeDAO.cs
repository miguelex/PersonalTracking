using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class EmployeeDAO : EmployeeContext
    {
        public static void AddEmployee(Employe employee)
        {
            try
            {
                db.Employe.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
            catch (Exception ex) { 
       
                throw ex;
            }
        }

        public static List<Employe> GetUsers(int v)
        {
            return db.Employe.Where(x => x.UserNo == v).ToList();
        }
    }
}
