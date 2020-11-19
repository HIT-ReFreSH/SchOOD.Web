﻿/*
Copyright 2020 ReFreSH

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchOOD.Models;

namespace SchOOD
{
    public class SchOODContext:DbContext
    {
        private static IConfigurationRoot? Config { get; } = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("dbsettings.json", true, reloadOnChange: true)
                .Build();

        public SchOODContext()
        {
        }

        public DbSet<DbCourse> Courses { get; set; }
        public DbSet<DbEvent> Events { get; set; }
        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbUserRule> Rules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config?["ConnectionString"], ServerVersion.AutoDetect(Config?["ConnectionString"]));
        }
    }
}