using Application.Features.Customers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;


namespace Application.Features.Customers.Commands.Create;
public class CreateCustomerCommand : IRequest<CreatedCustomerResponse>
{
    public Guid UserId { get; set; }
  

    // Inner class
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreatedCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly CustomerBusinessRules _customerBusinessRules;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public async Task<CreatedCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            // CreateCustomerCommand nesnesini Customer türüne dönüştürür.
            Customer customer = _mapper.Map<Customer>(request);
            // Veritabanına yeni müşteriyi ekler. (Asenkron olarak)
            Customer addedCustomer = await _customerRepository.AddAsync(customer);
            // Eklenen müşteriyi CreatedCustomerResponse türüne dönüştürür.
            CreatedCustomerResponse createdCustomerResponse = _mapper.Map<CreatedCustomerResponse>(addedCustomer);

            return createdCustomerResponse;
        }
    }
}