using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Model : Entity<Guid>
{
    public Guid BrandId { get; set; } //Guid yeni Guid özelliği 
    public Guid FuelId { get; set; }//Guid yeni Guid özelliği 
    public Guid TransmissionId { get; set; }//Guid yeni Guid özelliği 
    public string Name { get; set; }
    public short Year { get; set; }
    public decimal DailyPrice { get; set; }
    public Model() { }


    public Model(
        Guid brandId,//Guid olarakd değişti
        Guid fuelId,//Guid olarakd değişti
        Guid transmissionId,//Guid olarakd değişti
        string name,
        short year,
        decimal dailyPrice
    )
    {
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
    }

    // lazy loading
    public Brand? Brand { get; set; } = null; // one-to-one ilişki var.
    public Fuel? Fuel { get; set; } = null; // one-to-one ilişki var.
    public Transmission? Transmission { get; set; } = null; // one-to-one ilişki var.

    public ICollection<Car>? Cars { get; set; } = null; // model ile car arasında one-to-many ilişki var.


}