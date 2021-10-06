using System.Collections.ObjectModel;
using System.Data;
using FizzBuzz.interfaces;

namespace FizzBuzz
{
    public class NumberThree : Attributes, ObjectMethods
    {
        private Collection<string> threes;
        public NumberThree() => threes = new Collection<string>();
        
        public Collection<string> GetCollectionMultipleThree(int request)
        {
            if (request != THREE) throw new DataException("Me mandaste un numero incorrecto. No es Treeees");
            
            foreach (int number in GetListNumber())
            {
                threes.Add(IsMultipleThree(number) ? FIZZ : number.ToString());
            }

            return threes;
        }
        public Collection<int> GetListNumber()
        {
            numbers = new Collection<int>();
            for (int i = ONE; i <= NUMBER_FINAL; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }

        public bool IsMultipleThree(int number) => number % THREE == 0;

        public bool IsMultipleFive(int number) => throw new System.NotImplementedException();
    }
}