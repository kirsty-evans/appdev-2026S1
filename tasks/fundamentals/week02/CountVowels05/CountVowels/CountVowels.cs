namespace CountVowels;

public class CountVowels
{

    public static int[] Count(string line) {

        int [] VowelArray = new int[5];

        if (line == null) {
            return VowelArray;
        }

        if (line.Length == 0) {
            return VowelArray;
        }

        if (line.Length > 0) {
            foreach (char c in line) {
                switch (char.ToLower(c)) {
                    case 'a':
                        VowelArray[0]++;
                        break;
                    case 'e':
                        VowelArray[1]++;
                        break;
                    case 'i':
                        VowelArray[2]++;
                        break;
                    case 'o':
                        VowelArray[3]++;
                        break;
                    case 'u':
                        VowelArray[4]++;
                        break;
                }
            }
        }

        return VowelArray;
    }

}
