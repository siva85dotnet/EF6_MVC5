using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPIAngularJS.Models;

namespace WebAPIAngularJS.Controllers
{
    public class StudentController : ApiController
    {
        private SRK_DBEntities db = new SRK_DBEntities();

        // GET api/Student
        public IQueryable<Student> GetStudents()
        {
            return db.Students;
        }

        //public IEnumerable<Student> GetStudents()
        //{
        //    List<Student> stuList = new List<Student>();

        //    foreach (var stu in db.Students)
        //    {
        //        stuList.Add(new Student { EnrollmentDate = stu.EnrollmentDate, Enrollments = stu.Enrollments, FirstName = stu.FirstName, LastName = stu.LastName, MiddleName = stu.MiddleName, StudentID = stu.StudentID });
        //    }

        //    return stuList.AsEnumerable();
        //}

        // GET api/Student/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        //public Student GetStudent(int id)
        //{
        //    Student student = new Student();
        //    var stu = db.Students.Find(id);

        //    student.EnrollmentDate = stu.EnrollmentDate;
        //    student.Enrollments = stu.Enrollments;
        //    student.FirstName = stu.FirstName;
        //    student.LastName = stu.LastName;
        //    student.MiddleName = stu.MiddleName;
        //    student.StudentID = stu.StudentID;

        //    return student;
        //}

        // PUT api/Student/5
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.StudentID)
            {
                return BadRequest();
            }

            db.Entry(student).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Student
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Students.Add(student);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = student.StudentID }, student);
        }

        // DELETE api/Student/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Students.Remove(student);
            db.SaveChanges();

            return Ok(student);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return db.Students.Count(e => e.StudentID == id) > 0;
        }
    }
}