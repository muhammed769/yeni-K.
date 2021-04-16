using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegiskenlericinMethodlar : MonoBehaviour // BU SCRÝPT BenimObjem isimli objeye AÝTTÝR ! ! ! 
{
    private string ad = "Mika";
    private string ad2 = "Nejat";
    private string veri;
    private int sayi = 50;



    void Start()
    {

        #region GetType() Metodu( Deðiþkenin tipini öðrenmek için kullanýrýz. )

        // print(sayi.GetType());

        #endregion


        #region Clone() Metodu ( Deðiþkeni kopyalamaya yarar.)

        // Clone() metodu kullanýmý aþaðýdaki gibidir  ve  deðiþkeni kopyalamaya yarar.

        /*
         
        print(ad);

        string kopyalanan =(string) ad.Clone();
      
        print(kopyalanan);

        */

        #endregion


        #region Equals() Metodu ( Deðiþkeni Sorgulamaya yarar.)

        /*
         
        if(ad.Equals("Mika"))
        {
            print("Evet doðru");
        }
        else
        {
            print("Hayýr yanlýþ");
        }

        */
        #endregion


        #region EndsWtih() Metodu ( Deðiþkenin en az 1 en son harfleriyle sorgu yapmamýzý saðlar.)

        /*
         
        if(ad.EndsWith("ka"))
        {
            print("Evet doðru");
        }
        else
        {
            print("Hayýr yanlýþ");
        }

        */

        #endregion


        #region StartsWith ( Deðiþkenin en az 1 en baþtaki harfleriyle sorgu yapmamýzý saðlar.)

        /*
         
        if (ad.StartsWith("Mi"))
        {
            print("Evet doðru.");
        }
        else
            print("Hayýr yanlýþ");

        */

        #endregion


        #region ToUpper() ve ToLower() Metodlarý
        /*
          
        string yazi = "Ýzmirin boyozu meþhurdur ve simite gevrek denir.";

        print(yazi.ToUpper()); // yazýlan yazýnýn bütün harflerini BÜYÜK  YAPAR.
        print(yazi.ToLower()); // yazýlan yazýnýn bütün harflerini KÜÇÜK YAPAR.

        */


        #endregion


        #region ToString() Metodu

        // print(sayi.ToString()); // sana vermiþ olduðum sayý deðiþkenindeki deðeri string olarak ekrana yazdýr.

        #endregion


        #region Replace() Metodu

        // Girdiðimiz metinde bir kelimeyi deðiþtirip yerine baþka bir kelimeyi koyabilmemizi saðlar.

        /*
          
        string metin = " Birazcýk geç kalýndý ama daha sýký çalýþalým ki geç olsun güç olmasýn";
        print(metin.Replace("ama", "ancak"));

        */
        #endregion


        #region Trim() Metodu 

        /*
         
        // Metnimizdeki baþýndaki ve sonundaki boþluklarý temizler.

        string metin = " Fenerbahçe  fans  ";
        print(metin.Trim());

             // EKrana yazdýrmadan kod iþlemlerine devam edeceksek : 
        metin = metin.Trim();

        */
        #endregion


        #region TrimStart()  ve TrimEnd Metotlarý
        /*

        // TrimStart() Metodu Metnin baþýndaki boþluklarý siler.

        string metin = "           Aliaga da petrol bölgesi vardýr. ";
        print(metin.TrimStart());

        // TrimEnd() Metodu Metnin sonundaki boþluklarý siler.

        print(metin.TrimEnd());

        print(metin.TrimEnd().TrimStart()); //  Tek kod blogunda bÖylece metnin sonundaki boþluklarýný ve baþtaki boþluklarýný silebilmeyi görmüþ olduk.

        */

        #endregion


        #region Substring() Metodu

        /*
        // Ýlgili metin üzerinde iþlem yapar.

        string metin = "Game developer";
        print(metin.Substring(2, 5)); // Yazan metnin 3'üncü harfinden baþla ve 5 birim ilerle VE  YANÝ 3ÜNCÜ HARF ÝLE 8'ÝNCÝ HARFLER ARASINDA NE YAZIYORSA BANA EKRANDA ONLARI YAZDIRCAK.)

        */

        #endregion


        #region Split() Metodu

        /*

        // Split() Metodu  yazdýðýmýz metni parçalamýza yarar.

        string metin = "Ýzmir'de bugün hava çok sýcak";

        string[] parcala = metin.Split(' '); // Metindeki boþluklarý dikkate alarak parçala ve parçaladýðýn elemanlarý dzinin elemanlarý þeklinde göster demiþ olduk.

        foreach (var item in parcala)
        {
            print(item); // Metindeki boþluklarý dikkate alarak parçala ve parçaladýðýn elemanlarý dzinin elemanlarý þeklinde göster demiþ olduk.
        }

        */
        #endregion

    }

}
