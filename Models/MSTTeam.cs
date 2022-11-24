namespace Sociolite.Models
{
    public class MSTTeam
    {
        public string Id { get; set; }

        public List<string> ChannelIds { get; set; }

        public List<string> MemberIds { get; set; }
    }
}
