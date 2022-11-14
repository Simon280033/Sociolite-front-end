using Microsoft.Graph;
using Sociolite.Models;

namespace Sociolite.Data
{
    public interface IDAO
    {
        string GetString(string userName);

        List<SocioliteTeam> GetJoinedTeams(string userId);
    }
}
