namespace TextMVCCheckBox3.Models
{
    public class Role
    {
        public Role(int roleID, string name)
        {
            RoleID = roleID;
            Name = name;

        }

        public int RoleID { get; set; }
        public string Name { get; set; }


    }
}