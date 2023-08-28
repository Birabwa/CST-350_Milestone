using CST_350_Milestone.Models;

namespace CST_350_Milestone.Services
{
    public class SecurityService
    {

        SecurityDAO securityDAO = new SecurityDAO();

        public bool IsValid(RegisterModel user)
        {
            return securityDAO.FindUserByNameAndPassword(user);
        }
    }
}
