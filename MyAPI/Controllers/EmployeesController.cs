using MyAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebGrease.Css.Ast.Selectors;

namespace MyAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        private testAPiEntities1 db = new testAPiEntities1();

        // GET: api/Employees
        public IQueryable<Employee> GetEmployees()
        {
            return db.Employee;
            
        }

        // GET: api/Employees/1
        public Employee GetEmployee(int id)
        {
            return db.Employee.Find(id);
        }

        // PUT: api/Employees/1
        public HttpResponseMessage PutEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;

            try
            {
                db.SaveChanges();
            } catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
        
        // POST: api/Employees
        public HttpResponseMessage PostEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(employee);
                db.SaveChanges();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, employee);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = employee.id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE: api/Employees/1
        public HttpResponseMessage DeleteEmployee(int id)
        {
            Employee employee_to_remove = db.Employee.Find(id);
            if (employee_to_remove == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db.Employee.Remove(employee_to_remove);
            try
            {
                db.SaveChanges();
            } catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Emloyee deleted Successfully");

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
