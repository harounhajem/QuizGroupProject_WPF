﻿using Quiz_WPFVersion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_WPFVersion.Data
{
    public class QuizContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<QuizPayload> QuizPayloads { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Alternative> Alternatives { get; set; }

    }
}