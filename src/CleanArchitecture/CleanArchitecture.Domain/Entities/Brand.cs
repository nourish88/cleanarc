
using Juga.Abstractions.Data.AuditProperties;
using Juga.Domain.Base;

namespace CleanArchitecture.Domain.Entities;

public class Brand :Entity<long>
{
    public long Id { get; set; }
    public string Name { get; set; } 
 
}