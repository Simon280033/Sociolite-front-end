using Sociolite.Models;

namespace Sociolite.Data
{
    public class SessionContext : ISessionContext
    {
        public List<SocioliteTeam> teams = new List<SocioliteTeam>();

        public bool InPopUpMode = false;

        public void AddTeam(SocioliteTeam team)
        {
            teams.Add(team);
        }

        public void ClearTeams()
        {
            teams = new List<SocioliteTeam>();
        }

        public List<SocioliteTeam> GetTeams()
        {
            return teams;
        }

        public void TogglePopUpMode()
        {
            InPopUpMode = !InPopUpMode;
        }
    }
}
