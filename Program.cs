string[] stensaxpåse = File.ReadAllLines("/Users/DaciBaci/Downloads/kombination.txt");


int points = 0;

// x = förlora
// y = lika
// z = vinna

for (int i = 0; i < stensaxpåse.Length; i++)
{
    if (stensaxpåse[i].Contains("A X"))

    { points += 3; }

    //Sten vs sax - Förlust

    else if (stensaxpåse[i].Contains("A Y"))
    { points += 4; }
    //Sten vs sten - lika

    else if (stensaxpåse[i].Contains("A Z"))
    { points += 8; } // 12 
    //sten vs påse - vinst

    else if (stensaxpåse[i].Contains("B X"))
    { points += 1; }
    //påse vs sten - förlust

    else if (stensaxpåse[i].Contains("B Y"))
    { points += 5; }
    //påse vs påse - lika

    else if (stensaxpåse[i].Contains("B Z"))
    { points += 9; }
    // påse vs sax - vinst

    else if (stensaxpåse[i].Contains("C X"))
    { points += 2; }
    //sax vs påse - förlust

    else if (stensaxpåse[i].Contains("C Y"))
    { points += 6; }
    //sax vs sax - lika

    else if (stensaxpåse[i].Contains("C Z"))
    { points += 7; }
    //sax vs sten -vinst



    //slut poäng är 12374



}
Console.WriteLine(points);
