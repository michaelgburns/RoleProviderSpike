using System.Web.Security;

namespace Business
{
    public class MyRoleProvider 
    {
        public string[] GetRolesForUser()
        {
            var roles = Roles.GetRolesForUser();
            return roles;
        }
    }
}
