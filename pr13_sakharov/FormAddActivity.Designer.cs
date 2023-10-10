namespace pr13_sakharov
{
    partial class FormAddActivity
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
            this.components = new System.ComponentModel.Container();
            this.BackiBtn = new System.Windows.Forms.Button();
            this.addActivityBtn = new System.Windows.Forms.Button();
            this.addJuriBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.eventPlanIDCombBox = new System.Windows.Forms.ComboBox();
            this.dayTxtBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.juriCombBox = new System.Windows.Forms.ComboBox();
            this.moderatorCombBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // BackiBtn
            // 
            this.BackiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackiBtn.Location = new System.Drawing.Point(12, 12);
            this.BackiBtn.Name = "BackiBtn";
            this.BackiBtn.Size = new System.Drawing.Size(155, 47);
            this.BackiBtn.TabIndex = 3;
            this.BackiBtn.Text = "Назад";
            this.BackiBtn.UseVisualStyleBackColor = true;
            this.BackiBtn.Click += new System.EventHandler(this.BackiBtn_Click);
            // 
            // addActivityBtn
            // 
            this.addActivityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addActivityBtn.Location = new System.Drawing.Point(293, 337);
            this.addActivityBtn.Name = "addActivityBtn";
            this.addActivityBtn.Size = new System.Drawing.Size(313, 70);
            this.addActivityBtn.TabIndex = 3;
            this.addActivityBtn.Text = "Добавить новую активность";
            this.addActivityBtn.UseVisualStyleBackColor = true;
            this.addActivityBtn.Click += new System.EventHandler(this.addActivityBtn_Click);
            // 
            // addJuriBtn
            // 
            this.addJuriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addJuriBtn.Location = new System.Drawing.Point(625, 268);
            this.addJuriBtn.Name = "addJuriBtn";
            this.addJuriBtn.Size = new System.Drawing.Size(163, 24);
            this.addJuriBtn.TabIndex = 3;
            this.addJuriBtn.Text = "добавить";
            this.addJuriBtn.UseVisualStyleBackColor = true;
            this.addJuriBtn.Click += new System.EventHandler(this.addJuriBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "План события";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "День";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Начало мер.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(106, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Жюри";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(106, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Модератор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(289, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Добавление новой активности";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(106, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Название";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTxtBox.Location = new System.Drawing.Point(293, 118);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(313, 22);
            this.titleTxtBox.TabIndex = 5;
            // 
            // eventPlanIDCombBox
            // 
            this.eventPlanIDCombBox.DataSource = this.eventBindingSource;
            this.eventPlanIDCombBox.DisplayMember = "Title";
            this.eventPlanIDCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPlanIDCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventPlanIDCombBox.FormattingEnabled = true;
            this.eventPlanIDCombBox.Location = new System.Drawing.Point(293, 150);
            this.eventPlanIDCombBox.Name = "eventPlanIDCombBox";
            this.eventPlanIDCombBox.Size = new System.Drawing.Size(313, 24);
            this.eventPlanIDCombBox.TabIndex = 6;
            this.eventPlanIDCombBox.ValueMember = "ID";
            // 
            // dayTxtBox
            // 
            this.dayTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayTxtBox.Location = new System.Drawing.Point(293, 180);
            this.dayTxtBox.Name = "dayTxtBox";
            this.dayTxtBox.Size = new System.Drawing.Size(313, 22);
            this.dayTxtBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // juriCombBox
            // 
            this.juriCombBox.DataSource = this.usersBindingSource2;
            this.juriCombBox.DisplayMember = "Surname";
            this.juriCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.juriCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.juriCombBox.FormattingEnabled = true;
            this.juriCombBox.Location = new System.Drawing.Point(293, 268);
            this.juriCombBox.Name = "juriCombBox";
            this.juriCombBox.Size = new System.Drawing.Size(313, 24);
            this.juriCombBox.TabIndex = 6;
            this.juriCombBox.ValueMember = "ID";
            // 
            // moderatorCombBox
            // 
            this.moderatorCombBox.DataSource = this.usersBindingSource;
            this.moderatorCombBox.DisplayMember = "Surname";
            this.moderatorCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moderatorCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moderatorCombBox.FormattingEnabled = true;
            this.moderatorCombBox.Location = new System.Drawing.Point(293, 238);
            this.moderatorCombBox.Name = "moderatorCombBox";
            this.moderatorCombBox.Size = new System.Drawing.Size(313, 24);
            this.moderatorCombBox.TabIndex = 6;
            this.moderatorCombBox.ValueMember = "ID";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(pr13_sakharov.DBCon.Event);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(pr13_sakharov.DBCon.User);
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataSource = typeof(pr13_sakharov.DBCon.User);
            // 
            // FormAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 421);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.juriCombBox);
            this.Controls.Add(this.moderatorCombBox);
            this.Controls.Add(this.eventPlanIDCombBox);
            this.Controls.Add(this.dayTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addJuriBtn);
            this.Controls.Add(this.addActivityBtn);
            this.Controls.Add(this.BackiBtn);
            this.Name = "FormAddActivity";
            this.Text = "FormAddActivity";
            this.Load += new System.EventHandler(this.FormAddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackiBtn;
        private System.Windows.Forms.Button addActivityBtn;
        private System.Windows.Forms.Button addJuriBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.ComboBox eventPlanIDCombBox;
        private System.Windows.Forms.TextBox dayTxtBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox juriCombBox;
        private System.Windows.Forms.ComboBox moderatorCombBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource2;
    }
}