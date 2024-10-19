

// string hariç , her class referans tiplidir
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

// 
