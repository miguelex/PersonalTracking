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

        public static void AddTask(Tasks task)
        {
            try
            {
                db.Tasks.InsertOnSubmit(task);
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
            return tasksList;
        }
    }
}
