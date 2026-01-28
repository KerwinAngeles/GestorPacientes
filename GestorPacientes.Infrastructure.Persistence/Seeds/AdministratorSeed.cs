using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GestorPacientes.Core.Domain.Entities;
using GestorPacientes.Infrastructure.Persistence.Context;

namespace GestorPacientes.Infrastructure.Persistence.Seeds
{
    public static class AdministratorSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            context.Database.EnsureCreated(); // crea DB si no existe


            var defaultUser = new User
            {
                UserName = "admin12",
                Email = "admin@gmail.com",
                Name = "Kerwin",
                LastName = "Angeles",
                IdRol = 1,
                Password = ComputeSha256("Admin@123")
            };

            if (context.Users.All(u => u.Id != defaultUser.Id))
            {
                context.Users.Add(defaultUser);
                context.SaveChanges();
            }

        }

        private static string ComputeSha256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
