using System;
using System.Linq;
using System.Web.Mvc;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IServiceTrainee _serviceStudent;
        private readonly IServiceEmployee _serviceTeacher;
        private readonly IServiceEmployeeHistory _serviceTeacherChange;

        public TeacherController(IServiceEmployeeHistory serviceTeacherChange, IServiceEmployee serviceTeacher, IServiceTrainee serviceStudent)
        {
            _serviceTeacherChange = serviceTeacherChange;
            _serviceTeacher = serviceTeacher;
            _serviceStudent = serviceStudent;
        }

        public ActionResult Edit(int id)
        {
            int studentId = id;
            var student = _serviceStudent.GetById(studentId);
            int teacherId= student.EmployeeHistories.OrderByDescending(x=> x.Date).FirstOrDefault().EmployeeId;
            
            TeacherLogModel teacherLogModel = new TeacherLogModel()
            {
                Description= _serviceTeacherChange.GetByTeacherId(teacherId).Description,
                StudentId = student.Id,
                TeacherId = teacherId,
                ModifiedDate = DateTime.Now,
                Teachers = _serviceTeacher.GetAll().ToList()
            };            

            return View(teacherLogModel);
        }

        [HttpPost]
        public ActionResult Edit(TeacherLogModel model)
        {
            EmployeeHistory teacherLog = new EmployeeHistory()
            {
                Description = model.Description,
                Date = model.ModifiedDate,
                EmployeeId = model.TeacherId,
                TraineeId = model.StudentId,
                IsDeleted = false
            };
            _serviceTeacherChange.Insert(teacherLog);

            var student = _serviceStudent.GetById(model.StudentId);
            student.EmployeeHistories.OrderByDescending(x=>x.Date).FirstOrDefault().EmployeeId = model.TeacherId;
            _serviceStudent.Update(student);

            return RedirectToAction("StudentInterviews","Interview");
        }
	}
}//studentteacherdetail