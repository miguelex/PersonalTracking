﻿using DAL.DTO;
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

        public static List<EmployeeDetailsDTO> GetEmployees()
        {
            List<EmployeeDetailsDTO> employeesList = new List<EmployeeDetailsDTO>();

            var list = (from e in db.Employe
                        join d in db.Department on e.Department_id equals d.ID
                        join p in db.EmpPosition on e.Position_id equals p.ID
                        select new {
                            UserNo = e.UserNo,
                            Name = e.Name,
                            Surname = e.SurName,
                            EmployeeId = e.ID,
                            password = e.Password,
                            DepartmentName = d.DepartmentName,
                            PositionName = p.PositionName,
                            DepartmentID = e.Department_id,
                            PositionID = e.Position_id,
                            Salary = e.Salary,
                            ImagePath = e.imgPath,
                            isAdmin = e.isAdmin,
                            Birthday = e.Birthday,
                            Address = e.Adress
                        }).OrderBy(x => x.UserNo).ToList();

            foreach (var item in list)
            {
                EmployeeDetailsDTO dto = new EmployeeDetailsDTO();

                dto.Name = item.Name;
                dto.UserNo = (int)item.UserNo;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.EmployeeId;
                dto.Password = item.password;
                dto.DepartmentID = (int)item.DepartmentID;
                dto.DepartmentName = item.DepartmentName;
                dto.PositionID = (int)item.PositionID;
                dto.PositionName = item.PositionName;
                dto.isAdmin = item.isAdmin;
                dto.Salary = (int)item.Salary;
                dto.Birthday = item.Birthday;
                dto.Address = item.Address;
                dto.ImagePath = item.ImagePath;
                employeesList.Add(dto);
            }
            return employeesList;
        }

        public static void DeleteEmployee(int employeeID)
        {
            try
            {
                Employe emp = db.Employe.First(x => x.ID == employeeID);
                db.Employe.DeleteOnSubmit(emp);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static void UpdateEmployee(EmpPosition position)
        {
            List<Employe> list = db.Employe.Where(x => x.Position_id == position.ID).ToList();
            foreach (var item in list)
            {
                item.Department_id = position.Department_id;
            }
            db.SubmitChanges();
        }

        public static void UpdateEmployee(Employe employee)
        {
            try
            {
                Employe emp = db.Employe.First(x => x.ID == employee.ID);
                emp.UserNo = employee.UserNo;
                emp.Name = employee.Name;
                emp.SurName = employee.SurName;
                emp.Password = employee.Password;
                emp.isAdmin = employee.isAdmin;
                emp.Birthday = employee.Birthday;
                emp.Adress = employee.Adress;
                emp.Department_id = employee.Department_id;
                emp.Position_id = employee.Position_id;
                emp.Salary = employee.Salary;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdateEmployee(int employe_id, int amount)
        {
            try
            {
                Employe employee = db.Employe.First(x => x.ID == employe_id);
                employee.Salary = amount;
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Employe> GetEmployees(int v, string text)
        {
            try
            {
                List<Employe> list = db.Employe.Where(x => x.UserNo == v && x.Password == text).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Employe> GetUsers(int v)
        {
            return db.Employe.Where(x => x.UserNo == v).ToList();
        }
    }
}
