namespace CS162_Practice10.Apps.DormMealPlan
{
    public partial class DormMealPlanForm : Form
    {

        Dictionary<string, decimal> Dorms = new Dictionary<string, decimal>();
        Dictionary<string, decimal> mealPlans = new Dictionary<string, decimal>();

        string selectedDorm = "";
        string selectedMeal = "";


        public DormMealPlanForm()
        {
            InitializeComponent();
        }

        private void onForm_Load(object sender, EventArgs e)
        {
            Dorms["Landers Hall"] = 1500m;
            Dorms["Heritage Hall"] = 1600m;
            Dorms["Ackerman Hall"] = 1800m;
            Dorms["Arbor Park"] = 2500m;

            mealPlans["7 Meals Per Week"] = 600m;
            mealPlans["14 Meals Per Week"] = 1200m;
            mealPlans["Unlimited Meals"] = 1700m;

            foreach (var item in Dorms)
            {
                dorm_ListBox.Items.Add(item.Key);
            }

            foreach (var item in mealPlans)
            {
                mealPlan_ListBox.Items.Add(item.Key);
            }
        }

        private void displayInfo(object sender, EventArgs e)
        {
            try
            {
                Form totalCostForm = new TotalCostForm((string)dorm_ListBox.SelectedItem, (decimal)Dorms[(string)dorm_ListBox.SelectedItem], (string)mealPlan_ListBox.SelectedItem, mealPlans[(string)mealPlan_ListBox.SelectedItem]);
                totalCostForm.ShowDialog();
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
