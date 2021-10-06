using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace FizzBuzz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(("Holaaaa"));
        }
    }

    public class FizzBuzzFunction : Attributes
    {
        private NumberThree _numberThree;
        private NumberFive _numberFive;
        private Collection<string> fizzBuzzList;

        public FizzBuzzFunction()
        {
            _numberThree = new NumberThree();
            _numberFive = new NumberFive();
            fizzBuzzList = new Collection<string>();
        }

        public void Print_Number_from_1_to_100(int ONE, int NUMBER_FINAL)
        {
            for(int i = base.ONE; i <= base.NUMBER_FINAL; i++)
            {
                Console.WriteLine(i); 
            }
        }

        public Collection<string> Print_Fizz_Multiple_3(int request)
        {
            if(_numberThree.GetListNumber() == null || request != THREE) throw new NotImplementedException();
            
            foreach (int number in _numberThree.GetListNumber())
            {
                fizzBuzzList.Add(_numberThree.IsMultipleThree(number) ? FIZZ : number.ToString());
            }

            return fizzBuzzList;
        }


        public Collection<string> Print_Buzz_Multiple_5(int request)
        {
            if(_numberFive.GetListNumber() == null || request != FIVE) throw new NotImplementedException();
            
            foreach (int number in _numberFive.GetListNumber())
            {
                fizzBuzzList.Add(_numberFive.IsMultipleFive(number) ? BUZZ : number.ToString());
            }

            return fizzBuzzList;
        }
        
        public Collection<string> Print_FizzBuzz()
        {
            if(_numberThree.GetListNumber() == null || _numberFive.GetListNumber() == null)
                throw new NotImplementedException();

            foreach (int number in _numberThree.GetListNumber())
            {
                if (_numberThree.IsMultipleThree(number) && _numberFive.IsMultipleFive(number))
                {fizzBuzzList.Add(FIZZBUZZ);}else{fizzBuzzList.Add(number.ToString());}
            }

            return fizzBuzzList;
        }
        public Collection<string> Print_Everything(int requestOne, int requestTwo, string[] expected)
        {
            if (_numberThree.GetListNumber() == null || _numberFive.GetListNumber() == null 
                || requestOne != THREE || requestTwo != FIVE)
                throw new NotImplementedException();

            for(int number = 1; number <= NUMBER_FINAL; number++)
            {
                if (_numberThree.IsMultipleThree(number) && _numberFive.IsMultipleFive(number))
                {
                    fizzBuzzList.Add(FIZZBUZZ);
                }else if (_numberThree.IsMultipleThree(number))
                {
                    fizzBuzzList.Add(FIZZ);
                }else if (_numberFive.IsMultipleFive(number))
                {
                    fizzBuzzList.Add(BUZZ);
                }
                else
                {
                    fizzBuzzList.Add(number.ToString());
                }
            }

            return fizzBuzzList;
        }

        public bool VerifyNumberFrom1To100(int request)
        {
            return request >= ONE && request <= NUMBER_FINAL;
        }

        public string GetResultNumbersCriterial(int request)
        {
            if(request <= 0 || request > NUMBER_FINAL) throw new NotImplementedException();

            string response = request.ToString();
            
            response = _numberThree.IsMultipleThree(request) ? response = FIZZ : response;
            response = _numberFive.IsMultipleFive(request) ? response = BUZZ : response;
            response = _numberThree.IsMultipleThree(request) && _numberFive.IsMultipleFive(request)
                ? response = FIZZBUZZ
                : response;
            return response;
        }
    }

}

