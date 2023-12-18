using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using Ychy.DB;
using Ychy.Models;
using Ychy.Tools;
using Ychy.Windows;

namespace Ychy.VM
{
    public class ListTeamVM : BaseVM
    {
        public List<Nteam> nteams { get ; set; }
        private Nteam listnteam;
        public Nteam ListNteam
        {
            get => listnteam;
            set
            {
                listnteam = value;
                Signal();

            }
        }


        public Nteam Title { get; set; }

        public CommandVM EditTeam { get; set; }

        public CommandVM DeleteTeam { get; set; }
        public Nteam SelectedTeam { get; set; }

        public ListTeamVM()
        {
            using( var db = new user2Context())
            {
                nteams = db.Nteams.ToList();

            }


            EditTeam = new CommandVM(() =>
            {
                if(listnteam != null) 
                {
                    EditTeamWindow etw = new EditTeamWindow(listnteam);
                    etw.DataContext = new EditTeamVM(listnteam);
                    etw.ShowDialog();
          
                
                }
                else
                {
                    MessageBox.Show("Выбери название команды для редактирования!");
                }

            });


            DeleteTeam = new CommandVM(() =>
            {
                if(listnteam is Nteam selectedTeam)
                {
                    try
                    {
                       var db = new user2Context();
                       db.Nteams.Remove(selectedTeam);
                       db.SaveChanges();
                        MessageBox.Show("Удалилось!");
                    }
                 
                    catch
                    {
                        MessageBox.Show("errror!");

                    }

                }


            });


        }



    }
}
