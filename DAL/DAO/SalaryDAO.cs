using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class SalaryDAO : EmployeeContext
    {
        public static List<Months> GetMonths()
        {
            return db.Months.ToList();
        }

        public static List<SalaryDetailDTO> GetSalaries()
        {
            List<SalaryDetailDTO> salaryList = new List<SalaryDetailDTO>();
            var list = (from s in db.Salary
                        join e in db.Employe on s.Employe_id equals e.ID
                        join m in db.Months on s.Month_id equals m.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            name = e.Name,
                            surname = e.SurName,
                            EmployeeID = s.Employe_id,
                            amount = s.Amount,
                            year = s.Year,
                            monthName = m.MonthName,
                            monthID = s.Month_id,
                            salaryID = s.ID,
                            departmentID = e.Department_id,
                            positionID = e.Position_id

                        }).OrderBy(x => x.year).ToList();
            foreach (var item in list)
            {
                SalaryDetailDTO dto = new SalaryDetailDTO();
                dto.UserNo = Convert.ToInt32(item.UserNo);
                dto.Name = item.name;
                dto.Surname = item.surname;
                dto.EmployeeID = Convert.ToInt32(item.EmployeeID);
                dto.SalaryAmount = Convert.ToInt32(item.amount);
                dto.SalaryYear = Convert.ToInt32(item.year);
                dto.MonthName = item.monthName;
                dto.MonthID = Convert.ToInt32(item.monthID);
                dto.SalaryID = item.salaryID;
                dto.DepartmentID = Convert.ToInt32(item.departmentID);
                dto.PositionID = Convert.ToInt32(item.positionID);
                dto.oldSalary = Convert.ToInt32(item.amount);
                salaryList.Add(dto);

            }
            return salaryList;
        }

        public static void AddSalary(Salary salary)
        {
            try
            {
                db.Salary.InsertOnSubmit(salary);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
