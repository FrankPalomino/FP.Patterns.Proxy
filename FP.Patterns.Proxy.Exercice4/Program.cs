using FP.Patterns.Proxy.Exercice4;

IImage imageService = new ProxyImage();

imageService.Display("Tree");
Console.WriteLine("-----------------------------");
imageService.Display("Tree");
Console.WriteLine("-----------------------------");
imageService.Display("Car");
Console.WriteLine("-----------------------------");
imageService.Display("Car");
Console.WriteLine("-----------------------------");
imageService.Display("Car");

