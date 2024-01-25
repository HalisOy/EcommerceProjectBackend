namespace ECommerceAPI.Core;
public abstract class Entity
{
}

public abstract class Entity<TKey> : Entity
    where TKey : struct
{
    public TKey Id { get; set; }
}