namespace ExerciciosLeetCode.Exercicios;

public class PlusOne
{
    public void Executar()
    {
        int[] digits = [1, 2, 3];

        int[] resultado = PlusOneMetodo(digits);

        Console.WriteLine($"[{string.Join(", ", resultado)}]");
    }

    public int[] PlusOneMetodo(int[] digits)
    {
        // Percorre o array de trás para frente
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            // Se o número for menor que 9,
            // apenas soma 1 e retorna
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            // Se for 9, vira 0 e continua o loop
            digits[i] = 0;
        }

        // Se chegou aqui, significa que todos eram 9
        // Ex: [9] -> [1,0]
        // Ex: [9,9,9] -> [1,0,0,0]
        int[] novoArray = new int[digits.Length + 1];
        novoArray[0] = 1;

        return novoArray;
    }
}

/*
 You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].
Example 3:

Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
 

Constraints:

1 <= digits.length <= 100
0 <= digits[i] <= 9
digits does not contain any leading 0's.
 */