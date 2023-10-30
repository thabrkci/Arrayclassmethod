namespace arrayclassmethod;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("SortArray(unordered array)");
        int[] arrayclassexample = {23,13,52,9,8,3,78};
        foreach (int array in arrayclassexample)
        {
        Console.WriteLine(array);    
        }

        Console.WriteLine("sequential array");
        Array.Sort(arrayclassexample);

        foreach (int array in arrayclassexample)
        {
            Console.WriteLine(array);
        }

        //Clear Array(Başladığı indexten sonraki indexleri sıfırlar örneğin 2,2 ikinci indexten sonraki )
        //2 indexi sıfırla olarak uygulanır.

        Console.WriteLine("----____ClearArray____----");
        Array.Clear(arrayclassexample,3,3);//3.indexten başlayıp diğer 3 elemanı sıfırladı

        foreach (int array in arrayclassexample)
        {
                    Console.WriteLine(array);
        }

        /*ReverseArray(Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. 
        Yani dizinin ilk elemanı ile son elemanını yer değiştirir,yada 2.eleman ile sondan 2.eleman
        yer değiştirir.)*/
        Console.WriteLine("=====ArrayReverse=====");
        Array.Reverse(arrayclassexample);

        foreach (int array in arrayclassexample)
        {
            Console.WriteLine(array);
        }

        /*ArrayİndexOf(Verilen dizinin verilen elemanının indexini getirir. 
        Eğer dizi içerisinde elemanı bulamazsa -1 döner.) Bu kısımda foreach kullanılmaz çünkü
        index kendi kendine dönecektir örneğin 0 dan başlayarak yazılan elamanı bulup kaçıncı sırada
        olduğunu yazdırır*/
        Console.WriteLine("=====Arrayİndex=====");
        Console.WriteLine(Array.IndexOf(arrayclassexample,9));//örneğinde 0 dan başlayıp 9 u bulana kadar döndü ve sonuç 4

        //Array Resize Dizileri yeniden boyutlandırmak için kullanılır.
        Console.WriteLine("-_-_-_Array Resize_-_-_");
        Array.Resize<int>(ref arrayclassexample,8);
        //ref: referans <int>:Tipi

        arrayclassexample[7] = 99; //7 elemanlı olan indexe 8'nci elemanı tanımlıyoruz [eleman] = değeri;
        
        foreach (int array in arrayclassexample)
        {
            Console.WriteLine(array);
        }


    }
}
