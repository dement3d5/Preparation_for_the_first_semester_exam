using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Ychy.DB;
using Ychy.Models;
using Ychy.Tools;

namespace Ychy.VM
{
    public class AddTeamVM
    {
        public List<Nteam> Nteam;
        public string Title { get; set; }
        public CommandVM AddTeam { get; set; }



        public AddTeamVM() 
        {
            Nteam = user2Context.GetInstance().Nteams.ToList();

            AddTeam = new CommandVM(() =>
            {
                var add = user2Context.GetInstance().Nteams.Add(new Nteam { Title = Title });
                user2Context.GetInstance().SaveChanges();
                Nteam = user2Context.GetInstance().Nteams.ToList();
                MessageBox.Show("Успешно!");
            });
        
        
        
        }


    }
}
