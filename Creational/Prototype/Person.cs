namespace DesignPatterns.Creational.Prototype;

public class Person : IShallowCopy<Person>, IDeepCopy<Person>
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;


    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var person = (Person)this.MemberwiseClone();
        person.IdInfo = new IdInfo(IdInfo.IdNumber);
        person.Name = new string(Name.ToArray());
        
        return person;
    }
}