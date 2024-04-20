using CS162_Practice10.Apps.DormMealPlan;
using CS162_Practice10.Apps.Employee;

namespace CS162_Practice10
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void employeeForm_Button_Click(object sender, EventArgs e)
        {
            Form employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();

        }

        private void dormMeal_Button_Click(object sender, EventArgs e)
        {
            Form dormMealForm = new DormMealPlanForm();
            dormMealForm.ShowDialog();

        }
    }
}
