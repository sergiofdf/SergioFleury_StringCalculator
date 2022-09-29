namespace StringCalculator.Domain
{
    public class StringCalculator
    {

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var parts = numbers.Split(',');

            var exccedsCount = parts.Length > 2;
            var consecutiveCommas = parts.Any(x => string.IsNullOrWhiteSpace(x));
            var nonNumber = parts.Any(x => !int.TryParse(x, out _));


            if (exccedsCount || consecutiveCommas || nonNumber)
                throw new ArgumentException(nameof(numbers));

            var sum = parts.Sum(Convert.ToInt32);

            return sum;
        }

    }
}