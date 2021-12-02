using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Teamplate.Domain.Entities;

namespace Teamplate.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("c7dce21b-d207-4869-bf5f-85cb138bb919"), Nome = "User Default", Email = "teste@teste.com.br"
                });

            return builder;
        }
    }
}
