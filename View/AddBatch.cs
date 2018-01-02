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
using Model;

namespace View
{
    public partial class AddBatch : Form
    {

        Discipline disc = new Discipline();
        DisciplineController controller = new DisciplineController();
        BatchController bController = new BatchController();

        public AddBatch()
        {
            InitializeComponent();
        }

        private void AddBatch_Load(object sender, EventArgs e)
        {
            disc = controller.getDiscipline();
            AddBatch_Discipline_label.Text = disc.Name;
        }

        private void AddBatch_Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBatch_Save_Btn_Click(object sender, EventArgs e)
        {
            String name = AddBatch_Batch_Txt.Text;
            String term = AddBatch_Term_ComboBox.Text;
            String rollFrom = AddBatch_RollFrom_Txt.Text;
            String rollTo = AddBatch_RollTo_Txt.Text;

            if (name.Equals("") || term.Equals("") || rollFrom.Equals("") || rollTo.Equals("")) {
                return;
            }

            DisciplineController disc = new DisciplineController();

            bool f = disc.DExists();
            if (f == true)
            {
                bool flag = bController.BExist(name);

                if (flag == false)
                {
                    bController.saveBatch(name, term, rollFrom, rollTo);
                    MessageBox.Show("Batch Inserted !");
                    AddBatch_Batch_Txt.Text = "";
                    AddBatch_Term_ComboBox.Text = "";
                    AddBatch_RollFrom_Txt.Text = "";
                    AddBatch_RollTo_Txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Batch Name Already Exists ! Plz Retry with another Batch Name");
                }
            }
            else
            {
                MessageBox.Show("You have not created any Discipline yet !!!", "Warning", MessageBoxButtons.OK);
                AddBatch_Batch_Txt.Text = "";
                AddBatch_Term_ComboBox.Text = "";
                AddBatch_RollFrom_Txt.Text = "";
                AddBatch_RollTo_Txt.Text = "";
            }
        }
    }
}
