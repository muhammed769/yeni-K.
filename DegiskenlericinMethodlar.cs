using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegiskenlericinMethodlar : MonoBehaviour // BU SCR�PT BenimObjem isimli objeye A�TT�R ! ! ! 
{
    private string ad = "Mika";
    private string ad2 = "Nejat";
    private string veri;
    private int sayi = 50;



    void Start()
    {

        #region GetType() Metodu( De�i�kenin tipini ��renmek i�in kullan�r�z. )

        // print(sayi.GetType());

        #endregion


        #region Clone() Metodu ( De�i�keni kopyalamaya yarar.)

        // Clone() metodu kullan�m� a�a��daki gibidir  ve  de�i�keni kopyalamaya yarar.

        /*
         
        print(ad);

        string kopyalanan =(string) ad.Clone();
      
        print(kopyalanan);

        */

        #endregion


        #region Equals() Metodu ( De�i�keni Sorgulamaya yarar.)

        /*
         
        if(ad.Equals("Mika"))
        {
            print("Evet do�ru");
        }
        else
        {
            print("Hay�r yanl��");
        }

        */
        #endregion


        #region EndsWtih() Metodu ( De�i�kenin en az 1 en son harfleriyle sorgu yapmam�z� sa�lar.)

        /*
         
        if(ad.EndsWith("ka"))
        {
            print("Evet do�ru");
        }
        else
        {
            print("Hay�r yanl��");
        }

        */

        #endregion


        #region StartsWith ( De�i�kenin en az 1 en ba�taki harfleriyle sorgu yapmam�z� sa�lar.)

        /*
         
        if (ad.StartsWith("Mi"))
        {
            print("Evet do�ru.");
        }
        else
            print("Hay�r yanl��");

        */

        #endregion


        #region ToUpper() ve ToLower() Metodlar�
        /*
          
        string yazi = "�zmirin boyozu me�hurdur ve simite gevrek denir.";

        print(yazi.ToUpper()); // yaz�lan yaz�n�n b�t�n harflerini B�Y�K  YAPAR.
        print(yazi.ToLower()); // yaz�lan yaz�n�n b�t�n harflerini K���K YAPAR.

        */


        #endregion


        #region ToString() Metodu

        // print(sayi.ToString()); // sana vermi� oldu�um say� de�i�kenindeki de�eri string olarak ekrana yazd�r.

        #endregion


        #region Replace() Metodu

        // Girdi�imiz metinde bir kelimeyi de�i�tirip yerine ba�ka bir kelimeyi koyabilmemizi sa�lar.

        /*
          
        string metin = " Birazc�k ge� kal�nd� ama daha s�k� �al��al�m ki ge� olsun g�� olmas�n";
        print(metin.Replace("ama", "ancak"));

        */
        #endregion


        #region Trim() Metodu 

        /*
         
        // Metnimizdeki ba��ndaki ve sonundaki bo�luklar� temizler.

        string metin = " Fenerbah�e  fans  ";
        print(metin.Trim());

             // EKrana yazd�rmadan kod i�lemlerine devam edeceksek : 
        metin = metin.Trim();

        */
        #endregion


        #region TrimStart()  ve TrimEnd Metotlar�
        /*

        // TrimStart() Metodu Metnin ba��ndaki bo�luklar� siler.

        string metin = "           Aliaga da petrol b�lgesi vard�r. ";
        print(metin.TrimStart());

        // TrimEnd() Metodu Metnin sonundaki bo�luklar� siler.

        print(metin.TrimEnd());

        print(metin.TrimEnd().TrimStart()); //  Tek kod blogunda b�ylece metnin sonundaki bo�luklar�n� ve ba�taki bo�luklar�n� silebilmeyi g�rm�� olduk.

        */

        #endregion


        #region Substring() Metodu

        /*
        // �lgili metin �zerinde i�lem yapar.

        string metin = "Game developer";
        print(metin.Substring(2, 5)); // Yazan metnin 3'�nc� harfinden ba�la ve 5 birim ilerle VE  YAN� 3�NC� HARF �LE 8'�NC� HARFLER ARASINDA NE YAZIYORSA BANA EKRANDA ONLARI YAZDIRCAK.)

        */

        #endregion


        #region Split() Metodu

        /*

        // Split() Metodu  yazd���m�z metni par�alam�za yarar.

        string metin = "�zmir'de bug�n hava �ok s�cak";

        string[] parcala = metin.Split(' '); // Metindeki bo�luklar� dikkate alarak par�ala ve par�alad���n elemanlar� dzinin elemanlar� �eklinde g�ster demi� olduk.

        foreach (var item in parcala)
        {
            print(item); // Metindeki bo�luklar� dikkate alarak par�ala ve par�alad���n elemanlar� dzinin elemanlar� �eklinde g�ster demi� olduk.
        }

        */
        #endregion

    }

}
