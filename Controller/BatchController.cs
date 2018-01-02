using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class BatchController
    {
        Batch batch ;
        Discipline disc;
        Student student;
        DisciplineController controller = new DisciplineController();

        public bool BExist(String b) {
            batch = new Batch();
            return batch.batchExists(b);
        }
        public bool BTExists(String b,String term){
            batch = new Batch();

            return batch.Xtra(b,term);
        }

        public Boolean saveBatch(string name, string term, string rollFrom,string rollTo)
        {
            batch = new Batch(name, term);
            batch.create();

            disc = controller.getDiscipline();
            String code = disc.Code;

            int i, num, num1;
            num = Int32.Parse(rollFrom);
            num1 = Int32.Parse(rollTo);
            String s;
            
            try
            {
                for (i = num; i <= num1; i++)
                {
                    if (i <= 9)
                    {
                        s = name + code + "0" + i;

                        student = new Student(s);
                        student.createStudent();
                    }
                    else {
                        s = name + code + i;
                        student = new Student(s);
                        student.createStudent();
                    }

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public String[] batchRecord() {
            return batch.getBatch();
        }
    }
}
