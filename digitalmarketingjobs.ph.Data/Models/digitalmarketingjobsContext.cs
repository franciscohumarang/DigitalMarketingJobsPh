using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class digitalmarketingjobsContext : DbContext
    {
        public digitalmarketingjobsContext()
        {
        }

        public digitalmarketingjobsContext(DbContextOptions<digitalmarketingjobsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobAlert> JobAlerts { get; set; }
        public virtual DbSet<JobLevel> JobLevels { get; set; }
        public virtual DbSet<JobRole> JobRoles { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<SpotlightJob> SpotlightJobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=digitalmarketingjobs;Username=postgres;Password=P@ssw0rd@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("application");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CoverLetter).HasColumnName("cover_letter");

                entity.Property(e => e.DateApplied)
                    .HasColumnName("date_applied")
                    .HasColumnType("date");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("date");

                entity.Property(e => e.IsRecommended)
                    .HasColumnName("is_recommended")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.ResumeId).HasColumnName("resume_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("blog");

                entity.Property(e => e.BlogId).HasColumnName("blog_id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.ImageMain).HasColumnName("image_main");

                entity.Property(e => e.ImageThumb).HasColumnName("image_thumb");

                entity.Property(e => e.IsFeatured)
                    .HasColumnName("is_featured")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PublishedDate)
                    .HasColumnName("published_date")
                    .HasColumnType("date");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.ViewsCount).HasColumnName("views_count");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("candidate");

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

                entity.Property(e => e.DateRegistered)
                    .HasColumnName("date_registered")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasColumnName("client_name");

                entity.Property(e => e.CompanyLogo).HasColumnName("company_logo");

                entity.Property(e => e.CompanyName).HasColumnName("company_name");

                entity.Property(e => e.ContactNumber).HasColumnName("contact_number");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Website).HasColumnName("website");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("job");

                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasDefaultValueSql("nextval('job_job__id_seq'::regclass)");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DateExpires)
                    .HasColumnName("date_expires")
                    .HasColumnType("date");

                entity.Property(e => e.DatePosted)
                    .HasColumnName("date_posted")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.FilterCandidate)
                    .HasColumnName("filter_candidate")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IsFilled).HasColumnName("is_filled");

                entity.Property(e => e.IsSpotlight)
                    .HasColumnName("is_spotlight")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.JobRoleId).HasColumnName("job_role_id");

                entity.Property(e => e.JobTypeId).HasColumnName("job_type_id");

                entity.Property(e => e.SalaryFrom).HasColumnName("salary_from");

                entity.Property(e => e.SalaryTo).HasColumnName("salary_to");

                entity.Property(e => e.Tags).HasColumnName("tags");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<JobAlert>(entity =>
            {
                entity.ToTable("job_alert");

                entity.Property(e => e.JobAlertId).HasColumnName("job_alert_id");

                entity.Property(e => e.AlertName).HasColumnName("alert_name");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("date");

                entity.Property(e => e.FrequencyId).HasColumnName("frequency_id");

                entity.Property(e => e.Keywords).HasColumnName("keywords");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<JobLevel>(entity =>
            {
                entity.ToTable("job_level");

                entity.Property(e => e.JobLevelId).HasColumnName("job_level_id");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<JobRole>(entity =>
            {
                entity.ToTable("job_role");

                entity.Property(e => e.JobRoleId).HasColumnName("job_role_id");

                entity.Property(e => e.Role).HasColumnName("role");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.ToTable("job_type");

                entity.Property(e => e.JobTypeId).HasColumnName("job_type_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Resume>(entity =>
            {
                entity.ToTable("resume");

                entity.Property(e => e.ResumeId).HasColumnName("resume_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("date");

                entity.Property(e => e.ResumeUpload).HasColumnName("resume_upload");

                entity.Property(e => e.SkillsSummary).HasColumnName("skills_summary");

                entity.Property(e => e.SkillsTags).HasColumnName("skills_tags");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<SpotlightJob>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spotlight_job");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
