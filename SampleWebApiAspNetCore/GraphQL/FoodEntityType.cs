using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;

namespace SampleWebApiAspNetCore.GraphQL
{
    public class FoodEntityType : ObjectGraphType<FoodEntity>
    {
        public FoodEntityType(IFoodRepository repository)
        {
            Field(x => x.Id).Description("Event id.");
            Field(x => x.Name).Description("Event name.");
            //Field(x => x.Speaker).Description("Speaker name.");
            //Field(x => x.EventDate).Description("Event date.");

            //Field<ListGraphType<ParticipantType>>(
            //    "participants",
            //    arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "eventId" }),
            //    resolve: context => repository.GetParticipantInfoByEventId(context.Source.EventId)
            //);
        }
    }
}
