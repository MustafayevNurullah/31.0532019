using _31._0532019.Command.User;
using _31._0532019.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._0532019.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        public AddUser addUser { get; set; }
        public UserViewModel()
        {
            addUser = new AddUser(this);
            CurrentUser = new Users(); 
            using (NewsEntities Dbcontex = new NewsEntities())
            {
                Users =new ObservableCollection<Users> (Dbcontex.Users.ToList());

            }

        }

        Users currentuser;
        public Users CurrentUser
        {

            get
            {
                return currentuser;
            }
            set
            {
                currentuser = value;
                OnpropertyChange(new PropertyChangedEventArgs(nameof(CurrentUser)));
            }
        }



        ObservableCollection<Users> users;
        public ObservableCollection<Users> Users
         {
            get
            {
                return users;
            }
            set
            {
                users = value;
                OnpropertyChange(new PropertyChangedEventArgs(("Users")));
            }

         }
     




    }
}
