using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YolArkadasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

        tekrar://Burada eğer kullanıcı başka işlem yapmak isterse goto ile tekrar işlem yapmasını sağlayacağız.

            Console.WriteLine("Sitemize hoş geldinizi!!!\n");
            Console.WriteLine("1-BODRUM (Paket başlangıç fiyatı 4000 Tl)\n"); double Bodrum = 4000;  //tatil yapmak istediği yerleri ekrana yazalım ve fiyatlarınıda double değişkeni ile tutalım.
            Console.WriteLine("2-MARMARİS (Paket başlangıç fiyatı 3000 Tl)\n"); double Marmaris = 3000;
            Console.WriteLine("3-ÇEŞME (Paket başlangıç fiyatı 5000 tl)\n"); double Çeşme = 5000;



            Console.WriteLine("Tatil yapmak istediğiniz yeri seçiniz:");//tatil yapmak istediği yeri kullanıcdan alalım.
            string KullanıcıSeçim = Console.ReadLine();
            KullanıcıSeçim = KullanıcıSeçim.ToUpper();





            Console.WriteLine("Kaç kişi ile tatil yapmak istersiniz?");//Burdada kişi sayisini aldık
            int KişiSayisi = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("Hangi ulaşım yolunu tercih edersiniz.Hava - Kara");
            string Ulaşım = Console.ReadLine().ToLower();

            double Kara = 1500;//Ulaşım fiyatlarını Hava ve Kara değişkenlerinde tutalım.
            double Hava = 4000;

            double tutar = 0;//tutar değişkeninde ;tutat=(KişiSayisi * Hava) + seçtiği tatil yerini tutacağız ve ekrana yazdıracağız.


            bool Döngü = true;//Döngü değişkeni true olduğu sürece,while dongüsünde işlem yapmaya devam edebileceğiz.

            while (Döngü == true)
            {



                if (KullanıcıSeçim == "BODRUM")//tatil yapmak istediği yer,ekrana yazdırdığımız yerlerle uyuşuyorsa aşağıdaki işlemleri yapıyoruz
                {

                    Console.WriteLine("Avrupa'nın en iyi diskolarından biri olan Bodrum'un diskolarından birini tercih ederek eğlenceli bir gece geçirebilirsiniz. Türkiye'nin turkuaz kıyılarında unutulmaz bir “Mavi Yolculuk” yapabilir, Kekova'yı ya da Büyük İskender'in kış aylarında konakladığı antik Phaselis limanını ziyaret edebilirsiniz.\n");


                    if (Ulaşım == "hava")
                    {
                        tutar = (KişiSayisi * Hava) + Bodrum;//Eğer ulaşım hava ise KişiSayisini Hava değişkeni ile çarpalım ve toplam tutarı ekrana yazdıralım

                        Console.WriteLine("Toplam tatil tutarınız :{0} Tl", tutar);
                    }
                    else if (Ulaşım == "kara")
                    {
                        tutar = (KişiSayisi * Kara) + Bodrum;//Ulaşım kara ise KişiSayisi * Kara yapalım ve tutarı ekrana yazdıralım

                        Console.WriteLine("Toplam tatil tutarınız :{0} Tl", tutar);
                    }


                }
                else if (KullanıcıSeçim == "MARMARİS")
                {

                    Console.WriteLine("Doğal güzellikleri, uzun sahil şeridi, çam ormanlarıyla kaplı tepelerinden muhteşem manzarası, bakir koyları, eşsiz plajları, antik kentleri, yat marinaları ve her türlü aktiviteyi sunmasıyla keyifli günler geçireceksiniz\n");
                    if (Ulaşım == "hava")
                    {
                        tutar = (KişiSayisi * Hava) + Marmaris;

                        Console.WriteLine("Toplam tatil tutarınız :{0} Tl", tutar);
                    }
                    else if (Ulaşım == "kara")
                    {
                        tutar = (KişiSayisi * Kara) + Marmaris;

                        Console.WriteLine("Toplam tatil tutarınız :{0} Tl", tutar);
                    }

                }
                else if (KullanıcıSeçim == "ÇEŞME") //Aynı işlemleri çeşmeye kadar alalım.
                {
                    Console.WriteLine("Sığ ve berrak bir denize sahip olan Çeşme sahilleri, muhteşem Ege sularında hem dinlendirici hem de eğlenceli bir tatil olanağı ile keyifli günler geçireceksiniz \n");

                    if (Ulaşım == "hava")
                    {
                        tutar = (KişiSayisi * Hava) + Çeşme;

                        Console.WriteLine("Toplam tatil tutarınız :{0} Tl", tutar);
                    }
                    else if (Ulaşım == "kara")
                    {
                        tutar = (KişiSayisi * Kara) + Çeşme;

                        Console.WriteLine("Toplam tatil tutarınız :{0} Tl", tutar);
                    }

                }
                else//Eğer kullanıcı başka tatil yeri yazdıysa hata mesajı verelim.
                {
                    Console.WriteLine("Yanlış seçim");
                }



            //Burası programın son kısmı !!!

            Seçim://Evet Ya da hayır dan başka cevap yazdıysa goto ile işlemi tekrar yapmasını söylüyoruz
                Console.WriteLine("Başka islem yapmak ister misiniz? Evet/Hayır");//Kullanıcıya başka işlem yapıp yapmayacağını soralım.
                string islem = Console.ReadLine();
                islem = islem.ToLower();

                Console.Clear();

                if (islem == "evet")
                {
                    goto tekrar;//Başka işlem yapacaksa en başa goto ile gonderiyoruz

                }
                else if (islem == "hayır")
                {
                    Döngü = false;//Başka işlem yapmicaksa While'ın içindeki Döngü değişkenini False yapıp programı sonlandırıyoruz.
                    Console.WriteLine("bizi sectiğiniz için teşekkür ederiz!!!");
                }
                else
                {
                    Console.WriteLine("Yanlış seçim lutfen tekrar denyiniz");
                    goto Seçim;//Yanlış işlem yaptıysa başa dönuyoruz.
                }


            }





            Console.ReadKey();

        }
    }
}
