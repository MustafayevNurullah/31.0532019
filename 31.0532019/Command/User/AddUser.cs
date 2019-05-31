using _31._0532019.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _31._0532019.Command.User
{
    public class AddUser : ICommand
    {
        public event EventHandler CanExecuteChanged;
        UserViewModel UserViewModel;
        public AddUser(UserViewModel userViewModel)
        {
            UserViewModel = userViewModel;
        }



        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            using (NewsEntities Dbcontex = new NewsEntities())
            {

              
                    Dbcontex.Users.Add(UserViewModel.CurrentUser);
                    UserViewModel.Users.Add(UserViewModel.CurrentUser);
                    Dbcontex.SaveChanges();
             


                  
                



            }
        }
    }
}
