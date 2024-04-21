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
            areaClass_Button = new Button();
            exit_Button = new Button();
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
            // areaClass_Button
            // 
            areaClass_Button.Location = new Point(12, 70);
            areaClass_Button.Name = "areaClass_Button";
            areaClass_Button.Size = new Size(233, 23);
            areaClass_Button.TabIndex = 2;
            areaClass_Button.Text = "Area Class";
            areaClass_Button.UseVisualStyleBackColor = true;
            areaClass_Button.Click += areaClass_Button_Click;
            // 
            // exit_Button
            // 
            exit_Button.BackColor = Color.Tomato;
            exit_Button.ForeColor = SystemColors.Control;
            exit_Button.Location = new Point(12, 99);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(233, 23);
            exit_Button.TabIndex = 3;
            exit_Button.Text = "EXIT";
            exit_Button.UseVisualStyleBackColor = false;
            exit_Button.Click += exit_Button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 133);
            Controls.Add(exit_Button);
            Controls.Add(areaClass_Button);
            Controls.Add(dormMeal_Button);
            Controls.Add(employeeForm_Button);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button employeeForm_Button;
        private Button dormMeal_Button;
        private Button areaClass_Button;
        private Button exit_Button;
    }
}
