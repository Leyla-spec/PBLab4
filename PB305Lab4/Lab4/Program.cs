// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

// 2.Bir tam ədədlər massivi verilib. Həmin massivi tək və
// cut ədədlərə ayıran bir alqoritm yazın. Məsələn:
// [1,2,3,4,5,6,7,8]⇒ output: Tək ədədlər:1,3,5,7 ; Cüt ədədlər: 2,4,6,82.




int[] tam_Ededler = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

int countEven = 0;
int countOdd = 0;

for (int i = 0; i < tam_Ededler.Length; i++)
{
    if (tam_Ededler[i] % 2 == 0)
    {
        countEven++;
    }
    else
    {
        countOdd++;
    }
};

int[] massivEven = new int { countEven };
int[] massivOdd = new int { countOdd };
Console.WriteLine(massivEven.Length);
Console.WriteLIne(massivOdd.Length);
int indexEven = 0;
int indexOdd = 0;

for (int i = 0; i < tam_Ededler.Length; i++)
{
    if ( tam_Ededler% 2 == 0)
    {
        massivEven[indexEven] = tam_Ededler[i];
        indexEven++;
    }
    else
    {
        massivOdd[indexOdd] = tam_Ededler[i];
        indexOdd++;
    }
}

foreach ( int i in massivEven)
{
    Console.WriteLine(i);
}
foreach (int i in massivOdd)
{
    Console.WriteLine(i);
}



//3.Bir tam ədədlər massivi verilib. Həmin massivdəki tək
//indexdə dayanan elementlərin cəmi ilə cüt indexdə dayanan
//elementlərin cəminin fərqini tapan alqoritm yazın.



int[] tam_Ededler2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

int cutIndexSum = 0;

int tekIndexSum = 0;

for (int i = 0; i < tam_Ededler2.Length; i++)
{
    if (i % 2 == 0)
    {
        cutIndexSum += tam_Ededler2[i];
    }
    else
    {
        tekIndexSum += tam_Ededler2[i];
    }
}


if (cutIndexSum > tekIndexSum)
{
    Console.WriteLine("Cut ededlerin cemi: " + cutIndexSum);
    Console.WriteLine("Tek ededlerin cemi: " + tekIndexSum);
    Console.WriteLine("Fərq: " + (cutIndexSum - tekIndexSum));
}
else
{
    Console.WriteLine("Cut ededlerin cemi: " + cutIndexSum);
    Console.WriteLine("Tek ededlerin cemi: " + tekIndexSum);
    Console.WriteLine("Fərq: " + (tekIndexSum - cutIndexSum));



//4.Bir tam ədədlər massivi verilib. Bu massivdə yalnız bir
//dəfə təkrarlanan elementləri çap edən funksiya yazın.

int[] tam_Ededler3 = new int[] { 1, 2, 3, 4, 4, 5, 6, 7, 8};

for (int i = 0; i < tam_Ededler3.Length; i++)
{
    int count = 0;
    for (int j = 0; j < tam_Ededler3.Length; j++)
    {
        if (tam_Ededler3[i] == tam_Ededler3[j])
        {
            count++;
        }
    }
    if (count == 1)
    {
        Console.WriteLine(tam_Ededler3[i]);
    }
}






