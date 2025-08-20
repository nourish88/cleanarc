using Juga.Domain.Base;

namespace CleanArchitecture.Domain.Entities;

public class Transmission : Entity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}