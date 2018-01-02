using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class DisciplineController
    {
        Discipline discipline;
        public Boolean saveDiscipline(string name, string session, string code)
        {
            discipline = new Discipline(name, session, code);
            return discipline.create();
        }
        public Discipline getDiscipline()
        {
            return Discipline.getDiscipline();
        }
        public bool DExists() {
            discipline = new Discipline();
            return discipline.DisciplineExists();
        }
        public void deleteAllData() {
            discipline = new Discipline();
            Batch batch = new Batch();
            Course course = new Course();
            Student student = new Student();

            student.deleteAllStudent();
            course.deleteAllCourse();
            course.deleteStudentCourseTable();
            batch.deleteAllBatch();
            discipline.deleteDiscipline();
        }
    }
}
