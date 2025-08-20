using Juga.Domain.Base;

namespace CleanArchitecture.Domain.Entities;

public class Car : Entity<Guid>
{
 	public Guid Id { get; set; }
    public int Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; }
    public short MinFindexScore { get; set; }

    public Car()
    {
    }

    public Car(
        Guid id,
        int kilometer,
        short modelYear,
        string plate,
        short minFindexScore
    )
        : this()
    {
        Id = id;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        MinFindexScore = minFindexScore;
    }
}