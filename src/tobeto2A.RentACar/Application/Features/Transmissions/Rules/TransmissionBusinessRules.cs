using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Transmissions.Rules;
public class TransmissionBusinessRules : BaseBusinessRules
{
    private readonly ITransmissionRepository _transmissionRepository;

    public TransmissionBusinessRules(ITransmissionRepository transmissionRepository)
    {
        _transmissionRepository = transmissionRepository;
    }


    public async Task CarShouldNotExistsWithSameName(string name)
    {
        Transmission? transmissionWithSameName = await _transmissionRepository.GetAsync(b => b.Name == name);

        if (transmissionWithSameName is not null)
            throw new BusinessException("Aynı isme sahip bir vites zaten mevcut.");
    }
}