using lab3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //setting mpv
            var view = new Form1();
            var model = new Model.Pracownik();
            var storage = new Model.Storage();
            var presenter = new Presenter.Presenter(view, model, storage);
            Application.Run(view);  //dont forget to change to view!
        }
    }
}
