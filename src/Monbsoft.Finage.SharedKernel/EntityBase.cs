namespace Monbsoft.Finage.SharedKernel;

public abstract class EntityBase
{
    public Guid Id { get; protected set; }
    
    public static bool operator ==(EntityBase a, EntityBase b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.Equals(b);
    }
    public static bool operator !=(EntityBase a, EntityBase b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        var other = obj as EntityBase;

        if(ReferenceEquals(other, null)) 
            return false;

        if (ReferenceEquals(other, this))
            return true;

        return other.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
