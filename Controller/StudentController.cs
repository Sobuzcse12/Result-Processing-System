using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Controller
{
    public class StudentController
    {
        Student student;

        public void SaveStudentList(Student[] st) {
            int i = 0;
            try
            {
                while (st[i].Roll != null)
                {
                    student = new Student(st[i].Roll);
                    student.createStudent();
                    i++;
                }
            }catch(Exception){}
        }
        public void SaveStudentList(String roll,String name, String credit) {
            student = new Student(roll,name,credit);
            student.createSingleStudent();
        }

        public DataTable getStudentData(String batch) {
            student = new Student();
            return student.getStudent(batch);
        }

        public void updateTable(DataTable dt) {
            student = new Student();
            student.update(dt);
        }

        public bool exists(String roll) {
            student = new Student();
            return student.studentExists(roll);
        }
        public bool SDelete(String roll)
        {
            student = new Student();
            return student.deleteStudent(roll);
        }

        public DataTable getCourseTakenStudentInfoTable(String id) {
            student = new Student();
            return student.getCourseTakenStudentInfo(id);
        }

        public DataTable getCourseTakenStudentInfoSessionalTable(String id) {
            student = new Student();
            return student.getCourseTakenStudentInfoSessional(id);
        }

        public DataTable getStudentGradeTable(DataTable dt, String id, int len) {
            student = new Student();
            return student.getStudentGrade(dt,id,len);
        }
        public DataTable getStudentGradeSessionalTable(DataTable dt, String id, int len) {
            student = new Student();
            return student.getStudentGradeSessional(dt, id, len);
        }
    }
}
