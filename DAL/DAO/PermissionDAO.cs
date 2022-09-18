using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DAO
{
    public class PermissionDAO : EmployeeContext
    {
        public static void AddPermission(Permisions permission)
        {
			try
			{
				db.Permisions.InsertOnSubmit(permission);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

        public static List<PermisionState> GetStates()
        {
            return db.PermisionState.ToList();
        }

        public static List<PermissionDetailDTO> GetPermissions()
        {
            List<PermissionDetailDTO> permissions = new List<PermissionDetailDTO>();

            var list = (from p in db.Permisions
                        join s in db.PermisionState on p.PermisionState equals s.ID
                        join e in db.Employe on p.Employe_id equals e.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            name = e.Name,
                            Surname = e.SurName,
                            StateName = s.StateName,
                            stateID = p.PermisionState,
                            startdate = p.PermisionStart,
                            endDate = p.PermisionEnd,
                            employeeID = p.Employe_id,
                            PermissionID = p.ID,
                            explanation = p.PermisionExplanation,
                            Dayamount = p.permisionDay,
                            departmentID = e.Department_id,
                            positionID = e.Position_id

                        }).OrderBy(x => x.startdate).ToList();
            foreach (var item in list)
            {
                PermissionDetailDTO dto = new PermissionDetailDTO();
                dto.UserNo = Convert.ToInt32(item.UserNo);
                dto.Name = item.name;
                dto.Surname = item.Surname;
                dto.EmployeeID = Convert.ToInt32(item.employeeID);
                dto.PermissionDayAmount = Convert.ToInt32(item.Dayamount);
                dto.StartDate = (DateTime)item.startdate;
                dto.EndDate = (DateTime)item.endDate;
                dto.DepartmentID = Convert.ToInt32(item.departmentID);
                dto.PositionID = Convert.ToInt32(item.positionID);
                dto.State = Convert.ToInt32(item.stateID);
                dto.StateName = item.StateName;
                dto.Explanation = item.explanation;
                dto.PermissionID = item.PermissionID;
                permissions.Add(dto);
            }
            return permissions;
        }

        public static void DeletePermission(int permissionID)
        {
            try
            {
                Permisions pr = db.Permisions.First(x => x.ID == permissionID);
                db.Permisions.DeleteOnSubmit(pr);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdatePermission(int permissionID, int approved)
        {
            try
            {
                Permisions pr = db.Permisions.First(x => x.ID == permissionID);
                pr.PermisionState = approved;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdatePermission(Permisions permission)
        {
            try
            {
                Permisions pr = db.Permisions.First(x => x.ID == permission.ID);
                pr.PermisionStart = permission.PermisionStart;
                pr.PermisionEnd = permission.PermisionEnd;
                pr.PermisionExplanation = permission.PermisionExplanation;
                pr.permisionDay = permission.permisionDay;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
