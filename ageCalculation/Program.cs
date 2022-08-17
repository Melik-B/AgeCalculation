//age calculation

//ALGORITHM

//1.1 Start.
//1.2 User is prompted for date of birth.
//1.3 Age is calculated.
//1.4 Age is printed on the screen.


//yaş hesaplama

//ALGORİTMA

//1.2 Başla.
//1.2 Kullanıcıdan doğum tarihi istenir.
//1.3 Yaş hesaplanır.
//1.4 Ekrana yaş yazdırılır.



using System.Globalization;

Console.Write("Date of birth(yyyy.mm.dd): ");
DateTime dob = DateTime.Parse(Console.ReadLine(), new CultureInfo("en"));
DateTime currentDate = DateTime.Now;
TimeSpan difference = currentDate.Subtract(dob);
int yas = (int)(difference.TotalHours / (365 * 24 + 6));

Console.WriteLine($"{yas} years old.");
Console.ReadLine();