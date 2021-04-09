using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformIslemleri : MonoBehaviour  // BU SCR�PT BEnim objem isimli objeye aitir.
{
    #region A��klama
    // Vector i�lemlerini anlamadan transform i�lemleri havada kalacakt�r. Vector 'ler Herhangi bir objenin  y�nlerini ve pozisyonlar�n� de�i�tirmemizi sa�lar.


    /* Vector2 a; // 2 boyutlu oyunlarda
     Vector3 b; // 3 boyutlu oyunlarda
     Vector4 c; // Modelleme g�lgelendirme i�lemlerinde 4'�nc� boyutta kullan�lmaktad�r.
     Quaternion d;
    */


    // --------------------------------------------------------------------------------------------------------------------------------------------

    /*Vector3 pozisyonum1;      // Pozisyon(Vector) t�r�nde bir de�i�ken tan�mlad�k.
      Vector3 pozisyonum2;*/

    // --------------------------------------------------------------------------------------------------------------------------------------------
    #endregion



   /* public Transform hedef;  Transform t�r�nde 2 tane obje vermelisin Unity taraf�nda a objesini hedef  k�sm�na s�r�kledik
      public Transform hedef2;   benimObjemde  Transform t�r�ndeki hedef2 alan�nada b'yi s�r�kledim.*/

    // Biz neden b�yle bir �ey yapt�k biz objenin SADECE TRANSFORM'UYLA i�lem yapacaksak Gameobject t�r� yerine SADECE TRANSFORM T�R�n� belirtip objeleri �yle s�r�kleriz.

    // --------------------------------------------------------------------------------------------------------------------------------------------

    private float baslangicZamani;

    void Start()
    {
        baslangicZamani = Time.time;

        /*   Time.time : Oyun ba�lad�ktan sonra ne kadar zaman ge�tigini bize s�yler.
             Time.deltaTime : Oyun ba�lad�ktan sonra  ka� frame(kare) zaman�  ge�ti�ini bize s�yler.
             Time.timeScale
       */

       
    }

   
    void Update()
    {

        #region  Vector3'�n Static Metotlar� 


        // ************************************************* Max , Min Scale  Metotlar�: ************************************************************************************************************

        //  Max() = Ona verilmi� olan  2 pozisyonu kar��la�t�r�yor  ve her koordinattaki en Y�KSEK de�eri alarak bize bir pozisyon sunuyor.

        //  Min() = Ona verilmi� olan  2 pozisyonu kar��la�t�r�yor  ve her koordinattaki en D���K de�eri alarak bize bir pozisyon sunuyor.

        // Scale() = Ona verilmi� 2 pozisyonu kar��la�t�r�yor ve 2 koordinattaki de�erleri �arparak bize sunar.


        /*Vector3 birincipoz = new Vector3(1f, 2f, 3f);
        Vector3 ikincipoz = new Vector3(3f, 5f, 4f);

        print(Vector3.Max(birincipoz, ikincipoz)); // print le Debug.log ayn� i�levi g�r�r.
        print(Vector3.Min(birincipoz, ikincipoz));
        print(Vector3.Scale(birincipoz, ikincipoz));*/


        // --------------------------------------------------------------------------------------------------------------------------------------------


        // ************************************************* Lerp Metodu: 2 vekt�r�n aras�nda do�rusal bir �izgi olu�turur!************************************

        /* 2 vekt�r aras�nda do�rusal bir �izgi olu�turup birinin di�erinin yan�na gitmesini sa�l�caz.


         Debug.Log(Time.time);
         Debug.Log(Time.deltaTime);

        ----------------------------------------

        Time.timeScale = .5f;
        Debug.Log(Time.time);  Oyunda ag�r �ekim olmas�n� istiyoruz bu 2 kod blogunu kullanmam�z gerekir 0.5f  saniye daha yava� ge�icek frame 'ler aras�na.
                               Hatta e�er oyunu durdurmak istersek Time.timeScale=0f; yazar�z.

        ----------------------------------------
         transform.position = Vector3.Lerp(hedef.position, hedef2.position, (Time.time-baslangicZamani)* 0.2f); 
         Bana 2 obje ver bu bi objenin di�erine gitme h�z�n� ver.[ayr�yetten de�i�ken olu�turduk.]

        ----------------------------------------

        Time.timeScale = .5f;
        transform.position = Vector3.Lerp(hedef.position, hedef2.position, (Time.time - baslangicZamani) * 0.2f);
         Bu 2 kod blogu �stteki 2 kod bloguna g�r a objesi b objesine daha yava� gider ��nk� timeScale �zelli�ini kulland�k.*/


        /* ************************************************* Angle Metodu : 2 vekt�r�n aras�ndaki a��y� DERECE C�NS�NDEN VER�R !  *****************************************


           Vector3 mesafe = hedef.position - transform.position;

           float angle = Vector3.Angle(mesafe, transform.up); // forward : a��sal fark�n �l��ld��� �zelliktir.Forward yerine up'da yazabiliriz

           Debug.Log(angle);

           if (angle < 5f)
               Debug.Log("A�� kabul edildi");*/



        // --------------------------------------------------------------------------------------------------------------------------------------------


        /* ************************************************* Distance Metodu: 2 vekt�r�n aras�ndaki mesafeyi  VER�R !************************************

           float aradakifark = Vector3.Distance(hedef.position, transform.position);

           Debug.Log("2 vekt�r aras�ndaki fark �udur : " + aradakifark);*/

        #endregion


        #region transform.Translate - Vector3 Static �zellikler 
        // transform.Translate(new Vector3(3f,5f,2f)); // x y ve z y�nlerinde verilen de�erler kapsam�nda objenin s�rekli konum de�erlerini degi�tirir yani art�r�r.[OBJEN�N YEN� KONUMUNUN NASIL OLACA�INI S�YLEM�� OLDUK.]

        //transform.Translate(new Vector3(2f, 3f, 5f) * Time.deltaTime); // Time.deltaTime her bir saniyede i�lem yap�lmas�n� sa�lar bu bize obje konum kontrol� konusunda avantaj sa�lar.

        // transform.Translate(new Vector3(0f,0f,-10f) * 1f * Time.deltaTime);

        //transform.Translate(Vector3.back * Time.deltaTime); //  obje GER�YE STANDART h�zda gider.

        //transform.Translate(Vector3.back * 5f * Time.deltaTime);

        // transform.Translate(Vector3.up * Time.deltaTime);

        // transform.Translate(Vector3.one * Time.deltaTime); // One b�t�n  koordinatlara 1 verir

        // transform.Translate(Vector3.zero * Time.deltaTime); // zero b�t�n koordinatlara 0 verir.
        #endregion


        #region Vector3'�n Di�er Metotlar� ve �zellikleri

        /* pozisyonum1 = new Vector3(1f, 4f, 1f);
        pozisyonum2 = new Vector3(1f, 3f, 1f);

        Debug.Log(pozisyonum1.ToString()); */

        // --------------------------------------------------------------------------------------------------------------------------------------------------------------
        /*if (pozisyonum1 == pozisyonum2)
            Debug.Log("Evet 2 vekt�r�n pozisyon ayn�.");
        else
            Debug.Log("Hay�r 2 vekt�r�n pozisyonu ayn� DE��L.");*/

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* �f (Vector3.Equals(pozisyonum1,pozisyonum2) �eklinde yazm��t�k.Vector3 '�n tool tipinde isim basitle�tirilebilir diyo onun alt�nda yazan  Show Potential fixes(olas� d�zeltmeleri g�ster butonuna t�klad�k. Daha sonra
             Priview Changes ( de�i�ikleri �nizle) ' ye t�klad�k ve a�ag�daki kod blogu yani Vector3 yazmadan kod blogunu OTOMAT�K OLARAK �N�M�ZE GET�RD�.

          if (Vector3.Equals(pozisyonum1,pozisyonum2)) // Equals metodu ona vermi� oldu�umuz 2 vekt�r�n(pozisyonun)  AYNI OLUP OLMADI�INI KONTROL ED�YOR.    // �f (Vector3.Equals(pozisyonum1,pozisyonum2) �eklinde yazm��t�k.
              Debug.Log("Evet 2 vekt�r�n pozisyonu ayn�");       
          else       
              Debug.Log("Hay�r 2 vekt�r�n pozisyonu AYNI DE��L.");*/

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Debug.Log(transform.position.normalized);                //  verilen vekt�r�n b�y�kl��� NEOLURSA OLSUN  -1  ile +1  de�erleri aras�nda  D�ND�R�R.

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //  Debug.Log(Vector3.SqrMagnitude(transform.position));   // SqrMagnitude metodu  vekt�r�n yani verilen UZUNLUGUN KARES�N� hesaplar !

        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Debug.Log(Vector3.Magnitude(transform.position));       // Magnitude vermi� oldugum vekt�r�n TOPLAM UZUNLU�UNU B�ZE D�ND�R�R ! [ Yani bu objenin pozisyon de�erinin ka� oldu�unu g�stermi� oldum.

        #endregion


    }
}
