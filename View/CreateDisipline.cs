using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class CreateDisipline : Form
    {
        DisciplineController controller = new DisciplineController();

        public CreateDisipline()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreateDiscipline_Save_Btn_Click(object sender, EventArgs e)
        {
            String name = CreateDiscipline_DisciplineName_txt.Text;
            String session = CreateDiscipline_AcademicSession_txt.Text;
            String code = CreateDiscipline_DisciplineCode_txt.Text;

            if (name.Equals("") || session.Equals("") || code.Equals("")) return;

            try
            { 
                bool flag = controller.DExists();
                if (flag == false)
                {
                    controller.saveDiscipline(name, session, code);
                    MessageBox.Show("Discipline Saved !");
                    CreateDiscipline_DisciplineName_txt.Text = "";
                    CreateDiscipline_AcademicSession_txt.Text = "";
                    CreateDiscipline_DisciplineCode_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("One Discipline has already been created");
                    CreateDiscipline_DisciplineName_txt.Text = "";
                    CreateDiscipline_AcademicSession_txt.Text = "";
                    CreateDiscipline_DisciplineCode_txt.Text = "";
                }
            }catch(Exception){}
        }

        private void CreateDiscipline_Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateDiscipline_Delete_Btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete existing discipline And its all information?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                controller.deleteAllData();
            }
        }
    }
}
