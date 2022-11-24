using Microsoft.TeamsFx;
using Sociolite.Models;

namespace Sociolite.Data
{
    public interface ISessionContext
    {
        public void AddMSTTeams(List<MSTTeam> teams);
        public List<MSTTeam> GetMSTTeams();
        public List<SocioliteTeam> GetTeams();
        public void AddTeam(SocioliteTeam team);

        public void ClearTeams();

        public string GetWindow();

        public void SetWindow(string name);

        public void SetOwnPhoto(string photoBase64);

        public Task<string> GetOwnPhoto(TeamsUserCredential teamsUserCredential);
    }
}
