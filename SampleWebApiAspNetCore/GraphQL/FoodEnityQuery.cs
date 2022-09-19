using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using SampleWebApiAspNetCore.Repositories;

namespace SampleWebApiAspNetCore.GraphQL
{
    public class FoodEnityQuery : ObjectGraphType<object>
    {
        public FoodEnityQuery(IFoodRepository repository)
        {
            Name = "TechEventQuery";

            Field<FoodEntityType>(
                "event",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "eventId" }),
                resolve: context => repository.GetSingle(context.GetArgument<int>("eventId"))
            );

            Field<ListGraphType<FoodEntityType>>(
                "events",
                resolve: context => repository.GetAll()
            );
        }
    }
}
