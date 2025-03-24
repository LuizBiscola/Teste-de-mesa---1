class Program
{
    static void Main()
    {
        Console.WriteLine("|Exercicio 1|");
        Console.WriteLine("|Exercicio 2|");
        Console.WriteLine("|Exercicio 3|");
        Console.Write("Escolha o exercicio a ser visto: ");
        int busca = int.Parse(Console.ReadLine());

        switch (busca)
        {
            case 1:
                ex01();
                break;

            case 2:
                ex02();
                break;

            case 3:
                ex03();
                break;

            default:
                break;
        }
    }

    static void ex01()
    {
        int []v = new int[4];
        int a,b,c;

        a = 10;
        b = 20;
        c = (a+b) / 2;
        c = c-40;
        
        for (int i = 0; i < v.Length; i++)
        {
            if(i == 3)
            {
                v[i]=a+b+c;
                Console.WriteLine($"V[{i}] = 5: Verdadeiro [{v[i]}]");
            }
            else 
            {
                Console.WriteLine($"V[{i}] = 5: Falso [{v[i]}]");
            }
        }
    }

    static void ex02()
    {
        int a = 2;
        int []v = new int[7];

        while (a<6)
        {
            v[a] = 10 *a;
            Console.WriteLine($"Vetor: {v[a]}");
            a += 1;
        }
    }

    static void ex03()
    {
        int a,b;
        int []vetor = new int[10];

        a =7;
        b = a - 6;

        while (b<a) {
            vetor[b]=b+a;
            Console.WriteLine(vetor[b]);
            b = b+2;
        }
        
    }

}