using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Ychy;

namespace Ychy.Tools
{
    public class MainVM : BaseVM
    {
        public Page currentPage { get; set; }
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                Signal();
            }

        }
         public CommandVM Team { get; set; }
         public CommandVM Update { get; set; }




        public MainVM() 
        {
            Team = new CommandVM(() =>
            {
                CurrentPage = new ListTeamPage();

            });
            Update = new CommandVM(() =>
            {
                CurrentPage = new ListTeamPage();

            });



        }

    }
}
