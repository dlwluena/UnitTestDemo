using System;

namespace CalculatorApp
{
    public class Calculator
    {
        private readonly ILogService _logService;

        public Calculator(ILogService logService)
        {
            _logService = logService;
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            _logService.Log($"Add: {a} + {b} = {result}");
            return result;
        }

        public int Subtract(int a, int b)
        {
            int result = a - b;
            _logService.Log($"Subtract: {a} - {b} = {result}");
            return result;
        }
    }
}
