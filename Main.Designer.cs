namespace CS162_Practice10
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            employeeForm_Button = new Button();
            dormMeal_Button = new Button();
            SuspendLayout();
            // 
            // employeeForm_Button
            // 
            employeeForm_Button.Location = new Point(12, 12);
            employeeForm_Button.Name = "employeeForm_Button";
            employeeForm_Button.Size = new Size(233, 23);
            employeeForm_Button.TabIndex = 0;
            employeeForm_Button.Text = "Employee Form";
            employeeForm_Button.UseVisualStyleBackColor = true;
            employeeForm_Button.Click += employeeForm_Button_Click;
            // 
            // dormMeal_Button
            // 
            dormMeal_Button.Location = new Point(12, 41);
            dormMeal_Button.Name = "dormMeal_Button";
            dormMeal_Button.Size = new Size(233, 23);
            dormMeal_Button.TabIndex = 1;
            dormMeal_Button.Text = "Dorm and Meal  Form";
            dormMeal_Button.UseVisualStyleBackColor = true;
            dormMeal_Button.Click += dormMeal_Button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 321);
            Controls.Add(dormMeal_Button);
            Controls.Add(employeeForm_Button);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button employeeForm_Button;
        private Button dormMeal_Button;
    }
}
