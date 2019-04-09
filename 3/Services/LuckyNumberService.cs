using System;
using System.Collections.Generic;
using System.Linq;
using Services.NumberGenerators;

namespace Services
{
    public class LuckyNumberService
    {
        private readonly INumberGenerator _numberGenerator;

        public LuckyNumberService(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }

        public int GenerateFavoriteNumber(int min = 1, int max = 100)
        {
            if (min < 1)
                throw new ArgumentOutOfRangeException(nameof(min), "The minimum number cannot be less than 1.");
            if (max > 100)
                throw new ArgumentOutOfRangeException(nameof(max), "The maximum number cannot be greater than 100.");
            if (min > max)
                throw new ArgumentException("The minimum number must be less than the maximum.", nameof(min));

            return _numberGenerator.GetRandom(min, max);
        }

        public IEnumerable<int> GeneratePadlockCombination()
        {
            return Enumerable.Range(1, 3).Select(_ => _numberGenerator.GetRandom(0, 39));
        }

        public IEnumerable<int> GenerateLotteryNumber()
        {
            return Enumerable.Range(1, 5).Select(_ => _numberGenerator.GetRandom(0, 69));
        }
    }
}