﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI_Design_Mockup
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PRIDEProject")]
	public partial class DataConnectionClass : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAward(Award instance);
    partial void UpdateAward(Award instance);
    partial void DeleteAward(Award instance);
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertGroup(Group instance);
    partial void UpdateGroup(Group instance);
    partial void DeleteGroup(Group instance);
    partial void InsertNextID(NextID instance);
    partial void UpdateNextID(NextID instance);
    partial void DeleteNextID(NextID instance);
    partial void InsertPride_Expenditure(Pride_Expenditure instance);
    partial void UpdatePride_Expenditure(Pride_Expenditure instance);
    partial void DeletePride_Expenditure(Pride_Expenditure instance);
    partial void InsertPrize(Prize instance);
    partial void UpdatePrize(Prize instance);
    partial void DeletePrize(Prize instance);
    partial void InsertType_Of_Award(Type_Of_Award instance);
    partial void UpdateType_Of_Award(Type_Of_Award instance);
    partial void DeleteType_Of_Award(Type_Of_Award instance);
    #endregion
		
		public DataConnectionClass() : 
				base(global::GUI_Design_Mockup.Properties.Settings.Default.PRIDEProjectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectionClass(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectionClass(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectionClass(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectionClass(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Award> Awards
		{
			get
			{
				return this.GetTable<Award>();
			}
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Group> Groups
		{
			get
			{
				return this.GetTable<Group>();
			}
		}
		
		public System.Data.Linq.Table<NextID> NextIDs
		{
			get
			{
				return this.GetTable<NextID>();
			}
		}
		
		public System.Data.Linq.Table<Pride_Expenditure> Pride_Expenditures
		{
			get
			{
				return this.GetTable<Pride_Expenditure>();
			}
		}
		
		public System.Data.Linq.Table<Prize> Prizes
		{
			get
			{
				return this.GetTable<Prize>();
			}
		}
		
		public System.Data.Linq.Table<Type_Of_Award> Type_Of_Awards
		{
			get
			{
				return this.GetTable<Type_Of_Award>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Award")]
	public partial class Award : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _AwardID;
		
		private string _AwardTypeID;
		
		private string _RecipientID;
		
		private string _NominatorID;
		
		private System.Nullable<System.DateTime> _AwardDate;
		
		private string _Notes;
		
		private string _AwardDeptID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAwardIDChanging(string value);
    partial void OnAwardIDChanged();
    partial void OnAwardTypeIDChanging(string value);
    partial void OnAwardTypeIDChanged();
    partial void OnRecipientIDChanging(string value);
    partial void OnRecipientIDChanged();
    partial void OnNominatorIDChanging(string value);
    partial void OnNominatorIDChanged();
    partial void OnAwardDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAwardDateChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnAwardDeptIDChanging(string value);
    partial void OnAwardDeptIDChanged();
    #endregion
		
		public Award()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string AwardID
		{
			get
			{
				return this._AwardID;
			}
			set
			{
				if ((this._AwardID != value))
				{
					this.OnAwardIDChanging(value);
					this.SendPropertyChanging();
					this._AwardID = value;
					this.SendPropertyChanged("AwardID");
					this.OnAwardIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardTypeID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string AwardTypeID
		{
			get
			{
				return this._AwardTypeID;
			}
			set
			{
				if ((this._AwardTypeID != value))
				{
					this.OnAwardTypeIDChanging(value);
					this.SendPropertyChanging();
					this._AwardTypeID = value;
					this.SendPropertyChanged("AwardTypeID");
					this.OnAwardTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipientID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string RecipientID
		{
			get
			{
				return this._RecipientID;
			}
			set
			{
				if ((this._RecipientID != value))
				{
					this.OnRecipientIDChanging(value);
					this.SendPropertyChanging();
					this._RecipientID = value;
					this.SendPropertyChanged("RecipientID");
					this.OnRecipientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NominatorID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string NominatorID
		{
			get
			{
				return this._NominatorID;
			}
			set
			{
				if ((this._NominatorID != value))
				{
					this.OnNominatorIDChanging(value);
					this.SendPropertyChanging();
					this._NominatorID = value;
					this.SendPropertyChanged("NominatorID");
					this.OnNominatorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardDate", DbType="Date")]
		public System.Nullable<System.DateTime> AwardDate
		{
			get
			{
				return this._AwardDate;
			}
			set
			{
				if ((this._AwardDate != value))
				{
					this.OnAwardDateChanging(value);
					this.SendPropertyChanging();
					this._AwardDate = value;
					this.SendPropertyChanged("AwardDate");
					this.OnAwardDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NVarChar(MAX)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardDeptID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string AwardDeptID
		{
			get
			{
				return this._AwardDeptID;
			}
			set
			{
				if ((this._AwardDeptID != value))
				{
					this.OnAwardDeptIDChanging(value);
					this.SendPropertyChanging();
					this._AwardDeptID = value;
					this.SendPropertyChanged("AwardDeptID");
					this.OnAwardDeptIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _DeptID;
		
		private string _DeptHeadID;
		
		private string _DeptName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptIDChanging(string value);
    partial void OnDeptIDChanged();
    partial void OnDeptHeadIDChanging(string value);
    partial void OnDeptHeadIDChanged();
    partial void OnDeptNameChanging(string value);
    partial void OnDeptNameChanged();
    #endregion
		
		public Department()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DeptID
		{
			get
			{
				return this._DeptID;
			}
			set
			{
				if ((this._DeptID != value))
				{
					this.OnDeptIDChanging(value);
					this.SendPropertyChanging();
					this._DeptID = value;
					this.SendPropertyChanged("DeptID");
					this.OnDeptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptHeadID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string DeptHeadID
		{
			get
			{
				return this._DeptHeadID;
			}
			set
			{
				if ((this._DeptHeadID != value))
				{
					this.OnDeptHeadIDChanging(value);
					this.SendPropertyChanging();
					this._DeptHeadID = value;
					this.SendPropertyChanged("DeptHeadID");
					this.OnDeptHeadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptName", DbType="VarChar(50)")]
		public string DeptName
		{
			get
			{
				return this._DeptName;
			}
			set
			{
				if ((this._DeptName != value))
				{
					this.OnDeptNameChanging(value);
					this.SendPropertyChanging();
					this._DeptName = value;
					this.SendPropertyChanged("DeptName");
					this.OnDeptNameChanged();
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

        public override string ToString()
        {
            return this.DeptName;
        }
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _EmployeeID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.Nullable<char> _MiddleInitial;
		
		private string _Title;
		
		private string _PreferredName;
		
		private string _DeptID;
		
		private string _GroupID;
		
		private System.Nullable<System.DateTime> _HireDate;
		
		private System.Nullable<bool> _IsDirector;
		
		private string _HR_Status;
		
		private string _EmployeeStatusCode;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<bool> _PrideEligible;
		
		private System.Nullable<bool> _DeptRecord;
		
		private System.Nullable<System.DateTime> _DateLastUpdated;
		
		private System.Nullable<int> _OldAwardCount;
		
		private System.Nullable<double> _HR_FTE;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(string value);
    partial void OnEmployeeIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnMiddleInitialChanging(System.Nullable<char> value);
    partial void OnMiddleInitialChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnPreferredNameChanging(string value);
    partial void OnPreferredNameChanged();
    partial void OnDeptIDChanging(string value);
    partial void OnDeptIDChanged();
    partial void OnGroupIDChanging(string value);
    partial void OnGroupIDChanged();
    partial void OnHireDateChanging(System.Nullable<System.DateTime> value);
    partial void OnHireDateChanged();
    partial void OnIsDirectorChanging(System.Nullable<bool> value);
    partial void OnIsDirectorChanged();
    partial void OnHR_StatusChanging(string value);
    partial void OnHR_StatusChanged();
    partial void OnEmployeeStatusCodeChanging(string value);
    partial void OnEmployeeStatusCodeChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnPrideEligibleChanging(System.Nullable<bool> value);
    partial void OnPrideEligibleChanged();
    partial void OnDeptRecordChanging(System.Nullable<bool> value);
    partial void OnDeptRecordChanged();
    partial void OnDateLastUpdatedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateLastUpdatedChanged();
    partial void OnOldAwardCountChanging(System.Nullable<int> value);
    partial void OnOldAwardCountChanged();
    partial void OnHR_FTEChanging(System.Nullable<double> value);
    partial void OnHR_FTEChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EmployeeID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(30)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(30)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleInitial", DbType="Char(1)")]
		public System.Nullable<char> MiddleInitial
		{
			get
			{
				return this._MiddleInitial;
			}
			set
			{
				if ((this._MiddleInitial != value))
				{
					this.OnMiddleInitialChanging(value);
					this.SendPropertyChanging();
					this._MiddleInitial = value;
					this.SendPropertyChanged("MiddleInitial");
					this.OnMiddleInitialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PreferredName", DbType="VarChar(30)")]
		public string PreferredName
		{
			get
			{
				return this._PreferredName;
			}
			set
			{
				if ((this._PreferredName != value))
				{
					this.OnPreferredNameChanging(value);
					this.SendPropertyChanging();
					this._PreferredName = value;
					this.SendPropertyChanged("PreferredName");
					this.OnPreferredNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string DeptID
		{
			get
			{
				return this._DeptID;
			}
			set
			{
				if ((this._DeptID != value))
				{
					this.OnDeptIDChanging(value);
					this.SendPropertyChanging();
					this._DeptID = value;
					this.SendPropertyChanged("DeptID");
					this.OnDeptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string GroupID
		{
			get
			{
				return this._GroupID;
			}
			set
			{
				if ((this._GroupID != value))
				{
					this.OnGroupIDChanging(value);
					this.SendPropertyChanging();
					this._GroupID = value;
					this.SendPropertyChanged("GroupID");
					this.OnGroupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HireDate", DbType="Date")]
		public System.Nullable<System.DateTime> HireDate
		{
			get
			{
				return this._HireDate;
			}
			set
			{
				if ((this._HireDate != value))
				{
					this.OnHireDateChanging(value);
					this.SendPropertyChanging();
					this._HireDate = value;
					this.SendPropertyChanged("HireDate");
					this.OnHireDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDirector", DbType="Bit")]
		public System.Nullable<bool> IsDirector
		{
			get
			{
				return this._IsDirector;
			}
			set
			{
				if ((this._IsDirector != value))
				{
					this.OnIsDirectorChanging(value);
					this.SendPropertyChanging();
					this._IsDirector = value;
					this.SendPropertyChanged("IsDirector");
					this.OnIsDirectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HR_Status", DbType="VarChar(10)")]
		public string HR_Status
		{
			get
			{
				return this._HR_Status;
			}
			set
			{
				if ((this._HR_Status != value))
				{
					this.OnHR_StatusChanging(value);
					this.SendPropertyChanging();
					this._HR_Status = value;
					this.SendPropertyChanged("HR_Status");
					this.OnHR_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeStatusCode", DbType="VarChar(10)")]
		public string EmployeeStatusCode
		{
			get
			{
				return this._EmployeeStatusCode;
			}
			set
			{
				if ((this._EmployeeStatusCode != value))
				{
					this.OnEmployeeStatusCodeChanging(value);
					this.SendPropertyChanging();
					this._EmployeeStatusCode = value;
					this.SendPropertyChanged("EmployeeStatusCode");
					this.OnEmployeeStatusCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrideEligible", DbType="Bit")]
		public System.Nullable<bool> PrideEligible
		{
			get
			{
				return this._PrideEligible;
			}
			set
			{
				if ((this._PrideEligible != value))
				{
					this.OnPrideEligibleChanging(value);
					this.SendPropertyChanging();
					this._PrideEligible = value;
					this.SendPropertyChanged("PrideEligible");
					this.OnPrideEligibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptRecord", DbType="Bit")]
		public System.Nullable<bool> DeptRecord
		{
			get
			{
				return this._DeptRecord;
			}
			set
			{
				if ((this._DeptRecord != value))
				{
					this.OnDeptRecordChanging(value);
					this.SendPropertyChanging();
					this._DeptRecord = value;
					this.SendPropertyChanged("DeptRecord");
					this.OnDeptRecordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateLastUpdated", DbType="Date")]
		public System.Nullable<System.DateTime> DateLastUpdated
		{
			get
			{
				return this._DateLastUpdated;
			}
			set
			{
				if ((this._DateLastUpdated != value))
				{
					this.OnDateLastUpdatedChanging(value);
					this.SendPropertyChanging();
					this._DateLastUpdated = value;
					this.SendPropertyChanged("DateLastUpdated");
					this.OnDateLastUpdatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OldAwardCount", DbType="Int")]
		public System.Nullable<int> OldAwardCount
		{
			get
			{
				return this._OldAwardCount;
			}
			set
			{
				if ((this._OldAwardCount != value))
				{
					this.OnOldAwardCountChanging(value);
					this.SendPropertyChanging();
					this._OldAwardCount = value;
					this.SendPropertyChanged("OldAwardCount");
					this.OnOldAwardCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HR_FTE", DbType="Float")]
		public System.Nullable<double> HR_FTE
		{
			get
			{
				return this._HR_FTE;
			}
			set
			{
				if ((this._HR_FTE != value))
				{
					this.OnHR_FTEChanging(value);
					this.SendPropertyChanging();
					this._HR_FTE = value;
					this.SendPropertyChanged("HR_FTE");
					this.OnHR_FTEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
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

        public override string ToString()
        {
            if (EmployeeID.Equals("EMP0000000"))
                return "All Employees";
            else if (EmployeeID.Equals("EMP-000001"))
                return "Choose an employee";
            else
                return this.LastName + ", " + this.PreferredName + " " + this.MiddleInitial;

        }
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Group]")]
	public partial class Group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _GroupID;
		
		private string _GroupNum;
		
		private System.Nullable<char> _DayOfPride;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGroupIDChanging(string value);
    partial void OnGroupIDChanged();
    partial void OnGroupNumChanging(string value);
    partial void OnGroupNumChanged();
    partial void OnDayOfPrideChanging(System.Nullable<char> value);
    partial void OnDayOfPrideChanged();
    #endregion
		
		public Group()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string GroupID
		{
			get
			{
				return this._GroupID;
			}
			set
			{
				if ((this._GroupID != value))
				{
					this.OnGroupIDChanging(value);
					this.SendPropertyChanging();
					this._GroupID = value;
					this.SendPropertyChanged("GroupID");
					this.OnGroupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupNum", DbType="VarChar(20)")]
		public string GroupNum
		{
			get
			{
				return this._GroupNum;
			}
			set
			{
				if ((this._GroupNum != value))
				{
					this.OnGroupNumChanging(value);
					this.SendPropertyChanging();
					this._GroupNum = value;
					this.SendPropertyChanged("GroupNum");
					this.OnGroupNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DayOfPride", DbType="Char(1)")]
		public System.Nullable<char> DayOfPride
		{
			get
			{
				return this._DayOfPride;
			}
			set
			{
				if ((this._DayOfPride != value))
				{
					this.OnDayOfPrideChanging(value);
					this.SendPropertyChanging();
					this._DayOfPride = value;
					this.SendPropertyChanged("DayOfPride");
					this.OnDayOfPrideChanged();
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

        public override string ToString()
        {
           return this.GroupNum;
        }
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NextID")]
	public partial class NextID : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TableName;
		
		private System.Nullable<int> _NextNum;
		
		private string _Prefix;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTableNameChanging(string value);
    partial void OnTableNameChanged();
    partial void OnNextNumChanging(System.Nullable<int> value);
    partial void OnNextNumChanged();
    partial void OnPrefixChanging(string value);
    partial void OnPrefixChanged();
    #endregion
		
		public NextID()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TableName", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TableName
		{
			get
			{
				return this._TableName;
			}
			set
			{
				if ((this._TableName != value))
				{
					this.OnTableNameChanging(value);
					this.SendPropertyChanging();
					this._TableName = value;
					this.SendPropertyChanged("TableName");
					this.OnTableNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NextNum", DbType="Int")]
		public System.Nullable<int> NextNum
		{
			get
			{
				return this._NextNum;
			}
			set
			{
				if ((this._NextNum != value))
				{
					this.OnNextNumChanging(value);
					this.SendPropertyChanging();
					this._NextNum = value;
					this.SendPropertyChanged("NextNum");
					this.OnNextNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prefix", DbType="Char(3)")]
		public string Prefix
		{
			get
			{
				return this._Prefix;
			}
			set
			{
				if ((this._Prefix != value))
				{
					this.OnPrefixChanging(value);
					this.SendPropertyChanging();
					this._Prefix = value;
					this.SendPropertyChanged("Prefix");
					this.OnPrefixChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pride_Expenditure")]
	public partial class Pride_Expenditure : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TransactionID;
		
		private string _EmployeeID;
		
		private string _PrizeID;
		
		private System.Nullable<int> _Cost;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(string value);
    partial void OnTransactionIDChanged();
    partial void OnEmployeeIDChanging(string value);
    partial void OnEmployeeIDChanged();
    partial void OnPrizeIDChanging(string value);
    partial void OnPrizeIDChanged();
    partial void OnCostChanging(System.Nullable<int> value);
    partial void OnCostChanged();
    #endregion
		
		public Pride_Expenditure()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TransactionID
		{
			get
			{
				return this._TransactionID;
			}
			set
			{
				if ((this._TransactionID != value))
				{
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._TransactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string EmployeeID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrizeID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string PrizeID
		{
			get
			{
				return this._PrizeID;
			}
			set
			{
				if ((this._PrizeID != value))
				{
					this.OnPrizeIDChanging(value);
					this.SendPropertyChanging();
					this._PrizeID = value;
					this.SendPropertyChanged("PrizeID");
					this.OnPrizeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Int")]
		public System.Nullable<int> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prize")]
	public partial class Prize : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PrizeID;
		
		private string _PrizeName;
		
		private System.Nullable<int> _Cost;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPrizeIDChanging(string value);
    partial void OnPrizeIDChanged();
    partial void OnPrizeNameChanging(string value);
    partial void OnPrizeNameChanged();
    partial void OnCostChanging(System.Nullable<int> value);
    partial void OnCostChanged();
    #endregion
		
		public Prize()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrizeID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PrizeID
		{
			get
			{
				return this._PrizeID;
			}
			set
			{
				if ((this._PrizeID != value))
				{
					this.OnPrizeIDChanging(value);
					this.SendPropertyChanging();
					this._PrizeID = value;
					this.SendPropertyChanged("PrizeID");
					this.OnPrizeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrizeName", DbType="VarChar(50)")]
		public string PrizeName
		{
			get
			{
				return this._PrizeName;
			}
			set
			{
				if ((this._PrizeName != value))
				{
					this.OnPrizeNameChanging(value);
					this.SendPropertyChanging();
					this._PrizeName = value;
					this.SendPropertyChanged("PrizeName");
					this.OnPrizeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Int")]
		public System.Nullable<int> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Type_Of_Award")]
	public partial class Type_Of_Award : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _AwardTypeID;
		
		private string _AwardTypeName;
		
		private System.Nullable<bool> _IsNomination;
		
		private string _Frequency;
		
		private string _AwardNominationID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAwardTypeIDChanging(string value);
    partial void OnAwardTypeIDChanged();
    partial void OnAwardTypeNameChanging(string value);
    partial void OnAwardTypeNameChanged();
    partial void OnIsNominationChanging(System.Nullable<bool> value);
    partial void OnIsNominationChanged();
    partial void OnFrequencyChanging(string value);
    partial void OnFrequencyChanged();
    partial void OnAwardNominationIDChanging(string value);
    partial void OnAwardNominationIDChanged();
    #endregion
		
		public Type_Of_Award()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardTypeID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string AwardTypeID
		{
			get
			{
				return this._AwardTypeID;
			}
			set
			{
				if ((this._AwardTypeID != value))
				{
					this.OnAwardTypeIDChanging(value);
					this.SendPropertyChanging();
					this._AwardTypeID = value;
					this.SendPropertyChanged("AwardTypeID");
					this.OnAwardTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardTypeName", DbType="VarChar(20)")]
		public string AwardTypeName
		{
			get
			{
				return this._AwardTypeName;
			}
			set
			{
				if ((this._AwardTypeName != value))
				{
					this.OnAwardTypeNameChanging(value);
					this.SendPropertyChanging();
					this._AwardTypeName = value;
					this.SendPropertyChanged("AwardTypeName");
					this.OnAwardTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsNomination", DbType="Bit")]
		public System.Nullable<bool> IsNomination
		{
			get
			{
				return this._IsNomination;
			}
			set
			{
				if ((this._IsNomination != value))
				{
					this.OnIsNominationChanging(value);
					this.SendPropertyChanging();
					this._IsNomination = value;
					this.SendPropertyChanged("IsNomination");
					this.OnIsNominationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frequency", DbType="VarChar(20)")]
		public string Frequency
		{
			get
			{
				return this._Frequency;
			}
			set
			{
				if ((this._Frequency != value))
				{
					this.OnFrequencyChanging(value);
					this.SendPropertyChanging();
					this._Frequency = value;
					this.SendPropertyChanged("Frequency");
					this.OnFrequencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwardNominationID", DbType="Char(10)")]
		public string AwardNominationID
		{
			get
			{
				return this._AwardNominationID;
			}
			set
			{
				if ((this._AwardNominationID != value))
				{
					this.OnAwardNominationIDChanging(value);
					this.SendPropertyChanging();
					this._AwardNominationID = value;
					this.SendPropertyChanged("AwardNominationID");
					this.OnAwardNominationIDChanged();
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

        public override string ToString()
        {
            return AwardTypeName;
        }
	}
}
#pragma warning restore 1591
