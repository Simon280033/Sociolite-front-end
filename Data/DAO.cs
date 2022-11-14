namespace Sociolite.Data
{
    public class DAO : IDAO
    {
        public List<string> GetJoinedTeams(string userName)
        {
            return new List<string>();
        }

        public string GetString(string userName)
        {
            return userName + userName;
        }
    }
}
