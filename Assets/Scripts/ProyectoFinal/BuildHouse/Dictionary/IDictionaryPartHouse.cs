using HouseFactory;

namespace CreateHouse.Dictionary
{
    public interface IDictionaryPartHouse
    {
        Creator GetPartHouse(string part);
    }
}