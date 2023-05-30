using lab3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace lab3.Presenter
{
    internal class Presenter
    {
        private Form1 _view;
        private Pracownik _model;
        private Storage _storage;
        public Presenter(Form1 view, Pracownik model, Storage storage) 
        {
            _view = view;
            _model = model;
            _storage = storage;
            view.SetAll += view_SetAll;
            view.ExportData += view_ExportData;
            view.LoadInstance += view_LoadInstance;
            view.ImportData += view_ImportData;
            view.OverrideInstance += view_OverrideInstance;
            view.DeleteInstance += view_DeleteInstance;
        }

        private void UpdateListView(string model)
        {
            _view.update_list(model);
        }

        private void DeleteFromListView(int i)
        {
            _view.delete_list(i);

        }

        private void UpdateListIndexView(int i)
        {
            _view.update_list_index(i, _model.ToString());
        }

        private void SetoffMessageBox(string exception, string caption)
        {
            _view.create_MessageBox(exception, caption);
        }

        private void UpdateFormView(Model.Pracownik p)
        {
            _view.update_form(p.Firstname, p.Lastname, p.Birth_date, p.Position, p.Salary, p.Contract);
        }

        private void view_SetAll(string firstname, string lastname, DateTime birth_date, string position, decimal salary, string contract)
        {
            //set values in model
            try
            {
                _model.Contract = contract;
                _model.Firstname = firstname;
                _model.Lastname = lastname;
                _model.Birth_date = birth_date;
                _model.Salary = salary;
                _model.Position = position;
                //add model to storage
                _storage.Add(_model.Copy());
                UpdateListView(_model.ToString());
            }
            catch (Exception e )
            {
                SetoffMessageBox(e.Message, "Error Detected in Input");
            }
          
        }

        private void view_LoadInstance(int position)
        {
            UpdateFormView(_storage.Get(position));
        }

        private void view_ExportData(string filePath)
        {
            _storage.Serialize(filePath);
        }
        private void view_ImportData(string filePath)
        {
            try
            {
                _storage.Deserialize(filePath);
                List<Pracownik> ds = _storage.Deserialize(filePath);
                foreach (Pracownik s in ds)
                {
                    _model = s;
                    _storage.Add(_model.Copy());
                    UpdateListView(s.ToString());
                }

            }
            catch(Exception e)
            {
                SetoffMessageBox(e.Message, "Error Detected in XML file");
            }

        }

        private void view_OverrideInstance(int i, string firstname, string lastname, DateTime birth_date, string position, decimal salary, string contract)
        {
            _model = _storage.Get(i);
            try
            {
                _model.Contract = contract;
                _model.Firstname = firstname;
                _model.Lastname = lastname;
                _model.Birth_date = birth_date;
                _model.Salary = salary;
                _model.Position = position;
                _storage.Set(i,_model);
                //add model to storage
                UpdateListIndexView(i);
            }
            catch (ArgumentException e)
            {
                SetoffMessageBox(e.Message, "Error Detected in Input");
            }
        }
        private void view_DeleteInstance(int i)
        {
            _storage.RemoveAt(i);
            DeleteFromListView(i);
        }
    }
}
