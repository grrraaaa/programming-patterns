using Lab6Lib;
using PP_06;

Publisher event1 = new Publisher("EVENT-1");
Publisher event2 = new Publisher("EVENT-2");
Publisher event3 = new Publisher("EVENT-3");

SubscriberA subscriberA = new SubscriberA();
SubscriberB subscriberB = new SubscriberB();
SubscriberC subscriberC = new SubscriberC();

Console.WriteLine("--------------------Тест 1 ------------------");
event1.Subscribe(subscriberA);
event2.Subscribe(subscriberA);
event3.Subscribe(subscriberA);
event1.Notify(); event2.Notify(); event3.Notify();

Console.WriteLine("--------------------Тест 2 ------------------");
event1.Subscribe(subscriberB);
event2.UnSubcribe(subscriberA);
event1.Notify(); event2.Notify(); event3.Notify();

Console.WriteLine("--------------------Тест 3 ------------------");
event2.Subscribe(subscriberB);
event3.Subscribe(subscriberC);
event1.Notify(); event2.Notify(); event3.Notify();

Console.WriteLine("--------------------Тест 4 ------------------");
event2.Subscribe(subscriberB);
event3.Subscribe(subscriberC);
event1.Notify(); event2.Notify(); event3.Notify();

Console.WriteLine("--------------------Тест 5 ------------------");
event1.UnSubcribe(subscriberA);
event1.UnSubcribe(subscriberB);
event2.UnSubcribe(subscriberB);
event3.UnSubcribe(subscriberA);
event3.UnSubcribe(subscriberC);
event1.Notify(); event2.Notify(); event3.Notify();
