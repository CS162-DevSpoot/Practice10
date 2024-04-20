namespace CS162_Practice10.Apps.DormMealPlan
{
    partial class DormMealPlanForm
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
            dorm_ListBox = new ListBox();
            groupBox2 = new GroupBox();
            mealPlan_ListBox = new ListBox();
            display_Button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dorm_ListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dorm:";
            // 
            // dorm_ListBox
            // 
            dorm_ListBox.FormattingEnabled = true;
            dorm_ListBox.ItemHeight = 15;
            dorm_ListBox.Location = new Point(6, 22);
            dorm_ListBox.Name = "dorm_ListBox";
            dorm_ListBox.Size = new Size(239, 184);
            dorm_ListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mealPlan_ListBox);
            groupBox2.Location = new Point(282, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 217);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Meal Plan";
            // 
            // mealPlan_ListBox
            // 
            mealPlan_ListBox.FormattingEnabled = true;
            mealPlan_ListBox.ItemHeight = 15;
            mealPlan_ListBox.Location = new Point(6, 22);
            mealPlan_ListBox.Name = "mealPlan_ListBox";
            mealPlan_ListBox.Size = new Size(239, 184);
            mealPlan_ListBox.TabIndex = 0;
            // 
            // display_Button
            // 
            display_Button.BackColor = Color.RoyalBlue;
            display_Button.ForeColor = SystemColors.Control;
            display_Button.Location = new Point(18, 235);
            display_Button.Name = "display_Button";
            display_Button.Size = new Size(509, 23);
            display_Button.TabIndex = 2;
            display_Button.Text = "Display Cost";
            display_Button.UseVisualStyleBackColor = false;
            display_Button.Click += displayInfo;
            // 
            // DormMealPlanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 272);
            Controls.Add(display_Button);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DormMealPlanForm";
            Text = "DormMealPlanForm";
            Load += onForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox dorm_ListBox;
        private GroupBox groupBox2;
        private ListBox mealPlan_ListBox;
        private Button display_Button;
    }
}