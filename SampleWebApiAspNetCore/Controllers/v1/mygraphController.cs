using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.AspNet.Attributes;
using SampleWebApiAspNetCore.Entities;

namespace SampleWebApiAspNetCore.Controllers.v1
{
    public class mygraphController : Controller
    {
        [QueryRoot("person")]
        public Person RetrievePerson(int id)
        {
            // Normally you'd do a database lookup here
            return new Person()
            {
                Id = id,
                FirstName = "Luke",
                LastName = "Skywalker",
                ForceUser = true,
                FavoriteSong = "Papa was a Rollin' Stone",
            };
        }
    }
}
