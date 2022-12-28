using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldTransactionSum = 50;
            var newTransactionSum = 10;
            var resultTransactionSum = 0;
            var deltaSum = newTransactionSum - oldTransactionSum;
           Console.WriteLine(deltaSum);
            switch (deltaSum)
            {
                case > 0:
                    resultTransactionSum = oldTransactionSum + deltaSum;
                    //accountDto.CurrentSum += deltaSum;
                    //_accountServices.Update(accountDto);
                    break;
                case < 0:
                    var absSumDto = Math.Abs(oldTransactionSum);
                    var absDeltaSum = Math.Abs(deltaSum);
                    resultTransactionSum = oldTransactionSum - (absSumDto > absDeltaSum ? (absSumDto - absDeltaSum): (absDeltaSum - absSumDto));
                    break;
            }
            Console.WriteLine(resultTransactionSum);
        }
    }
}