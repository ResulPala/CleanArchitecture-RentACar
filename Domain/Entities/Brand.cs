using Core.Persistance.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }
    public virtual ICollection<Model> Models { get; set; } // EFCore için virtual kullanmamıza gerek yok ama farklı ORMler için nhibernate gibi bu yapılar virtual ister

    public Brand()
    {
        Models = new HashSet<Model>();
    }

    public Brand(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}
