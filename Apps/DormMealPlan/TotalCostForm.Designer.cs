namespace CS162_Practice10.Apps.DormMealPlan
{
    partial class TotalCostForm
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
            dorm_Label = new Label();
            groupBox2 = new GroupBox();
            dormCost_Label = new Label();
            groupBox3 = new GroupBox();
            meal_Label = new Label();
            groupBox4 = new GroupBox();
            mealCost_Label = new Label();
            groupBox5 = new GroupBox();
            total_Label = new Label();
            close_Button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dorm_Label);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dorm";
            // 
            // dorm_Label
            // 
            dorm_Label.BackColor = SystemColors.ControlLight;
            dorm_Label.Location = new Point(6, 19);
            dorm_Label.Name = "dorm_Label";
            dorm_Label.Size = new Size(188, 26);
            dorm_Label.TabIndex = 0;
            dorm_Label.Text = "label1";
            dorm_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dormCost_Label);
            groupBox2.Location = new Point(12, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 52);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dorm Cost";
            // 
            // dormCost_Label
            // 
            dormCost_Label.BackColor = SystemColors.ControlLight;
            dormCost_Label.Location = new Point(6, 19);
            dormCost_Label.Name = "dormCost_Label";
            dormCost_Label.Size = new Size(188, 26);
            dormCost_Label.TabIndex = 0;
            dormCost_Label.Text = "label2";
            dormCost_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(meal_Label);
            groupBox3.Location = new Point(12, 128);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 52);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Meal Plan";
            // 
            // meal_Label
            // 
            meal_Label.BackColor = SystemColors.ControlLight;
            meal_Label.Location = new Point(6, 19);
            meal_Label.Name = "meal_Label";
            meal_Label.Size = new Size(188, 26);
            meal_Label.TabIndex = 0;
            meal_Label.Text = "label3";
            meal_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(mealCost_Label);
            groupBox4.Location = new Point(12, 186);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 52);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Meal Plan Cost";
            // 
            // mealCost_Label
            // 
            mealCost_Label.BackColor = SystemColors.ControlLight;
            mealCost_Label.Location = new Point(6, 19);
            mealCost_Label.Name = "mealCost_Label";
            mealCost_Label.Size = new Size(188, 26);
            mealCost_Label.TabIndex = 0;
            mealCost_Label.Text = "label4";
            mealCost_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(total_Label);
            groupBox5.Location = new Point(12, 244);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 52);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Total";
            // 
            // total_Label
            // 
            total_Label.BackColor = SystemColors.ControlLight;
            total_Label.Location = new Point(6, 19);
            total_Label.Name = "total_Label";
            total_Label.Size = new Size(188, 26);
            total_Label.TabIndex = 0;
            total_Label.Text = "label5";
            total_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // close_Button
            // 
            close_Button.BackColor = Color.IndianRed;
            close_Button.ForeColor = Color.White;
            close_Button.Location = new Point(72, 302);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(75, 23);
            close_Button.TabIndex = 3;
            close_Button.Text = "Close";
            close_Button.UseVisualStyleBackColor = false;
            close_Button.Click += close_Button_Click;
            // 
            // TotalCostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 335);
            Controls.Add(close_Button);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TotalCostForm";
            Text = "TotalCostForm";
            Load += onForm_Lod;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label dorm_Label;
        private GroupBox groupBox2;
        private Label dormCost_Label;
        private GroupBox groupBox3;
        private Label meal_Label;
        private GroupBox groupBox4;
        private Label mealCost_Label;
        private GroupBox groupBox5;
        private Label total_Label;
        private Button close_Button;
    }
}