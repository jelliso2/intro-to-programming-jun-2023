
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == null || numbers.Length == 0)
        {
            return 0;
;        }
        else
        {
            int sum = 0;

            char[] seperators = { ',', '\n' };

            string[] splitString = numbers.Split(seperators);

            foreach(string number in splitString)
            {
                sum += int.Parse(number);
            }

            return sum;
        }

        
    }
}
