﻿namespace News
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogDatabase : DbContext
    {
        public BlogDatabase()
            : base("name=BlogDatabase")
        {
        }


        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogArticle> BlogArticles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var blogTable = modelBuilder.Entity<Blog>();
            var blogArtticleTable = modelBuilder.Entity<BlogArticle>();

            //blogTable.Property(o => o.Id).IsRequired();
            blogTable.HasKey(o => o.Id);

            //blogArtticleTable.Property(o => o.Id).IsRequired();
            blogArtticleTable.HasKey(o => o.Id);


            base.OnModelCreating(modelBuilder);
        }
    }


    /// <summary>
    /// 博客
    /// </summary>

    public class Blog
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 博客
        /// </summary>
        public string Title { get; set; }

    }

    /// <summary>
    /// 博客文章
    /// </summary>
    public class BlogArticle
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>

        public string Body { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>

        public DateTime DateCreated { get; set; }
    }


}