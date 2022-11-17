using Sociolite.Models;

namespace Sociolite.Data
{
    public class SessionContext : ISessionContext
    {
        public List<SocioliteTeam> teams = new List<SocioliteTeam>();

        public bool ShowTeams = true;

        public string Window = "teams";

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

        public string GetWindow()
        {
            return Window;
        }

        public void SetWindow(string name)
        {
            Window = name;
        }

        public bool ToggleWindow()
        {
            ShowTeams = !ShowTeams;
            return ShowTeams;
        }
    }
}
