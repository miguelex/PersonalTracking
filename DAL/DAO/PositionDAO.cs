﻿using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PositionDAO : EmployeeContext
    {
        public static void AddPosition(EmpPosition position)
        {
            try
            {
                db.EmpPosition.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PositionDTO> GetPositions()
        {
            try
            {
                var list = (from p in db.EmpPosition
                            join d in db.Department on p.Department_id equals d.ID
                            select new
                            {
                                PositionId = p.ID,
                                PositionName = p.PositionName,
                                DepartmentName = d.DepartmentName,
                                DepartmentId = d.ID
                            }).OrderBy(x => x.PositionId).ToList();
                List<PositionDTO> positions = new List<PositionDTO>();
                foreach (var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.ID = item.PositionId;
                    dto.PositionName = item.PositionName;
                    dto.DepartmentName = item.DepartmentName;
                    dto.Department_id = item.DepartmentId;
                    positions.Add(dto);
                }
                return positions;
            }
            catch (Exception ex )
            {

                throw ex;
            }
                
        }
    }
}