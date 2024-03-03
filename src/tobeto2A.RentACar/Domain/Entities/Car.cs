using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Car : Entity<Guid>
{
    //Id, ColorId, ModelId, CarState, Kilometer, ModelYear, Plate
    public int ColorId { get; set; }//duruma göre guid dönebilirsin 
    public Guid ModelId { get; set; }//yeni eklenen Guid değer
    public string CarState { get; set; }
    public int Kilometer { get; set; }
    public int ModelYear { get; set; }
    public string Plate { get; set; }
    public Car()
    {

    }

    public Car(int colorId, Guid modelId, string carState, int kilometer, int modelYear, string plate)//modelId guid döndü
    {
        ColorId = colorId;
        ModelId = modelId;
        CarState = carState;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
    }


}