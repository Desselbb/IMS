using IMSClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace IMSClassLibrary.Context
{
    public class SystemDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options): base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = default!;
        public virtual DbSet<Project> Projects { get; set; } = default!;    
        public virtual DbSet<Department> Departments { get; set; } = default!;
        public virtual DbSet<Comment> Comments { get; set; } = default!;
        public virtual DbSet<InternProject> InternProjects { get; set; } = default!;
        public virtual DbSet<Module> Modules{ get; set; } = default!;
        public virtual DbSet<Profile> Profiles  { get; set; } = default!;
        public virtual DbSet<UserProfile> UserProfiles { get; set; } = default!;
        public virtual DbSet<ProfileModule> ProfileModules { get; set; }

    }
}
