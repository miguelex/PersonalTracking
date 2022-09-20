using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class TaskDAO : EmployeeContext
    {
        public static List<TasksStates> GetTaskStates()
        {
            return db.TasksStates.ToList();
        }

        public static void AddTask(TASK task)
        {
            try
            {
                db.TASK.InsertOnSubmit(task);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<TaskDetailDTO> GetTasks()
        {
            List<TaskDetailDTO> tasksList = new List<TaskDetailDTO>();
            var list = (from t in db.TASK
                        join s in db.TasksStates on t.TaskState equals s.ID
                        join e in db.Employe on t.EmployeeID equals e.ID
                        join d in db.Department on e.Department_id equals d.ID
                        join p in db.EmpPosition on e.Position_id equals p.ID
                        select new
                        {
                            taskID = t.ID,
                            title = t.TaskTitle,
                            content = t.TaskContent,
                            startdate = t.TaskStartDate,
                            deliveryDate = t.TaskDeliveryDate,
                            taskStateName = s.StateName,
                            taskStateID = t.TaskState,
                            UserNo = e.UserNo,
                            Name = e.Name,
                            EmployeeId = t.EmployeeID,
                            Surname = e.SurName,
                            positionName = p.PositionName,
                            departmanName = d.DepartmentName,
                            positionID = e.Position_id,
                            departmentId = e.Department_id


                        }).OrderBy(x => x.startdate).ToList();
            foreach (var item in list)
            {
                TaskDetailDTO dto = new TaskDetailDTO();
                dto.TaskID = item.taskID;
                dto.Title = item.title;
                dto.Content = item.content;
                dto.TaskStartDate = item.startdate;
                dto.TaskDeliveryDate = item.deliveryDate;
                dto.TaskStateName = item.taskStateName;
                dto.taskStateID = Convert.ToInt32(item.taskStateID);
                dto.UserNo = Convert.ToInt32(item.UserNo);
                dto.Name = item.Name;
                dto.Surname = item.Surname;
                dto.DepartmentName = item.departmanName;
                dto.PositionID = Convert.ToInt32(item.positionID);
                dto.PositionName = item.positionName;
                dto.EmployeeID = Convert.ToInt32(item.EmployeeId);
                tasksList.Add(dto);

            }
            return tasksList;
        }

        public static void ApproveTask(int taskID, bool isAdmin)
        {
            try
            {
                TASK tsk = db.TASK.First(x => x.ID == taskID);
                if (isAdmin) 
                    tsk.TaskState = TaskStates.Approved;
                else
                    tsk.TaskState = TaskStates.Delivered;
                    tsk.TaskDeliveryDate = DateTime.Today;
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void DeleteTask(int taskID)
        {
            try
            {
                TASK ts = db.TASK.First(x => x.ID == taskID);
                db.TASK.DeleteOnSubmit(ts);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdateTask(TASK task)
        {
            try
            {
                TASK ts = db.TASK.First(x => x.ID == task.ID);
                ts.TaskTitle = task.TaskTitle;
                ts.TaskContent = task.TaskContent;
                ts.TaskState = task.TaskState;
                ts.EmployeeID = task.EmployeeID;
                db.SubmitChanges();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
