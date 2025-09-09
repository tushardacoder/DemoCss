using Task1;

NumberTransformer transformer = new NumberTransformer();
transformer.AddDigit(2);
transformer.AddDigit(5);
transformer.AddDigit([6, 9]);
transformer.AddDigit(9);

Console.WriteLine(transformer.Number); // output should be 25699


NumberTransformer transformer2 = new NumberTransformer(938);
transformer2.AddDigit(3);
transformer2.AddDigit(0);
transformer2.AddDigit([1, 9, 7, 2]);
Console.WriteLine(transformer2.Number); // output should be 938301972

 //transformer.Number = 4; // make sure this doesn't work.