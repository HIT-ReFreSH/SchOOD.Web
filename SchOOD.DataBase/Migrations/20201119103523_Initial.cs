/*
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
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchOOD.DataBase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Users",
                table => new
                {
                    Id = table.Column<long>("bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CalendarPath = table.Column<string>("longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Users", x => x.Id); });

            migrationBuilder.CreateTable(
                "Courses",
                table => new
                {
                    Id = table.Column<Guid>("char(36)", nullable: false),
                    Name = table.Column<string>("longtext CHARACTER SET utf8mb4", nullable: false),
                    DbUserId = table.Column<long>("bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        "FK_Courses_Users_DbUserId",
                        x => x.DbUserId,
                        "Users",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Rules",
                table => new
                {
                    Id = table.Column<Guid>("char(36)", nullable: false),
                    Effect = table.Column<short>("smallint", nullable: false),
                    Target = table.Column<Guid>("char(36)", nullable: false),
                    Argument = table.Column<string>("longtext CHARACTER SET utf8mb4", nullable: true),
                    DbUserId = table.Column<long>("bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        "FK_Rules_Users_DbUserId",
                        x => x.DbUserId,
                        "Users",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Events",
                table => new
                {
                    Id = table.Column<Guid>("char(36)", nullable: false),
                    StartTime = table.Column<DateTime>("datetime(6)", nullable: false),
                    Duration = table.Column<TimeSpan>("time(6)", nullable: false),
                    Location = table.Column<string>("longtext CHARACTER SET utf8mb4", nullable: true),
                    Teacher = table.Column<string>("longtext CHARACTER SET utf8mb4", nullable: true),
                    Type = table.Column<int>("int", nullable: false),
                    DbCourseId = table.Column<Guid>("char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        "FK_Events_Courses_DbCourseId",
                        x => x.DbCourseId,
                        "Courses",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Courses_DbUserId",
                "Courses",
                "DbUserId");

            migrationBuilder.CreateIndex(
                "IX_Events_DbCourseId",
                "Events",
                "DbCourseId");

            migrationBuilder.CreateIndex(
                "IX_Rules_DbUserId",
                "Rules",
                "DbUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Events");

            migrationBuilder.DropTable(
                "Rules");

            migrationBuilder.DropTable(
                "Courses");

            migrationBuilder.DropTable(
                "Users");
        }
    }
}