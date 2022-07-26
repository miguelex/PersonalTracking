﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PERSONAL")]
	public partial class EmmployeeDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertEmploye(Employe instance);
    partial void UpdateEmploye(Employe instance);
    partial void DeleteEmploye(Employe instance);
    partial void InsertTasksStates(TasksStates instance);
    partial void UpdateTasksStates(TasksStates instance);
    partial void DeleteTasksStates(TasksStates instance);
    partial void InsertEmpPosition(EmpPosition instance);
    partial void UpdateEmpPosition(EmpPosition instance);
    partial void DeleteEmpPosition(EmpPosition instance);
    partial void InsertMonths(Months instance);
    partial void UpdateMonths(Months instance);
    partial void DeleteMonths(Months instance);
    partial void InsertPermisions(Permisions instance);
    partial void UpdatePermisions(Permisions instance);
    partial void DeletePermisions(Permisions instance);
    partial void InsertPermisionState(PermisionState instance);
    partial void UpdatePermisionState(PermisionState instance);
    partial void DeletePermisionState(PermisionState instance);
    partial void InsertSalary(Salary instance);
    partial void UpdateSalary(Salary instance);
    partial void DeleteSalary(Salary instance);
    partial void InsertTASK(TASK instance);
    partial void UpdateTASK(TASK instance);
    partial void DeleteTASK(TASK instance);
    #endregion
		
		public EmmployeeDataClassDataContext() : 
				base(global::DAL.Properties.Settings.Default.PERSONALConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmmployeeDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmmployeeDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmmployeeDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmmployeeDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department> Department
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Employe> Employe
		{
			get
			{
				return this.GetTable<Employe>();
			}
		}
		
		public System.Data.Linq.Table<TasksStates> TasksStates
		{
			get
			{
				return this.GetTable<TasksStates>();
			}
		}
		
		public System.Data.Linq.Table<EmpPosition> EmpPosition
		{
			get
			{
				return this.GetTable<EmpPosition>();
			}
		}
		
		public System.Data.Linq.Table<Months> Months
		{
			get
			{
				return this.GetTable<Months>();
			}
		}
		
		public System.Data.Linq.Table<Permisions> Permisions
		{
			get
			{
				return this.GetTable<Permisions>();
			}
		}
		
		public System.Data.Linq.Table<PermisionState> PermisionState
		{
			get
			{
				return this.GetTable<PermisionState>();
			}
		}
		
		public System.Data.Linq.Table<Salary> Salary
		{
			get
			{
				return this.GetTable<Salary>();
			}
		}
		
		public System.Data.Linq.Table<TASK> TASK
		{
			get
			{
				return this.GetTable<TASK>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _DepartmentName;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDepartmentNameChanging(string value);
    partial void OnDepartmentNameChanged();
    #endregion
		
		public Department()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentName", DbType="VarChar(50)")]
		public string DepartmentName
		{
			get
			{
				return this._DepartmentName;
			}
			set
			{
				if ((this._DepartmentName != value))
				{
					this.OnDepartmentNameChanging(value);
					this.SendPropertyChanging();
					this._DepartmentName = value;
					this.SendPropertyChanged("DepartmentName");
					this.OnDepartmentNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employe")]
	public partial class Employe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _UserNo;
		
		private string _Name;
		
		private string _SurName;
		
		private string _imgPath;
		
		private System.Nullable<int> _Department_id;
		
		private System.Nullable<int> _Position_id;
		
		private System.Nullable<decimal> _Salary;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private string _Adress;
		
		private string _Password;
		
		private System.Nullable<bool> _isAdmin;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserNoChanging(System.Nullable<int> value);
    partial void OnUserNoChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurNameChanging(string value);
    partial void OnSurNameChanged();
    partial void OnimgPathChanging(string value);
    partial void OnimgPathChanged();
    partial void OnDepartment_idChanging(System.Nullable<int> value);
    partial void OnDepartment_idChanged();
    partial void OnPosition_idChanging(System.Nullable<int> value);
    partial void OnPosition_idChanged();
    partial void OnSalaryChanging(System.Nullable<decimal> value);
    partial void OnSalaryChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnisAdminChanging(System.Nullable<bool> value);
    partial void OnisAdminChanged();
    #endregion
		
		public Employe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNo", DbType="Int")]
		public System.Nullable<int> UserNo
		{
			get
			{
				return this._UserNo;
			}
			set
			{
				if ((this._UserNo != value))
				{
					this.OnUserNoChanging(value);
					this.SendPropertyChanging();
					this._UserNo = value;
					this.SendPropertyChanged("UserNo");
					this.OnUserNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurName", DbType="VarChar(50)")]
		public string SurName
		{
			get
			{
				return this._SurName;
			}
			set
			{
				if ((this._SurName != value))
				{
					this.OnSurNameChanging(value);
					this.SendPropertyChanging();
					this._SurName = value;
					this.SendPropertyChanged("SurName");
					this.OnSurNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imgPath", DbType="VarChar(MAX)")]
		public string imgPath
		{
			get
			{
				return this._imgPath;
			}
			set
			{
				if ((this._imgPath != value))
				{
					this.OnimgPathChanging(value);
					this.SendPropertyChanging();
					this._imgPath = value;
					this.SendPropertyChanged("imgPath");
					this.OnimgPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department_id", DbType="Int")]
		public System.Nullable<int> Department_id
		{
			get
			{
				return this._Department_id;
			}
			set
			{
				if ((this._Department_id != value))
				{
					this.OnDepartment_idChanging(value);
					this.SendPropertyChanging();
					this._Department_id = value;
					this.SendPropertyChanged("Department_id");
					this.OnDepartment_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position_id", DbType="Int")]
		public System.Nullable<int> Position_id
		{
			get
			{
				return this._Position_id;
			}
			set
			{
				if ((this._Position_id != value))
				{
					this.OnPosition_idChanging(value);
					this.SendPropertyChanging();
					this._Position_id = value;
					this.SendPropertyChanged("Position_id");
					this.OnPosition_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="Date")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="VarChar(MAX)")]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(20)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAdmin", DbType="Bit")]
		public System.Nullable<bool> isAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				if ((this._isAdmin != value))
				{
					this.OnisAdminChanging(value);
					this.SendPropertyChanging();
					this._isAdmin = value;
					this.SendPropertyChanged("isAdmin");
					this.OnisAdminChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TasksStates")]
	public partial class TasksStates : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _StateName;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    #endregion
		
		public TasksStates()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="VarChar(50)")]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmpPosition")]
	public partial class EmpPosition : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _PositionName;
		
		private System.Nullable<int> _Department_id;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPositionNameChanging(string value);
    partial void OnPositionNameChanged();
    partial void OnDepartment_idChanging(System.Nullable<int> value);
    partial void OnDepartment_idChanged();
    #endregion
		
		public EmpPosition()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="VarChar(50)")]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this.OnPositionNameChanging(value);
					this.SendPropertyChanging();
					this._PositionName = value;
					this.SendPropertyChanged("PositionName");
					this.OnPositionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department_id", DbType="Int")]
		public System.Nullable<int> Department_id
		{
			get
			{
				return this._Department_id;
			}
			set
			{
				if ((this._Department_id != value))
				{
					this.OnDepartment_idChanging(value);
					this.SendPropertyChanging();
					this._Department_id = value;
					this.SendPropertyChanged("Department_id");
					this.OnDepartment_idChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Months")]
	public partial class Months : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MonthName;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMonthNameChanging(string value);
    partial void OnMonthNameChanged();
    #endregion
		
		public Months()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthName", DbType="VarChar(20)")]
		public string MonthName
		{
			get
			{
				return this._MonthName;
			}
			set
			{
				if ((this._MonthName != value))
				{
					this.OnMonthNameChanging(value);
					this.SendPropertyChanging();
					this._MonthName = value;
					this.SendPropertyChanged("MonthName");
					this.OnMonthNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Permisions")]
	public partial class Permisions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Employe_id;
		
		private System.Nullable<System.DateTime> _PermisionStart;
		
		private System.Nullable<System.DateTime> _PermisionEnd;
		
		private System.Nullable<int> _PermisionState;
		
		private string _PermisionExplanation;
		
		private System.Nullable<int> _permisionDay;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmploye_idChanging(System.Nullable<int> value);
    partial void OnEmploye_idChanged();
    partial void OnPermisionStartChanging(System.Nullable<System.DateTime> value);
    partial void OnPermisionStartChanged();
    partial void OnPermisionEndChanging(System.Nullable<System.DateTime> value);
    partial void OnPermisionEndChanged();
    partial void OnPermisionStateChanging(System.Nullable<int> value);
    partial void OnPermisionStateChanged();
    partial void OnPermisionExplanationChanging(string value);
    partial void OnPermisionExplanationChanged();
    partial void OnpermisionDayChanging(System.Nullable<int> value);
    partial void OnpermisionDayChanged();
    #endregion
		
		public Permisions()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employe_id", DbType="Int")]
		public System.Nullable<int> Employe_id
		{
			get
			{
				return this._Employe_id;
			}
			set
			{
				if ((this._Employe_id != value))
				{
					this.OnEmploye_idChanging(value);
					this.SendPropertyChanging();
					this._Employe_id = value;
					this.SendPropertyChanged("Employe_id");
					this.OnEmploye_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermisionStart", DbType="Date")]
		public System.Nullable<System.DateTime> PermisionStart
		{
			get
			{
				return this._PermisionStart;
			}
			set
			{
				if ((this._PermisionStart != value))
				{
					this.OnPermisionStartChanging(value);
					this.SendPropertyChanging();
					this._PermisionStart = value;
					this.SendPropertyChanged("PermisionStart");
					this.OnPermisionStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermisionEnd", DbType="Date")]
		public System.Nullable<System.DateTime> PermisionEnd
		{
			get
			{
				return this._PermisionEnd;
			}
			set
			{
				if ((this._PermisionEnd != value))
				{
					this.OnPermisionEndChanging(value);
					this.SendPropertyChanging();
					this._PermisionEnd = value;
					this.SendPropertyChanged("PermisionEnd");
					this.OnPermisionEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermisionState", DbType="Int")]
		public System.Nullable<int> PermisionState
		{
			get
			{
				return this._PermisionState;
			}
			set
			{
				if ((this._PermisionState != value))
				{
					this.OnPermisionStateChanging(value);
					this.SendPropertyChanging();
					this._PermisionState = value;
					this.SendPropertyChanged("PermisionState");
					this.OnPermisionStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermisionExplanation", DbType="VarChar(MAX)")]
		public string PermisionExplanation
		{
			get
			{
				return this._PermisionExplanation;
			}
			set
			{
				if ((this._PermisionExplanation != value))
				{
					this.OnPermisionExplanationChanging(value);
					this.SendPropertyChanging();
					this._PermisionExplanation = value;
					this.SendPropertyChanged("PermisionExplanation");
					this.OnPermisionExplanationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_permisionDay", DbType="Int")]
		public System.Nullable<int> permisionDay
		{
			get
			{
				return this._permisionDay;
			}
			set
			{
				if ((this._permisionDay != value))
				{
					this.OnpermisionDayChanging(value);
					this.SendPropertyChanging();
					this._permisionDay = value;
					this.SendPropertyChanged("permisionDay");
					this.OnpermisionDayChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PermisionState")]
	public partial class PermisionState : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _StateName;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    #endregion
		
		public PermisionState()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="VarChar(50)")]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salary")]
	public partial class Salary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Employe_id;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<int> _Year;
		
		private System.Nullable<int> _Month_id;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmploye_idChanging(System.Nullable<int> value);
    partial void OnEmploye_idChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    partial void OnMonth_idChanging(System.Nullable<int> value);
    partial void OnMonth_idChanged();
    #endregion
		
		public Salary()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employe_id", DbType="Int")]
		public System.Nullable<int> Employe_id
		{
			get
			{
				return this._Employe_id;
			}
			set
			{
				if ((this._Employe_id != value))
				{
					this.OnEmploye_idChanging(value);
					this.SendPropertyChanging();
					this._Employe_id = value;
					this.SendPropertyChanged("Employe_id");
					this.OnEmploye_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month_id", DbType="Int")]
		public System.Nullable<int> Month_id
		{
			get
			{
				return this._Month_id;
			}
			set
			{
				if ((this._Month_id != value))
				{
					this.OnMonth_idChanging(value);
					this.SendPropertyChanging();
					this._Month_id = value;
					this.SendPropertyChanged("Month_id");
					this.OnMonth_idChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TASK")]
	public partial class TASK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _EmployeeID;
		
		private string _TaskTitle;
		
		private string _TaskContent;
		
		private System.Nullable<System.DateTime> _TaskStartDate;
		
		private System.Nullable<System.DateTime> _TaskDeliveryDate;
		
		private int _TaskState;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnTaskTitleChanging(string value);
    partial void OnTaskTitleChanged();
    partial void OnTaskContentChanging(string value);
    partial void OnTaskContentChanged();
    partial void OnTaskStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTaskStartDateChanged();
    partial void OnTaskDeliveryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTaskDeliveryDateChanged();
    partial void OnTaskStateChanging(int value);
    partial void OnTaskStateChanged();
    #endregion
		
		public TASK()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int NOT NULL")]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskTitle", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TaskTitle
		{
			get
			{
				return this._TaskTitle;
			}
			set
			{
				if ((this._TaskTitle != value))
				{
					this.OnTaskTitleChanging(value);
					this.SendPropertyChanging();
					this._TaskTitle = value;
					this.SendPropertyChanged("TaskTitle");
					this.OnTaskTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskContent", DbType="VarChar(MAX)")]
		public string TaskContent
		{
			get
			{
				return this._TaskContent;
			}
			set
			{
				if ((this._TaskContent != value))
				{
					this.OnTaskContentChanging(value);
					this.SendPropertyChanging();
					this._TaskContent = value;
					this.SendPropertyChanged("TaskContent");
					this.OnTaskContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskStartDate", DbType="Date")]
		public System.Nullable<System.DateTime> TaskStartDate
		{
			get
			{
				return this._TaskStartDate;
			}
			set
			{
				if ((this._TaskStartDate != value))
				{
					this.OnTaskStartDateChanging(value);
					this.SendPropertyChanging();
					this._TaskStartDate = value;
					this.SendPropertyChanged("TaskStartDate");
					this.OnTaskStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskDeliveryDate", DbType="Date")]
		public System.Nullable<System.DateTime> TaskDeliveryDate
		{
			get
			{
				return this._TaskDeliveryDate;
			}
			set
			{
				if ((this._TaskDeliveryDate != value))
				{
					this.OnTaskDeliveryDateChanging(value);
					this.SendPropertyChanging();
					this._TaskDeliveryDate = value;
					this.SendPropertyChanged("TaskDeliveryDate");
					this.OnTaskDeliveryDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskState", DbType="Int NOT NULL")]
		public int TaskState
		{
			get
			{
				return this._TaskState;
			}
			set
			{
				if ((this._TaskState != value))
				{
					this.OnTaskStateChanging(value);
					this.SendPropertyChanging();
					this._TaskState = value;
					this.SendPropertyChanged("TaskState");
					this.OnTaskStateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
