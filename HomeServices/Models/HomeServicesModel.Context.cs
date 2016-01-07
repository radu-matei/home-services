﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeServices.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HomeServicesEntities : DbContext
    {
        public HomeServicesEntities()
            : base("name=HomeServicesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePlanification> EmployeePlanifications { get; set; }
        public virtual DbSet<EmployeeService> EmployeeServices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Service> Services { get; set; }
    
        public virtual ObjectResult<Department> GetDepartments()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department>("GetDepartments");
        }
    
        public virtual ObjectResult<Department> GetDepartments(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department>("GetDepartments", mergeOption);
        }
    
        public virtual ObjectResult<Employee> GetEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("GetEmployees");
        }
    
        public virtual ObjectResult<Employee> GetEmployees(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("GetEmployees", mergeOption);
        }
    
        public virtual ObjectResult<Order> GetOrders()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("GetOrders");
        }
    
        public virtual ObjectResult<Order> GetOrders(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("GetOrders", mergeOption);
        }
    
        public virtual ObjectResult<Service> GetServices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("GetServices");
        }
    
        public virtual ObjectResult<Service> GetServices(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("GetServices", mergeOption);
        }
    
        public virtual ObjectResult<Customer> GetCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("GetCustomers");
        }
    
        public virtual ObjectResult<Customer> GetCustomers(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("GetCustomers", mergeOption);
        }
    
        public virtual ObjectResult<Customer> GetCustomerById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("GetCustomerById", idParameter);
        }
    
        public virtual ObjectResult<Customer> GetCustomerById(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("GetCustomerById", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<Department> GetDepartmentById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department>("GetDepartmentById", idParameter);
        }
    
        public virtual ObjectResult<Department> GetDepartmentById(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department>("GetDepartmentById", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<Employee> GetEmployeeById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("GetEmployeeById", idParameter);
        }
    
        public virtual ObjectResult<Employee> GetEmployeeById(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("GetEmployeeById", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<Order> GetOrderById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("GetOrderById", idParameter);
        }
    
        public virtual ObjectResult<Order> GetOrderById(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("GetOrderById", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<Service> GetServiceById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("GetServiceById", idParameter);
        }
    
        public virtual ObjectResult<Service> GetServiceById(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("GetServiceById", mergeOption, idParameter);
        }
    }
}
