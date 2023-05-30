using lab3.Model;

namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstname_field = new System.Windows.Forms.TextBox();
            this.lastname_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime_field = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_field = new System.Windows.Forms.NumericUpDown();
            this.position_field = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.workers_list = new System.Windows.Forms.ListBox();
            this.error_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_salary = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_position = new System.Windows.Forms.ErrorProvider(this.components);
            this.ovr_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salary_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_position)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname_field
            // 
            this.firstname_field.Location = new System.Drawing.Point(116, 63);
            this.firstname_field.Margin = new System.Windows.Forms.Padding(2);
            this.firstname_field.Name = "firstname_field";
            this.firstname_field.Size = new System.Drawing.Size(157, 20);
            this.firstname_field.TabIndex = 0;
            // 
            // lastname_field
            // 
            this.lastname_field.Location = new System.Drawing.Point(116, 99);
            this.lastname_field.Margin = new System.Windows.Forms.Padding(2);
            this.lastname_field.Name = "lastname_field";
            this.lastname_field.Size = new System.Drawing.Size(157, 20);
            this.lastname_field.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // datetime_field
            // 
            this.datetime_field.CustomFormat = "";
            this.datetime_field.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_field.Location = new System.Drawing.Point(116, 139);
            this.datetime_field.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_field.MaxDate = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.datetime_field.Name = "datetime_field";
            this.datetime_field.Size = new System.Drawing.Size(157, 20);
            this.datetime_field.TabIndex = 5;
            this.datetime_field.Value = new System.DateTime(2023, 3, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // salary_field
            // 
            this.salary_field.DecimalPlaces = 2;
            this.salary_field.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.salary_field.Location = new System.Drawing.Point(117, 174);
            this.salary_field.Margin = new System.Windows.Forms.Padding(2);
            this.salary_field.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.salary_field.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.salary_field.Name = "salary_field";
            this.salary_field.Size = new System.Drawing.Size(155, 20);
            this.salary_field.TabIndex = 7;
            this.salary_field.ThousandsSeparator = true;
            this.salary_field.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // position_field
            // 
            this.position_field.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.position_field.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.position_field.FormattingEnabled = true;
            this.position_field.Location = new System.Drawing.Point(117, 207);
            this.position_field.Margin = new System.Windows.Forms.Padding(2);
            this.position_field.Name = "position_field";
            this.position_field.Size = new System.Drawing.Size(156, 21);
            this.position_field.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 246);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(161, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "umowa na czas nieokreślony";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 268);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "umowa na czas określony";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(116, 289);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(101, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "umowa zlecenie";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pensja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(7, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stanowisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rodzaj umowy";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(23, 339);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(248, 34);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "Dodaj";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(24, 377);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(119, 27);
            this.save_btn.TabIndex = 16;
            this.save_btn.Text = "Eksport";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(153, 377);
            this.export_btn.Margin = new System.Windows.Forms.Padding(2);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(119, 27);
            this.export_btn.TabIndex = 17;
            this.export_btn.Text = "Import";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // workers_list
            // 
            this.workers_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workers_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workers_list.FormattingEnabled = true;
            this.workers_list.HorizontalScrollbar = true;
            this.workers_list.ItemHeight = 31;
            this.workers_list.Location = new System.Drawing.Point(306, 28);
            this.workers_list.Margin = new System.Windows.Forms.Padding(2);
            this.workers_list.Name = "workers_list";
            this.workers_list.ScrollAlwaysVisible = true;
            this.workers_list.Size = new System.Drawing.Size(544, 376);
            this.workers_list.TabIndex = 20;
            this.workers_list.SelectedIndexChanged += new System.EventHandler(this.workers_list_SelectedIndexChanged);
            // 
            // error_name
            // 
            this.error_name.ContainerControl = this;
            // 
            // error_date
            // 
            this.error_date.ContainerControl = this;
            // 
            // error_salary
            // 
            this.error_salary.ContainerControl = this;
            // 
            // error_position
            // 
            this.error_position.ContainerControl = this;
            // 
            // ovr_btn
            // 
            this.ovr_btn.Location = new System.Drawing.Point(24, 311);
            this.ovr_btn.Name = "ovr_btn";
            this.ovr_btn.Size = new System.Drawing.Size(118, 23);
            this.ovr_btn.TabIndex = 21;
            this.ovr_btn.Text = "Zapisz";
            this.ovr_btn.UseVisualStyleBackColor = true;
            this.ovr_btn.Click += new System.EventHandler(this.ovr_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(153, 311);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(118, 23);
            this.del_btn.TabIndex = 22;
            this.del_btn.Text = "Usuń";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Zarządzanie pracownikami";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.ovr_btn);
            this.Controls.Add(this.workers_list);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.position_field);
            this.Controls.Add(this.salary_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetime_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastname_field);
            this.Controls.Add(this.firstname_field);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "employee-manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salary_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_position)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname_field;
        private System.Windows.Forms.TextBox lastname_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetime_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown salary_field;
        private System.Windows.Forms.ComboBox position_field;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.ListBox workers_list;
        private System.Windows.Forms.ErrorProvider error_name;
        private System.Windows.Forms.ErrorProvider error_date;
        private System.Windows.Forms.ErrorProvider error_salary;
        private System.Windows.Forms.ErrorProvider error_position;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button ovr_btn;
        private System.Windows.Forms.Label label3;
    }
}

