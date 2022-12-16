namespace Obesenec
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Hra oběšenec");
                Console.WriteLine("------------");
                Console.WriteLine("Zadej hádané slovo:");
                string vstup;
                int zivoty = 10;


                while (string.IsNullOrWhiteSpace(vstup = Console.ReadLine().ToLower()))
                {
                    Console.WriteLine("Zadej znovu");
                }

                string kopieVstup = vstup;

                Console.Clear();


                do
                {
                    Console.WriteLine($"Zbývá Vám {zivoty} životů");

                    for (int i = 0; i < vstup.Length; i++)
                    {
                        if (kopieVstup.Contains(vstup[i]))
                        {
                            Console.Write("_ ");
                        }
                        else
                        {
                            Console.Write(vstup[i] + "");
                        }
                    }

                    Console.WriteLine();

                    Console.WriteLine("Hádejte písmeno");

                    ConsoleKeyInfo klavesa = Console.ReadKey();
                    Console.WriteLine();
                    if (vstup.Contains(char.ToLower(klavesa.KeyChar)))
                    {
                        kopieVstup = kopieVstup.Replace(char.ToLower(klavesa.KeyChar).ToString(), "");
                        
                        


                    }
                    else
                    {
                        Console.WriteLine("Neuhádl jsi. Přicházíš o život.");
                        zivoty--;
                    }

                } while (zivoty > 0 && kopieVstup != "");

                if (zivoty != 0 )
                {
                    Console.WriteLine(vstup);
                    Console.WriteLine("Vyhrál jsi. Správná odpověď byla " + vstup);
                }
                else
                {
                    Console.WriteLine("Prohrál jsi.Správná odpověď byla " + vstup);
                }

                Console.WriteLine();
                

            } while (true);











        }
    }
}