using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Server.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<AccountDb> Accounts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // TODO : 뭐지? 인덱스, 유니크.. DB가 아니고 프로그래밍에서 거는건가..? EntityFramwork 공부
            builder.Entity<AccountDb>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PRIMARY");

                entity.ToTable("dat_account");

                entity.HasComment("계정 관련 테이블");

                entity.HasIndex(e => e.LoginId)
                    .HasName("uk_login_id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("uk_name")
                    .IsUnique();

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .HasColumnType("int(11)")
                    .HasComment("기본키");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("login_id")
                    .HasColumnType("varchar(45)")
                    .HasComment("로그인 아이디")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(10)")
                    .HasComment("닉네임")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(45)")
                    .HasComment("로그인 비밀번호")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegDt)
                    .HasColumnName("reg_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("계정 생성시간");
            });
        }
    }
}