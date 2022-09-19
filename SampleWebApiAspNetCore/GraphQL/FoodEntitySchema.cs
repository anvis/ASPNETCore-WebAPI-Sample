using System;
using GraphQL.Types;

namespace SampleWebApiAspNetCore.GraphQL
{
    public class FoodEntitySchema : Schema
    {
        public FoodEntitySchema(IServiceProvider resolver)
        {
            Query = (FoodEnityQuery) resolver.GetService(typeof( FoodEnityQuery));
            //DependencyResolver = resolver;
        }
    }
}
