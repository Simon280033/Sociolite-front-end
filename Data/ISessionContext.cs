﻿using Sociolite.Models;

namespace Sociolite.Data
{
    public interface ISessionContext
    {
        public List<SocioliteTeam> GetTeams();
        public void AddTeam(SocioliteTeam team);

        public void ClearTeams();

        public bool ToggleWindow();

        public string GetWindow();

        public void SetWindow(string name);
    }
}
