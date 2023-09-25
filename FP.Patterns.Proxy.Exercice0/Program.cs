using FP.Patterns.Proxy;

Proxy.ISubject proxy = new Proxy.SimpleProxy();

//proxy.Request(1);
//Console.WriteLine("-----------");
//proxy.Request(2);

Proxy.ISubject safeProxy = new Proxy.SafeProxy();

safeProxy.Request(1);
Console.WriteLine("-----------");
safeProxy.Request(2);