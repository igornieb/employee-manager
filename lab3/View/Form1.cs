using lab3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hide_btns();
        }

/*        
        public event Action<decimal> SetSalary;
        public event Action<string> SetFirstname;
        public event Action<string> SetLastname;
        public event Action<string> SetContract;
        public event Action<DateTime> SetDate;
*/
        public event Action<string, string, DateTime, string, decimal, string> SetAll;
        public event Action<int> LoadInstance;
        public event Action<int, string, string, DateTime, string, decimal, string> OverrideInstance;
        public event Action<int> DeleteInstance;
        public event Action<string> ExportData;
        public event Action<string> ImportData;


        private void hide_btns()
        {
            ovr_btn.Hide();
            del_btn.Hide();
        }

        private void show_btns()
        {
            ovr_btn.Show();
            del_btn.Show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (add_btn_Validating())
            {
                //collect all data
                string firstname = firstname_field.Text;
                string lastname = lastname_field.Text;
                decimal salary = salary_field.Value;
                string contract_choice = "";
                string position = position_field.Text;
                DateTime birth_date = datetime_field.Value.Date;
                if (radioButton1.Checked)
                {
                    contract_choice = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    contract_choice = radioButton2.Text;

                }
                if (radioButton3.Checked)
                {
                    contract_choice = radioButton3.Text;
                }
                //send signal
                SetAll?.Invoke(firstname, lastname, birth_date, position, salary, contract_choice);
                //clear form
                clear_form();
                hide_btns();
            }
        }

        public void create_MessageBox(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        public void update_list(string value)
        {
            workers_list.Items.Add(value);
        }

        public void update_list_index(int index, string value)
        {
            workers_list.Items.RemoveAt(index);
            workers_list.Items.Insert(index, value);
        }

        public void delete_list(int index)
        {
            workers_list.Items.RemoveAt(index);
        }

        private void clear_form()
        {
            firstname_field.Clear();
            lastname_field.Clear();
            datetime_field.Value = DateTime.Now;
            radioButton2.Select();
            salary_field.Value = salary_field.Minimum;
        }

        public void update_form(string firstname, string lastname, DateTime birth_date, string position, decimal salary, string contract_choice)
        {
            firstname_field.Text = firstname;
            lastname_field.Text = lastname;
            datetime_field.Value = birth_date;
            position_field.Text = position;
            salary_field.Value = salary;
            if (contract_choice == radioButton1.Text)
            {
                radioButton1.Select();
            }
            if (contract_choice == radioButton2.Text)
            {
                radioButton2.Select();
            }
            if (contract_choice == radioButton3.Text)
            {
                radioButton3.Select();
            }
        }
        private void workers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = workers_list.SelectedIndex;
            if(position != -1)
            {
                LoadInstance?.Invoke(position);
                show_btns();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "export";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportData?.Invoke(Path.GetFullPath(saveFileDialog1.FileName));
            }
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                ImportData?.Invoke(Path.GetFullPath(filePath));
            }
        }
        private bool add_btn_Validating()
        {
            if (firstname_field.Text.Length == 0)
            {
                error_name.SetError(firstname_field, "Pole nie może byc puste");
                return false;
            }
            else
            {
                error_name.Clear();
            }
            if (lastname_field.Text.Length == 0)
            {
                error_name.SetError(firstname_field, "Pole nie może byćpus");
                return false;
            }
            else
            {
                error_name.Clear();
            }
            if (datetime_field.Value > DateTime.Now)
            {
                error_date.SetError(datetime_field, "Wartość pola nie może być wieksza od obejcnej daty");
                return false;
            }
            else
            {
                error_date.Clear();
            }
            if (position_field.Items.Contains(position_field.Text)==false)
            {
                error_position.SetError(position_field, "Wybierz jedną z dozwolonych wartości");
                return false;
            }
            else
            {
                error_position.Clear();
            }
            return true;
        }

        private void ovr_btn_Click(object sender, EventArgs e)
        {
            if (add_btn_Validating())
            {
                int i = workers_list.SelectedIndex;
                string firstname = firstname_field.Text;
                string lastname = lastname_field.Text;
                decimal salary = salary_field.Value;
                string contract_choice = "";
                string position = position_field.Text;
                DateTime birth_date = datetime_field.Value.Date;
                if (radioButton1.Checked)
                {
                    contract_choice = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    contract_choice = radioButton2.Text;

                }
                if (radioButton3.Checked)
                {
                    contract_choice = radioButton3.Text;
                }
                //send signal
                OverrideInstance?.Invoke(i, firstname, lastname, birth_date, position, salary, contract_choice);
                //clear form
                clear_form();
                //hide btns
                hide_btns();
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            int i = workers_list.SelectedIndex;
            DeleteInstance?.Invoke(i);
            clear_form();
            hide_btns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            position_field.Items.Clear();
            foreach (string position in Pracownik.get_positions())
            {
                position_field.Items.Add(position);
            }
        }
    }
}