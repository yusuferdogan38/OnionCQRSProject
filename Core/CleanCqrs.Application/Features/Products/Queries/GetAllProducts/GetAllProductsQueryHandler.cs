using CleanCqrs.Application.UnitOfWorks;
using CleanCqrs.Domain.Entityies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfwork unitOfWork;
        public GetAllProductsQueryHandler(IUnitOfwork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            
            var products= await unitOfWork.GetReadRepository<Product>().GetAllAsync();
            List<GetAllProductsQueryResponse> response = new();
            foreach (var product in products)
            {
                response.Add(new GetAllProductsQueryResponse
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price-(product.Price*product.Discount/100),
                    Discount = product.Discount
                });
            }


            return response;
        }
    }
}
