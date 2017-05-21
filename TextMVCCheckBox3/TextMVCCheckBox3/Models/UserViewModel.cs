using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextMVCCheckBox3.Models
{
    //Step 3.
    public class UserViewModel
    {


        public UserViewModel()
        {
            AvailableRoles = new List<Role>();
            SelectedRoles = new List<Role>();
        }

        public int? UserID { get; set; }
        public string Account { get; set; }
        public IEnumerable<Role> AvailableRoles { get; set; }
        public IEnumerable<Role> SelectedRoles { get; set; }
        public PostedRoles PostedRoles { get; set; }


    }


    //Step 2.
    public class PostedRoles 
    {
        public int[] RoleIDs { get; set; }

    }

    //1.
    public static class RolesRepository
    {
        private static List<Role> _roles;

        public static void Initializer()
        {
            _roles = new List<Role>();
            _roles.Add(new Role(1, "Admin"));
            _roles.Add(new Role(2, "Guest"));
        }

        public static Role Get(int id)
        {
            return _roles.FirstOrDefault(X => X.RoleID == id);
        }

        public static IEnumerable<Role> GetAll()
        {
            if (_roles == null)
            {
                Initializer();
            }

            return _roles;
        }
    }

    public class UserRoleService
    {
        public Role GetRole(int id)
        {
            return RolesRepository.Get(id);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return RolesRepository.GetAll();
        }

        public void CreateNewUser(UserViewModel model)
        {
            User user = new User()
            {
                UserID = model.UserID,
                Account = model.Account

            };
            foreach (var roleId in model.PostedRoles.RoleIDs)
            {
                Role role = RolesRepository.Get(roleId);
                user.Roles.Add(role);
            }

            //Do something ...
        }

    }
}