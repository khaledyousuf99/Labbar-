


Console.Write("Skriv in en text: ");
string text = Console.ReadLine();
Console.WriteLine();

long summa = 0;


for (int i = 0; i < text.Length; i++)


{
    if (char.IsDigit(text[i]) == false)
        continue;





    for (int j = i + 1; j < text.Length; j++)
    {
        if (!char.IsDigit(text[j]))
            break;



        if (text[i] == text[j])

        {


            bool ärGiltig = true;


            for (int k = i + 1; k < j; k++)


            {

                if (text[k] == text[i] || !char.IsDigit(text[k]))



                {
                    ärGiltig = false;
                    break;
                }
            }

            if (ärGiltig)
            {
                for (int m = 0; m < text.Length; m++)


                {
                    Console.ForegroundColor = (m >= i && m <= j) ? ConsoleColor.Green : ConsoleColor.Gray;
                    Console.Write(text[m]);
                }


                Console.ResetColor();

                Console.WriteLine();

                string sifferserie = text.Substring(i, j - i + 1);


                summa += long.Parse(sifferserie);
            }
        }
    }
}

Console.WriteLine();



Console.WriteLine("Summan är: " + summa);








