using GraphQlHandsOn.Query;

namespace GraphQlHandsOn.Schema;

public class ProductSchema : GraphQL.Types.Schema
{
    public ProductSchema(ProductQuery productQuery)
    {
        Query = productQuery;
    }
}