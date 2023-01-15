using ServiceReference;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
iTrackClient cc = new iTrackClient();
TrackRslt[] results = await cc.getSMSATrackingAsync("en","290385888574","username","password");
Console.WriteLine(results);