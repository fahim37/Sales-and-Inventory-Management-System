using Sales_and_Inventory_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }
        public bool LoginValidation(string username,string password)
        {
            return userDataAccess.LoginValidation(username,password);
        }
    }
}
