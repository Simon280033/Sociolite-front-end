using Microsoft.Graph;
using Microsoft.TeamsFx;
using Sociolite.Models;

namespace Sociolite.Data
{
    public class SessionContext : ISessionContext
    {
        public List<MSTTeam> mstteams = new List<MSTTeam>();

        public List<SocioliteTeam> teams = new List<SocioliteTeam>();

        public string Window = "teams";

        public string OwnUserPhoto = "";

        public void AddMSTTeams(List<MSTTeam> teams)
        {
            mstteams = teams;
        }

        public List<MSTTeam> GetMSTTeams()
        {
            return mstteams;
        }

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

        public void SetOwnPhoto(string photoBase64)
        {
            OwnUserPhoto = photoBase64;
        }

        public async Task<string> GetOwnPhoto(TeamsUserCredential teamsUserCredential)
        {
            if (OwnUserPhoto.Length == 0)
            {
                OwnUserPhoto = await GetPhotoAsync(GetGraphServiceClient(teamsUserCredential));
            }

            return OwnUserPhoto;
        }

        private async Task<string> GetPhotoAsync(GraphServiceClient graph)
        {
            string userPhoto = "";
            try
            {
                var photoStream = await graph.Me.Photo.Content.Request().GetAsync();

                if (photoStream != null)
                {
                    // Copy the photo stream to a memory stream
                    // to get the bytes out of it
                    var memoryStream = new MemoryStream();
                    photoStream.CopyTo(memoryStream);
                    var photoBytes = memoryStream.ToArray();

                    // Generate a data URI for the photo
                    userPhoto = $"data:image/png;base64,{Convert.ToBase64String(photoBytes)}";
                }
            }
            catch (Exception) { /* Unable to get the users photo */ }

            return userPhoto;
        }

        private GraphServiceClient GetGraphServiceClient(TeamsUserCredential teamsUserCredential)
        {
            var msGraphAuthProvider = new MsGraphAuthProvider(teamsUserCredential, "User.Read");
            var client = new GraphServiceClient(msGraphAuthProvider);

            return client;
        }

        public string GetWindow()
        {
            return Window;
        }

        public void SetWindow(string name)
        {
            Window = name;
        }


    }
}
