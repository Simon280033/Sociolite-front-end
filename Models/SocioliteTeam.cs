﻿using Quartz.Impl.Triggers;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sociolite.Models
{
    public class SocioliteTeam
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<TeamsUser> Members { get; set; }

        public string RecurranceString { get; set; }
        public List<SocioliteDiscussion> Discussions { get; set; }
        public List<SociolitePoll> Polls { get; set; }

        public List<string> SchedulerIds { get; set; }

        public string GetReadableRecurranceString()
        {
            /*
            CronExpression t = new CronExpression(RecurranceString);
            return t.GetExpressionSummary();
            */
            return "Every weekday at 12:30";
        }

    }
}
