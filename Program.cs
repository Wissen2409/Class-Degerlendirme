

// string bir  class'tır ancak class olamsına rağmen değer tipli davranışı sergiler, her class referans tiplidir
Ogrenci o = new Ogrenci();
Console.WriteLine("Id : {0}",o.Id);
Console.WriteLine("Ad : {0}",o.Ad);

Degistir(o);
Console.WriteLine("Id : {0}",o.Id);
Console.WriteLine("Ad : {0}",o.Ad);

// sadece ad alanını metoda gönderip, değer tip ve refernas tip kontrolü yapıyorum
AdDegistir1(o.Ad);
Console.WriteLine("Yeni  Ad : {0}",o.Ad);



static void Degistir(Ogrenci o){
    o.Id=10;
    o.Ad="Kemalettin";
}
static void AdDegistir(Ogrenci o){
    // bu senaryoda referans tipli davranışı sergilenecektir
}
static void AdDegistir1(string ad){
    ad="Yavuz";
}

// string tipi referans tipli oolamsına rağmen, değer atama ve metotlara parametre geçme işlemierinde, değer tipli gibi davranacaktır!!!!!

