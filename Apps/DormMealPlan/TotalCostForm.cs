namespace CS162_Practice10.Apps.DormMealPlan
{
    public partial class TotalCostForm : Form
    {
        private string Dorm = "";
        private decimal DormCost = 0m;
        private string MealPlan = "";
        private decimal MealCost = 0m;

        public TotalCostForm(string dorm, decimal dormCost, string meal, decimal mealCost)
        {
            Dorm = dorm;
            DormCost = dormCost;
            MealPlan = meal;
            MealCost = mealCost;
            InitializeComponent();
        }

        private void onForm_Lod(object sender, EventArgs e)
        {
            dorm_Label.Text = Dorm;
            dormCost_Label.Text = DormCost.ToString("c");
            meal_Label.Text = MealPlan;
            mealCost_Label.Text = MealCost.ToString("c");
            total_Label.Text = (DormCost + MealCost).ToString("c");
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
