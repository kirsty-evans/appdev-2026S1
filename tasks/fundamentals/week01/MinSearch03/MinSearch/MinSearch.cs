namespace MinSearch;

    public class MinSearch
    {

        public static int? Find(int[] numbers) {

            // handle empty array
            if (numbers.Length == 0)
                return null;

            // start with first number as min
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

    }
