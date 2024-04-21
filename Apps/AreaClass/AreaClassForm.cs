namespace CS162_Practice10.Apps.AreaClass
{
    public partial class AreaClassForm : Form
    {
        public AreaClassForm()
        {
            InitializeComponent();
        }
        private void calculateArea_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double circleRadius = double.Parse(circleRadius_TxtBox.Text);

                circle_Label.Text = geometricShapes.getArea(circleRadius).ToString("f2");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateRectangle_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double rectangleWidth = double.Parse(rectangleWidth_TxtBox.Text);
                double rectangleHeight = double.Parse(rectangleHeight_TxtBox.Text);

               rectacngle_Label.Text = geometricShapes.getArea(rectangleWidth, rectangleHeight).ToString("f2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateCylinder_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double cylinderRadius = double.Parse(cylinderRadius_TxtBox.Text);
                double cylinderHeight = double.Parse(cylinderHeight_TxtBox.Text);

                cylinder_Label.Text = geometricShapes.getArea(cylinderRadius, cylinderRadius, Math.PI).ToString("f2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
