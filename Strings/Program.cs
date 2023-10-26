// See https://aka.ms/new-console-template for more information
//Intro();

string sentence = "My name is Burak Tan";

var result = sentence.Length;
var result2 = sentence.Clone;
sentence = "My name is Yunus Emre Tan";

bool result3 = sentence.EndsWith("n"); // Bu cümle "n" ile bitiyor mu sorusunu sorduk.
bool result4=sentence.StartsWith("M"); // Bu cümle "m" ile başlıyor mu sorusunu sorduk.

var result5=sentence.IndexOf("name"); // Metin de ki index numarasını öğrenmek istedik.
var result6=sentence.IndexOf(" "); // ....
var result7=sentence.LastIndexOf(" "); // Aratmak istediğin değeri sondan aramaya başlar.
var result8 = sentence.Insert(0, "Hello, "); // Metin içerisine değer eklememiz için kullanırız.
var result9 = sentence.Substring(3,4); // Metni parçalamak için kullanılır.
var result10=sentence.ToLower();// Bütün karakterleri küçük harfe dönüştürür.
var result11=sentence.ToUpper();// Bütün karakterleri büyük harfe dönüştürür.
var result12 = sentence.Replace(" ","-");//Metin içerisinde belirli karakterleri değiştirmek için kullanırız.
var result13=sentence.Remove(2,10);//Metin içerisinde belirli bir indexten sonrasını atmak için kullanılır.


Console.WriteLine(result3);
Console.WriteLine(result4);
Console.WriteLine(result5);
Console.WriteLine(result6);
Console.WriteLine(result7);
Console.WriteLine(result8);
Console.WriteLine(result9);
Console.WriteLine(result10);
Console.WriteLine(result11);
Console.WriteLine(result12);
Console.WriteLine(result13);


static void Intro()
{
    string city = "Ankara";
    //Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";

    Console.WriteLine(String.Format("{0} {1}", city, city2));

}
Console.ReadLine();
