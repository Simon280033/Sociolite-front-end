using Sociolite.Models;

namespace Sociolite.Data
{
    public class DAO : IDAO
    {

        public string GetString(string userName)
        {
            return userName + userName;
        }

        List<SocioliteTeam> IDAO.GetJoinedTeams(string userId)
        {
            return new List<SocioliteTeam>();
        }
    }
}
