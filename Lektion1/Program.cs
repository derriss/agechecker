using System;
using System.Globalization;


// Personlig introduktion
Console.WriteLine("Välkommen till Ålderskollen! Nu ska vi kolla om du är tillräckligt gammal för att gå på bolaget.");
Thread.Sleep(250);
Console.WriteLine("****************");
Thread.Sleep(250);
Console.WriteLine("Vad heter du?");
string fornamn = Console.ReadLine();
Console.WriteLine("Hej " + fornamn + "! Kul att du är där, och jag är här! Jag plockar fram lite relevanta frågor till dig!");

Thread.Sleep(3000);

// Åldersformulär
Console.WriteLine("Hur gammal är du? ");
string ageinput = Console.ReadLine();
int age = int.Parse(ageinput);
Console.WriteLine("Din ålder är " + age);

Thread.Sleep(500);


// Räkna ut födelseår

int birthYear = 2022 - age;
Console.WriteLine("Du föddes år " + birthYear);

// Ålderskontroll (Får användaren gå på Systembolaget eller inte?)

int timeLeft = 20 - age;

if (age > 20)
{
    Console.WriteLine("Du får gå och köpa bärs på bolaget! Grattis " + fornamn + "!");
}
else
{

    Console.WriteLine("Vad tusan! Din ålder är bara " + age + ". Du får vänta ytterliggare " + timeLeft + " år innan det är din tur att gå till Systembolaget.");
}

// Feedback - När tycker användaren att man borde få gå på bolaget?

Thread.Sleep(1000);
Console.WriteLine("Vill du ha en sammanställning på dina svar? Ja (1)/Nej");
string answerstext = Console.ReadLine();

if (answerstext.Contains("Yes") == true)
{
    Console.WriteLine("Sammanställning från Systembolagskollen");
    Console.WriteLine("Namn: " + fornamn);
    Console.WriteLine("Ålder: " + age);
    Console.WriteLine("Födelseår: " + birthYear);
    if (age < 20)
    {
        Console.WriteLine("Tid kvar:" + timeLeft + "år");
    }

}
else
{
    Console.WriteLine("Okej, tack för idag! Ha en bra dag!");
}