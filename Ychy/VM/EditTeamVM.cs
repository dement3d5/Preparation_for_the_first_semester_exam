using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Ychy.DB;
using Ychy.Models;
using Ychy.Tools;

namespace Ychy.VM
{
    public class EditTeamVM : BaseVM
    {

        public Nteam nteam;
        public string Title
        {
            get => nteam?.Title;
            set
            {
                if(nteam != null)
                {
                    nteam.Title = value;
                    Signal();
                }

            }


        }
        public ICommand EditTeam { get; set; }


        public EditTeamVM(Nteam selectedTeam) 
        {
            nteam = selectedTeam;
            EditTeam = new CommandVM(() =>
            {
                user2Context.GetInstance().Nteams.Update(nteam);
                user2Context.GetInstance().SaveChanges();
                MessageBox.Show($"Успешно сохранилось! Новое название команды: {Title}");


            });
        
        
        }
    }
}
