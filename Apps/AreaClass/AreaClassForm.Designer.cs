namespace CS162_Practice10.Apps.AreaClass
{
    partial class AreaClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            calculateArea_Button = new Button();
            circleRadius_TxtBox = new TextBox();
            circle_Label = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rectangleHeight_TxtBox = new TextBox();
            label7 = new Label();
            calculateRectangle_Button = new Button();
            rectangleWidth_TxtBox = new TextBox();
            rectacngle_Label = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            cylinderHeight_TxtBox = new TextBox();
            label3 = new Label();
            calculateCylinder_Button = new Button();
            cylinderRadius_TxtBox = new TextBox();
            cylinder_Label = new Label();
            label8 = new Label();
            label9 = new Label();
            close_Button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(calculateArea_Button);
            groupBox1.Controls.Add(circleRadius_TxtBox);
            groupBox1.Controls.Add(circle_Label);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Circle";
            // 
            // calculateArea_Button
            // 
            calculateArea_Button.Location = new Point(59, 80);
            calculateArea_Button.Name = "calculateArea_Button";
            calculateArea_Button.Size = new Size(75, 23);
            calculateArea_Button.TabIndex = 4;
            calculateArea_Button.Text = "Calculate";
            calculateArea_Button.UseVisualStyleBackColor = true;
            calculateArea_Button.Click += calculateArea_Button_Click;
            // 
            // circleRadius_TxtBox
            // 
            circleRadius_TxtBox.Location = new Point(90, 19);
            circleRadius_TxtBox.Name = "circleRadius_TxtBox";
            circleRadius_TxtBox.Size = new Size(100, 23);
            circleRadius_TxtBox.TabIndex = 3;
            // 
            // circle_Label
            // 
            circle_Label.BackColor = SystemColors.ControlLight;
            circle_Label.Location = new Point(90, 45);
            circle_Label.Name = "circle_Label";
            circle_Label.Size = new Size(100, 23);
            circle_Label.TabIndex = 2;
            circle_Label.Text = "label3";
            circle_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 45);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Area:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Circle Radius:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rectangleHeight_TxtBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(calculateRectangle_Button);
            groupBox2.Controls.Add(rectangleWidth_TxtBox);
            groupBox2.Controls.Add(rectacngle_Label);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 160);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rectangle";
            // 
            // rectangleHeight_TxtBox
            // 
            rectangleHeight_TxtBox.Location = new Point(90, 48);
            rectangleHeight_TxtBox.Name = "rectangleHeight_TxtBox";
            rectangleHeight_TxtBox.Size = new Size(100, 23);
            rectangleHeight_TxtBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 51);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 5;
            label7.Text = "Height";
            // 
            // calculateRectangle_Button
            // 
            calculateRectangle_Button.Location = new Point(59, 119);
            calculateRectangle_Button.Name = "calculateRectangle_Button";
            calculateRectangle_Button.Size = new Size(75, 23);
            calculateRectangle_Button.TabIndex = 4;
            calculateRectangle_Button.Text = "Calculate";
            calculateRectangle_Button.UseVisualStyleBackColor = true;
            calculateRectangle_Button.Click += calculateRectangle_Button_Click;
            // 
            // rectangleWidth_TxtBox
            // 
            rectangleWidth_TxtBox.Location = new Point(90, 19);
            rectangleWidth_TxtBox.Name = "rectangleWidth_TxtBox";
            rectangleWidth_TxtBox.Size = new Size(100, 23);
            rectangleWidth_TxtBox.TabIndex = 3;
            // 
            // rectacngle_Label
            // 
            rectacngle_Label.BackColor = SystemColors.ControlLight;
            rectacngle_Label.Location = new Point(90, 84);
            rectacngle_Label.Name = "rectacngle_Label";
            rectacngle_Label.Size = new Size(100, 23);
            rectacngle_Label.TabIndex = 2;
            rectacngle_Label.Text = "label4";
            rectacngle_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 84);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 1;
            label5.Text = "Area:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 22);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 0;
            label6.Text = "Width";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cylinderHeight_TxtBox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(calculateCylinder_Button);
            groupBox3.Controls.Add(cylinderRadius_TxtBox);
            groupBox3.Controls.Add(cylinder_Label);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(12, 305);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 160);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cylinder";
            // 
            // cylinderHeight_TxtBox
            // 
            cylinderHeight_TxtBox.Location = new Point(90, 48);
            cylinderHeight_TxtBox.Name = "cylinderHeight_TxtBox";
            cylinderHeight_TxtBox.Size = new Size(100, 23);
            cylinderHeight_TxtBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 51);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Height";
            // 
            // calculateCylinder_Button
            // 
            calculateCylinder_Button.Location = new Point(59, 119);
            calculateCylinder_Button.Name = "calculateCylinder_Button";
            calculateCylinder_Button.Size = new Size(75, 23);
            calculateCylinder_Button.TabIndex = 4;
            calculateCylinder_Button.Text = "Calculate";
            calculateCylinder_Button.UseVisualStyleBackColor = true;
            calculateCylinder_Button.Click += calculateCylinder_Button_Click;
            // 
            // cylinderRadius_TxtBox
            // 
            cylinderRadius_TxtBox.Location = new Point(90, 19);
            cylinderRadius_TxtBox.Name = "cylinderRadius_TxtBox";
            cylinderRadius_TxtBox.Size = new Size(100, 23);
            cylinderRadius_TxtBox.TabIndex = 3;
            // 
            // cylinder_Label
            // 
            cylinder_Label.BackColor = SystemColors.ControlLight;
            cylinder_Label.Location = new Point(90, 84);
            cylinder_Label.Name = "cylinder_Label";
            cylinder_Label.Size = new Size(100, 23);
            cylinder_Label.TabIndex = 2;
            cylinder_Label.Text = "label4";
            cylinder_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 84);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 1;
            label8.Text = "Area:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 22);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 0;
            label9.Text = "Radius";
            // 
            // close_Button
            // 
            close_Button.BackColor = Color.Tomato;
            close_Button.ForeColor = SystemColors.Control;
            close_Button.Location = new Point(12, 471);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(200, 23);
            close_Button.TabIndex = 8;
            close_Button.Text = "Close";
            close_Button.UseVisualStyleBackColor = false;
            close_Button.Click += close_Button_Click;
            // 
            // AreaClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 507);
            Controls.Add(close_Button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AreaClass";
            Text = "AreaClass";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button calculateArea_Button;
        private TextBox circleRadius_TxtBox;
        private Label circle_Label;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button calculateRectangle_Button;
        private TextBox rectangleWidth_TxtBox;
        private Label rectacngle_Label;
        private Label label5;
        private Label label6;
        private TextBox rectangleHeight_TxtBox;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox cylinderHeight_TxtBox;
        private Label label3;
        private Button calculateCylinder_Button;
        private TextBox cylinderRadius_TxtBox;
        private Label cylinder_Label;
        private Label label8;
        private Label label9;
        private Button close_Button;
    }
}