using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, decimal Price, string ImageFile, List<string> Category) : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // create product entity from command object
            // save product entity to database
            // return product id

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                ImageFile = request.ImageFile,
                Category = request.Category
            };

            // ToDo  
            // save product to database

            return Task.FromResult(new CreateProductResult(product.Id));


            throw new NotImplementedException();
        }
    }
}
