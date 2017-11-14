using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MissionAuth.Models;
using System.Data.Entity;

namespace MissionAuth.DAL
{
    public class MissionHqContext : DbContext
    {
        public MissionHqContext() : base("MissionHqContext")
        {

        }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }

        public System.Data.Entity.DbSet<MissionAuth.Models.User> Users { get; set; }
    }
}