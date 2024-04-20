namespace CS162_Practice10.Apps.AreaClass
{
    public partial class AreaClassForm : Form
    {
        public AreaClassForm()
        {
            InitializeComponent();
        }
        geometricShapes geoShapes = new geometricShapes();
        private void calculateArea_Button_Click(object sender, EventArgs e)
        {
            try
            {
               circle_Label.Text = ();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateRectangle_Button_Click(object sender, EventArgs e)
        {
            try
            {

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
