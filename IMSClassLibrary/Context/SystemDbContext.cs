using IMSClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace IMSClassLibrary.Context
{
    public class SystemDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options): base(options)
        {
        }

        public virtual DbSet<User> User { get; set; } = default!;
        public virtual DbSet<Project> Projects { get; set; } = default!;
        public virtual DbSet<Department> Departments { get; set; } = default!;
        public virtual DbSet<ProjectComments> ProjectComments { get; set; } = default!;
        public virtual DbSet<InternProject> InternProjects { get; set; } = default!;
        public virtual DbSet<Module> Modules{ get; set; } = default!;
        public virtual DbSet<Profile> Profiles  { get; set; } = default!;
        public virtual DbSet<Menu> Menu { get; set; } = default!;
        public virtual DbSet<UserProfile> UserProfiles { get; set; } = default!;

    }
}
