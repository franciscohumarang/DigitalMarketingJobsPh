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
        public virtual DbSet<CandidateJobs> CandidateJobs { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobAlert> JobAlerts { get; set; }
        public virtual DbSet<JobLevel> JobLevels { get; set; }
        public virtual DbSet<JobRole> JobRoles { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=digitalmarketingjobs;Username=postgres;Password=P@55w0rd!");
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

                entity.Property(e => e.IsRecommended).HasColumnName("is_recommended");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.ResumeId).HasColumnName("resume_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("application_candidate_fk");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("application_client_fk");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("application_job_fk");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("application_resume_fk");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("blog");

                entity.Property(e => e.BlogId).HasColumnName("blog_id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("date");

                entity.Property(e => e.ImageMain).HasColumnName("image_main");

                entity.Property(e => e.ImageThumb).HasColumnName("image_thumb");

                entity.Property(e => e.IsFeatured).HasColumnName("is_featured");

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

                entity.Property(e => e.Educations)
                    .HasColumnName("educations")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Experiences)
                    .HasColumnName("experiences")
                    .HasColumnType("jsonb");

                entity.Property(e => e.GcashNo).HasColumnName("gcash_no");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.ProfessionalTitle)
                    .HasColumnName("professional_title")
                    .HasMaxLength(500);

                entity.Property(e => e.ResumeContent).HasColumnName("resume_content");

                entity.Property(e => e.VideoUrl).HasColumnName("video_url");
            });

            modelBuilder.Entity<CandidateJobs>(entity =>
            {
                entity.ToTable("candidate_jobs");

                entity.Property(e => e.CandidateJobsId).HasColumnName("candidate_jobs_id");

                entity.Property(e => e.CandidateId).HasColumnName("candidate_id");

                entity.Property(e => e.DateEnded)
                    .HasColumnName("date_ended")
                    .HasColumnType("date");

                entity.Property(e => e.DateStarted)
                    .HasColumnName("date_started")
                    .HasColumnType("date");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateJobs)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("candidate_jobs_fk");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.CandidateJobs)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("candidate_jobs_fk_1");
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

                entity.Property(e => e.FilterCandidate).HasColumnName("filter_candidate");

                entity.Property(e => e.IsFilled).HasColumnName("is_filled");

                entity.Property(e => e.IsSpotlight).HasColumnName("is_spotlight");

                entity.Property(e => e.JobRoleId).HasColumnName("job_role_id");

                entity.Property(e => e.JobTypeId).HasColumnName("job_type_id");

                entity.Property(e => e.SalaryFrom).HasColumnName("salary_from");

                entity.Property(e => e.SalaryTo).HasColumnName("salary_to");

                entity.Property(e => e.Tags).HasColumnName("tags");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("job_client_fk");

                entity.HasOne(d => d.JobRole)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.JobRoleId)
                    .HasConstraintName("job_jobrole_fk");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("job_jobtype_fk");
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
