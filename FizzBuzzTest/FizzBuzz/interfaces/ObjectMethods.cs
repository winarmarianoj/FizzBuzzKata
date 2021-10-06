using System.Collections.ObjectModel;

namespace FizzBuzz.interfaces
{
    public interface ObjectMethods
    {
        Collection<int> GetListNumber();
        bool IsMultipleThree(int number);
        bool IsMultipleFive(int number);
    }
}