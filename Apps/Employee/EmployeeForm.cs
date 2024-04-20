namespace CS162_Practice10.Apps.Employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>();

        private void onForm_Load(object sender, EventArgs e)
        {
            employees.Add(new Employee("Susan Meyers", 47899, "Accounting", "Vice President"));
            employees.Add(new Employee("Mark Jones", 39119, "IT", "Programmer"));
            employees.Add(new Employee("Joy Rodgers", 8177, "Manufacturing", "Enineer"));

            int index = 1;
            employees.ForEach(e => {
                listBox.Items.Add($"Object {index} \n");
                listBox.Items.Add($"\t Name: {e.Name}");
                listBox.Items.Add($"\t ID: {e.IdNumber}");
                listBox.Items.Add($"\t Dept: {e.Department}");
                listBox.Items.Add($"\t Position: {e.Position}");
                index += 1;
            });
        }
    }
}
