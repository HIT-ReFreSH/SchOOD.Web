using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using SchOOD.Models;

namespace SchOOD.Web
{
    public class StaticResource
    {
        public static void AddCourse()
        {
            var c = GenerateCourse();
            Courses.Add(c);
            foreach (var @event in c.Events)
            {
                Events.Add(@event);
            }
        }
        public static T RandomItemOf<T>(params T[] args)
        {
            Random r = new();
            return args[r.Next(args.Length)];
        }
        public static int RandomItemOfRange(int min, int max)
        {
            Random r = new();
            return r.Next(min, max);
        }

        public static string?[] Locations =
        {
            "正心34", "致知13", "格物201","铁华团",null
        };
        public static string[] Names =
        {
            "数学", "语文","英语","物理","化学","生物"
        };
        public static string?[] Teachers =
        {
            "🐉🔒", "奥尔加", "RideOn","巴耶力",null
        };
        public static EventType[] EventTypes =
        {
            EventType.Default,
            EventType.Examination,
            EventType.Experiment
        };

        public static CourseSource[] CourseSources =
        {
            CourseSource.Local,
            CourseSource.Shared
        };

        public static bool[] Booleans =
        {
            true,
            false
        };

        public static List<Course> Courses { get; } = new();
        public static List<Event> Events { get; } = new();
        public static User User { get; set; } = GetUser();

        public static void Initilize()
        {
            for (int i = 0; i < 20; i++)
            {
                AddCourse();
            }
        }

        public static User GetUser()
        {
            return new(RandomItemOf(Teachers) ?? "DEFAULT", "11112313", "https://cms.hit.edu.cn")
            {
                EnableNotification = RandomItemOf(Booleans)

            };
        }
        public static CourseSummary? GetSummary(Course? course)
        {

            return course == null ? null : new CourseSummary(course.CourseName, course.Id)
            {
                EnableNotification = course.EnableNotification,
                Source = course.Source,
                Hidden = course.Hidden,
                Location = course.Events.First().Location,
                Teacher = course.Events.First().Teacher,
                StartTime = course.Events.First().StartTime.ToString(CultureInfo.InvariantCulture),

            };
        }
        public static Course GenerateCourse()
        {
            return new(RandomItemOf(Names),
                Guid.NewGuid(),
                new[]{
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent(),
                    GenerateEvent()
                })
            {
                EnableNotification = RandomItemOf(Booleans),
                Hidden = RandomItemOf(Booleans),
                Source = RandomItemOf(CourseSources)
            };
        }

        public static Event GenerateEvent()
        {
            return new()
            {
                Duration = 120,
                Location = RandomItemOf(Locations),
                Teacher = RandomItemOf(Teachers),
                StartTime = new DateTime(2020,
                    RandomItemOfRange(1, 12),
                    RandomItemOfRange(1, 28),
                    RandomItemOfRange(0, 23),
                    RandomItemOfRange(0, 59),
                    RandomItemOfRange(0, 59)).AsJavaScriptTimeStamp(),
                Hidden = RandomItemOf(Booleans),
                Id = Guid.NewGuid(),
                Type = RandomItemOf(EventTypes)

            };
        }
    }
}
