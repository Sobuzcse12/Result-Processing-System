using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;


namespace Controller
{
    public class CourseController
    {
        Course course;
        Student student = new Student();

        public bool saveCourse(String code,String hour, String title,String sessional) {
            course = new Course(code,hour,title,sessional);
            bool flag = course.createCourse();
            return flag;
        }

        public bool CExists(String courseName) {
            course = new Course();
            return course.CourseExists(courseName);
        }

        public DataTable getCourseTakenStudentTable(String c) {
            course = new Course();
            DataTable dt = course.getCourseTakenStudentInfo(c);
            return dt;
        }

        public DataTable getCourseTakenStudentTableSessional(String c)
        {
            course = new Course();
            DataTable dt = course.getCourseTakenStudentInfoSessional(c);
            return dt;
        }

        public String[] getCourseTitle() {
            course = new Course();
            return course.getCourse();
        }

        public DataTable getStudentGradeTable(DataTable dt, String c, int len) {
            course = new Course();
            DataTable table = course.getStudentGrade(dt,c,len);
            return table;
        }
        public DataTable getStudentGradeTableSessional(DataTable dt, String c, int len)
        {
            course = new Course();
            DataTable table = course.getStudentGradeSessional(dt, c, len);
            return table;
        }

        public String[] getStudentCourseList(String roll)
        {
            course = new Course();
            return course.getStudentCourse(roll);
        }

        public String addStudentCourse(String roll,String[] c,int len) {
            course = new Course();
                   
            bool flag;
            String message = student.getStudentCredit(roll);
            String output,sub;
            float totalCredit,credit = 0,studentCredit;

            if (!message.Equals(""))
            {
                for (int i = 0; i < len; i++) { 
                    flag = course.StudentCourseExists(roll, c[i]);

                    if (flag == false)
                    {
                        sub = course.getSubjectCredit(c[i]);
                        credit = credit + float.Parse(sub);
                    }
                }
                studentCredit = course.getStudentTotalCredit(roll);



                totalCredit = float.Parse(message);

                if (totalCredit >= (credit+studentCredit))
                {
                    for (int i = 0; i < len; i++)
                    {
                        flag = course.StudentCourseExists(roll, c[i]);

                        if (flag == false)
                        {
                            flag = course.courseIsTheory(c[i]);
                            if (flag == true)
                                course.saveStudentCourse(roll, c[i]);
                            else
                                course.saveSessionalCourse(roll, c[i]);
                        }
                    }
                    output = "Course Saved!";
                }
                else
                    output = roll+" has total "+totalCredit+" Credit And\n"+roll+" has already "+studentCredit+" Credit,\nU are assigning "+credit+" more Credit.\nPlz Delete Some Course";
            }
            else
                output = "Credit Hour of this student have not assigned yet!";

            return output;
        }
    }
}
