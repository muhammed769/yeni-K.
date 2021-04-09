using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformIslemleri : MonoBehaviour  // BU SCRÝPT BEnim objem isimli objeye aitir.
{
    #region Açýklama
    // Vector iþlemlerini anlamadan transform iþlemleri havada kalacaktýr. Vector 'ler Herhangi bir objenin  yönlerini ve pozisyonlarýný deðiþtirmemizi saðlar.


    /* Vector2 a; // 2 boyutlu oyunlarda
     Vector3 b; // 3 boyutlu oyunlarda
     Vector4 c; // Modelleme gölgelendirme iþlemlerinde 4'üncü boyutta kullanýlmaktadýr.
     Quaternion d;
    */


    // --------------------------------------------------------------------------------------------------------------------------------------------

    /*Vector3 pozisyonum1;      // Pozisyon(Vector) türünde bir deðiþken tanýmladýk.
      Vector3 pozisyonum2;*/

    // --------------------------------------------------------------------------------------------------------------------------------------------
    #endregion



   /* public Transform hedef;  Transform türünde 2 tane obje vermelisin Unity tarafýnda a objesini hedef  kýsmýna sürükledik
      public Transform hedef2;   benimObjemde  Transform türündeki hedef2 alanýnada b'yi sürükledim.*/

    // Biz neden böyle bir þey yaptýk biz objenin SADECE TRANSFORM'UYLA iþlem yapacaksak Gameobject türü yerine SADECE TRANSFORM TÜRÜnü belirtip objeleri öyle sürükleriz.

    // --------------------------------------------------------------------------------------------------------------------------------------------

    private float baslangicZamani;

    void Start()
    {
        baslangicZamani = Time.time;

        /*   Time.time : Oyun baþladýktan sonra ne kadar zaman geçtigini bize söyler.
             Time.deltaTime : Oyun baþladýktan sonra  kaç frame(kare) zamaný  geçtiðini bize söyler.
             Time.timeScale
       */

       
    }

   
    void Update()
    {

        #region  Vector3'ün Static Metotlarý 


        // ************************************************* Max , Min Scale  Metotlarý: ************************************************************************************************************

        //  Max() = Ona verilmiþ olan  2 pozisyonu karþýlaþtýrýyor  ve her koordinattaki en YÜKSEK deðeri alarak bize bir pozisyon sunuyor.

        //  Min() = Ona verilmiþ olan  2 pozisyonu karþýlaþtýrýyor  ve her koordinattaki en DÜÞÜK deðeri alarak bize bir pozisyon sunuyor.

        // Scale() = Ona verilmiþ 2 pozisyonu karþýlaþtýrýyor ve 2 koordinattaki deðerleri çarparak bize sunar.


        /*Vector3 birincipoz = new Vector3(1f, 2f, 3f);
        Vector3 ikincipoz = new Vector3(3f, 5f, 4f);

        print(Vector3.Max(birincipoz, ikincipoz)); // print le Debug.log ayný iþlevi görür.
        print(Vector3.Min(birincipoz, ikincipoz));
        print(Vector3.Scale(birincipoz, ikincipoz));*/


        // --------------------------------------------------------------------------------------------------------------------------------------------


        // ************************************************* Lerp Metodu: 2 vektörün arasýnda doðrusal bir çizgi oluþturur!************************************

        /* 2 vektör arasýnda doðrusal bir çizgi oluþturup birinin diðerinin yanýna gitmesini saðlýcaz.


         Debug.Log(Time.time);
         Debug.Log(Time.deltaTime);

        ----------------------------------------

        Time.timeScale = .5f;
        Debug.Log(Time.time);  Oyunda agýr çekim olmasýný istiyoruz bu 2 kod blogunu kullanmamýz gerekir 0.5f  saniye daha yavaþ geçicek frame 'ler arasýna.
                               Hatta eðer oyunu durdurmak istersek Time.timeScale=0f; yazarýz.

        ----------------------------------------
         transform.position = Vector3.Lerp(hedef.position, hedef2.position, (Time.time-baslangicZamani)* 0.2f); 
         Bana 2 obje ver bu bi objenin diðerine gitme hýzýný ver.[ayrýyetten deðiþken oluþturduk.]

        ----------------------------------------

        Time.timeScale = .5f;
        transform.position = Vector3.Lerp(hedef.position, hedef2.position, (Time.time - baslangicZamani) * 0.2f);
         Bu 2 kod blogu üstteki 2 kod bloguna gör a objesi b objesine daha yavaþ gider çünkü timeScale özelliðini kullandýk.*/


        /* ************************************************* Angle Metodu : 2 vektörün arasýndaki açýyý DERECE CÝNSÝNDEN VERÝR !  *****************************************


           Vector3 mesafe = hedef.position - transform.position;

           float angle = Vector3.Angle(mesafe, transform.up); // forward : açýsal farkýn ölçüldüðü özelliktir.Forward yerine up'da yazabiliriz

           Debug.Log(angle);

           if (angle < 5f)
               Debug.Log("Açý kabul edildi");*/



        // --------------------------------------------------------------------------------------------------------------------------------------------


        /* ************************************************* Distance Metodu: 2 vektörün arasýndaki mesafeyi  VERÝR !************************************

           float aradakifark = Vector3.Distance(hedef.position, transform.position);

           Debug.Log("2 vektör arasýndaki fark þudur : " + aradakifark);*/

        #endregion


        #region transform.Translate - Vector3 Static Özellikler 
        // transform.Translate(new Vector3(3f,5f,2f)); // x y ve z yönlerinde verilen deðerler kapsamýnda objenin sürekli konum deðerlerini degiþtirir yani artýrýr.[OBJENÝN YENÝ KONUMUNUN NASIL OLACAÐINI SÖYLEMÝÞ OLDUK.]

        //transform.Translate(new Vector3(2f, 3f, 5f) * Time.deltaTime); // Time.deltaTime her bir saniyede iþlem yapýlmasýný saðlar bu bize obje konum kontrolü konusunda avantaj saðlar.

        // transform.Translate(new Vector3(0f,0f,-10f) * 1f * Time.deltaTime);

        //transform.Translate(Vector3.back * Time.deltaTime); //  obje GERÝYE STANDART hýzda gider.

        //transform.Translate(Vector3.back * 5f * Time.deltaTime);

        // transform.Translate(Vector3.up * Time.deltaTime);

        // transform.Translate(Vector3.one * Time.deltaTime); // One bütün  koordinatlara 1 verir

        // transform.Translate(Vector3.zero * Time.deltaTime); // zero bütün koordinatlara 0 verir.
        #endregion


        #region Vector3'ün Diðer Metotlarý ve Özellikleri

        /* pozisyonum1 = new Vector3(1f, 4f, 1f);
        pozisyonum2 = new Vector3(1f, 3f, 1f);

        Debug.Log(pozisyonum1.ToString()); */

        // --------------------------------------------------------------------------------------------------------------------------------------------------------------
        /*if (pozisyonum1 == pozisyonum2)
            Debug.Log("Evet 2 vektörün pozisyon ayný.");
        else
            Debug.Log("Hayýr 2 vektörün pozisyonu ayný DEÐÝL.");*/

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* Ýf (Vector3.Equals(pozisyonum1,pozisyonum2) þeklinde yazmýþtýk.Vector3 'ün tool tipinde isim basitleþtirilebilir diyo onun altýnda yazan  Show Potential fixes(olasý düzeltmeleri göster butonuna týkladýk. Daha sonra
             Priview Changes ( deðiþikleri önizle) ' ye týkladýk ve aþagýdaki kod blogu yani Vector3 yazmadan kod blogunu OTOMATÝK OLARAK ÖNÜMÜZE GETÝRDÝ.

          if (Vector3.Equals(pozisyonum1,pozisyonum2)) // Equals metodu ona vermiþ olduðumuz 2 vektörün(pozisyonun)  AYNI OLUP OLMADIÐINI KONTROL EDÝYOR.    // Ýf (Vector3.Equals(pozisyonum1,pozisyonum2) þeklinde yazmýþtýk.
              Debug.Log("Evet 2 vektörün pozisyonu ayný");       
          else       
              Debug.Log("Hayýr 2 vektörün pozisyonu AYNI DEÐÝL.");*/

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Debug.Log(transform.position.normalized);                //  verilen vektörün büyüklüðü NEOLURSA OLSUN  -1  ile +1  deðerleri arasýnda  DÖNDÜRÜR.

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //  Debug.Log(Vector3.SqrMagnitude(transform.position));   // SqrMagnitude metodu  vektörün yani verilen UZUNLUGUN KARESÝNÝ hesaplar !

        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Debug.Log(Vector3.Magnitude(transform.position));       // Magnitude vermiþ oldugum vektörün TOPLAM UZUNLUÐUNU BÝZE DÖNDÜRÜR ! [ Yani bu objenin pozisyon deðerinin kaç olduðunu göstermiþ oldum.

        #endregion


    }
}
