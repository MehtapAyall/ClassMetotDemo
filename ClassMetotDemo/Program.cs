// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Customer kisi1 = new Customer();
kisi1.name = "Mehtap";
kisi1.surname = "Ayal";
kisi1.cutomerNo = "123";
kisi1.balance = 12000;
kisi1.age = 25;

Customer kisi2 = new Customer();
kisi2.name = "Ayşe";
kisi2.surname = "Songül";
kisi2.cutomerNo = "456";
kisi2.balance = 4856;
kisi2.age = 65;


Customer[] customers = {kisi1, kisi2 };

CustomerManager manager = new CustomerManager();

manager.customerInsert(kisi1);
manager.customerList(customers);
manager.customerDelete(kisi2);

