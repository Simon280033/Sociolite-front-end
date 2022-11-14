using Microsoft.Graph;

namespace Sociolite.Data
{
    public interface IDAO
    {
        string GetString(string userName);

        List<string> GetJoinedTeams(string userName);
    }
}
