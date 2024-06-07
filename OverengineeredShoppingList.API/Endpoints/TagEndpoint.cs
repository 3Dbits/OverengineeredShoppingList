using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using OverengineeredShoppingList.Domain.Entities;
using OverengineeredShoppingList.Persistance.Contexts;

namespace OverengineeredShoppingList.API.Endpoints
{
    public static class TagEndpoint
    {
        public static void MapTagEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/Tag").WithTags(nameof(TagEndpoint));

            group.MapGet("/", async (AppDbContext db) =>
            {
                return await db.Tags.ToListAsync();
            })
            .WithName("GetTags")
            .WithOpenApi();

            group.MapGet("/{id}", async Task<Results<Ok<Tag>, NotFound>> (int id, AppDbContext db) =>
            {
                return await db.Tags.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                    is Tag model
                        ? TypedResults.Ok(model)
                        : TypedResults.NotFound();
            })
            .WithName("GetTagById")
            .WithOpenApi();

            group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Tag tag, AppDbContext db) =>
            {
                var affected = await db.Tags
                    .Where(model => model.Id == id)
                    .ExecuteUpdateAsync(setters => setters.SetProperty(model => model.Name, tag.Name)
                        );
                return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
            })
            .WithName("UpdateTag")
            .WithOpenApi();

            group.MapPost("/", async (Tag tag, AppDbContext db) =>
            {
                db.Tags.Add(tag);
                await db.SaveChangesAsync();
                return TypedResults.Created($"/api/Tag/{tag.Id}", tag);
            })
            .WithName("CreateTag")
            .WithOpenApi();

            group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, AppDbContext db) =>
            {
                var affected = await db.Tags
                    .Where(model => model.Id == id)
                    .ExecuteDeleteAsync();
                return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
            })
            .WithName("DeleteTag")
            .WithOpenApi();
        }
    }
}
