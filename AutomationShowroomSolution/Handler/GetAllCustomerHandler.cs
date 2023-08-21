using CustomerService.Models.Dto;
using System.Collections.Generic;
using MediatR;
using CustomerService.Models;
using System.Threading.Tasks;
using System.Threading;
using CustomerService.Data;
using AutoMapper;
using System.Linq;
using CustomerService.Command;

namespace CustomerService.Handler
{
    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomerCommand, List<Customer>>
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public GetAllCustomerHandler(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<Customer>> Handle(GetAllCustomerCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_db.Customers.ToList());
        }
    }
}