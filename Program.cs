using System;

namespace Conversioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = { true, false, false, false, true };
            int[] dp = { 1, 2, 3, 4 };

            Console.WriteLine("num binario convertito: " + Convert_Binario_To_Decimale(b));

            Console.WriteLine("num decimale puntato convertito: " + Convert_Decimale_Puntato_To_Decimale(dp));

            int[] nums = Convert_num_Decimale_To_Decimale_Puntato(4294967295);
            foreach (int n in nums)
            {
                Console.Write(n + ".");
            }
            Console.ReadLine();
        }
        static bool[] Convert_Decimale_Puntato_To_Binario(int[] decimalePuntato)
        {
            bool[] bools = new bool[decimalePuntato.Length * 8];
            int num;
            for (int i = 0; i < decimalePuntato.Length; i++)
            {
                num = decimalePuntato[i];
                for (int j = 7; j >= 0; j--) 
                {
                    if (num % 2 == 1)
                    {
                        bools[j + i * 8] = true;
                    }
                    num /= 2;
                    if (num < 0) 
                    {
                        break;
                    }
                }
            }
            return bools;
        }
        static int Convert_Binario_To_Decimale(bool[] b)
        {
            int binDec = 0;
            int esponente = 0;

            for (int i = b.Length - 1; i >= 0; i--)
            {
                if (b[i])
                {
                    binDec += (int)Math.Pow(2, esponente);
                }
                esponente++;
            }

            return binDec;
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int dpDec = 0;
            int potenza = 0;

            for (int i = dp.Length - 1; i >= 0; i--)
            {
                dpDec += dp[i] * (int)Math.Pow(256, potenza);
                potenza++;
            }

            return dpDec;
        }
        static int[] Convert_num_Decimale_To_Decimale_Puntato(uint num)
        {
            int[] DecPunt = new int[4];
            for (int i = DecPunt.Length - 1; i >= 0; i--)
            {
                DecPunt[i] = (int)(num % 256);
                num /= 256;
                if (num < 0)
                {
                    break;
                }
            }
            return DecPunt;
        }
        static bool[] Convert_num_Decimale_To_Binario(uint num)
        {
            bool[] bollArr = new bool[32];
            for (int i = bollArr.Length - 1; i >= 0; i--)
            {
                if (num % 2 == 1)
                {
                    bollArr[i] = true;
                }
                num /= 2;
                if (num < 0)
                {
                    break;
                }
            }
            return bollArr;
        }

        
    }
}