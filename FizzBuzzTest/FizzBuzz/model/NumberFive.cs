using System.Collections.ObjectModel;
using System.Data;
using FizzBuzz.interfaces;

namespace FizzBuzz
{
    public class NumberFive : Attributes, ObjectMethods
    {
        private Collection<string> fives;
        
        public NumberFive() => fives = new Collection<string>();
        public Collection<string> GetCollectionMultipleFive(int request)
        {
            if (request != FIVE) throw new DataException("Me mandaste un numero incorrecto. No es Cincoooooo");
            
            foreach (int number in GetListNumber())
            {
                fives.Add(IsMultipleFive(number) ? BUZZ : number.ToString());
            }

            return fives;
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

        public bool IsMultipleThree(int number) => throw new System.NotImplementedException();
        public bool IsMultipleFive(int number) => number % FIVE == 0;
    }
}