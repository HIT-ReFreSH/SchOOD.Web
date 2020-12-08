using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using SchOOD.Models;

namespace SchOOD.Web
{
    public static class ExtensionMethods
    {
        public static string? GetId(this ClaimsPrincipal user)
        {
            return user.Claims.Where(t => t.Type == "id").Select(t => t.Value).FirstOrDefault();
        }
        public static string? GetName(this ClaimsPrincipal user)
        {
            return user.Claims.Where(t => t.Type == "id").Select(t => t.Value).FirstOrDefault();
        }

        public static Task<DbUser?> FetchUser(this SchOODContext database, ClaimsPrincipal user)
        {

            return Task.Run(() =>
            {
                var rawId = user.GetId();
                if (rawId == null) return null;
                var id = rawId.ToLongId();
                return database.Users.FirstOrDefault(u => u.Id == id);
            });
        }

        public static Task<DbCourse?> FetchCourse(this SchOODContext database, Guid id)
        {

            return Task.Run(() =>
            {
                return database.Courses.FirstOrDefault(c=>c.Id==id);
            });
        }
        public static Task<DbEvent?> FetchEvent(this SchOODContext database, Guid id)
        {

            return Task.Run(() =>
            {
                return database.Events.FirstOrDefault(e => e.Id == id);
            });
        }
        public static JsonResult AsJsonResult(this object obj) => new(obj);
    }
}
