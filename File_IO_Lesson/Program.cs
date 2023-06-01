using File_IO_Lesson;
using Newtonsoft.Json;



string path = "./Assests/DataFiles/Comic.txt";
List<ComicBook> comics = new List<ComicBook>();
using (StreamReader reader = new StreamReader(path))
{
    string fileText = reader.ReadToEnd();
    comics = JsonConvert.DeserializeObject<List<ComicBook>>(fileText);
}

Console.WriteLine($"The total spend on comics: {comics.Sum(x => x.PurchasePrice)}");
Console.ReadKey();