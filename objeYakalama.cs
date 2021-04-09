using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeYakalama : MonoBehaviour                                                   // Bu Script (Class)  BenimObjem isimli Objeye aittir !!!!!!!
{

     GameObject yakaladýgýmObje;

     GameObject[] Objeler;

    public GameObject disaridan;
    
    void Start()
    {

        #region GameObject.Find Metodu
        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* GameObject.Find("Ana").GetComponent<ilkdosyam>().maas = 1600;  // Hierarchy'de Ana isimli objeyi aradý ve Ana isimli objenin ilkdosyam isimli component'deki metot, property 'lerine ulaþtýk.

           GameObject.Find("Ana/cocuk").GetComponent<ilkdosyam>().yas = 9; // Ana Objesinin cocugu olan cocuk objesinin baðlý olduðu class'daki(scriptteki) yas property'sine deðer atadýk.

           GameObject.Find("Ana/cocuk/Torun").GetComponent<ilkdosyam>().ad = "Mükerrrem";


          Açýklama :  Find  metodu oyunda bulunan bütün sahneler arasýnda  arama yapar  yani çok fazla kullanmasý PERFORMANSI OLUMSUZ YÖNDE ETKÝLEMEKTEDÝR.
                       Özellikle Find metodunu Update metodunun içerisine yazýlmasý KESÝNLÝKLE VE KESÝNLÝKLE TAVSÝYE EDÝLMEZ ! Eðer illa oyunda kullanacak deðiþkene tanýmlayarak  Find metodunu kullanýrýz ! 



          yakaladýgýmObje = GameObject.Find("Ana");

          yakaladýgýmObje.GetComponent<ilkdosyam>().yas = 18; */


        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        #endregion GameObject.FindWithTag Metodu


        #region GameObject.FindWithTag Metodu
        /*  yakaladýgýmObje = GameObject.FindWithTag("Player"); // Objeyi Tag'ýna(Etiketine) göre bulmaya çalýþ.

            yakaladýgýmObje.GetComponent<ilkdosyam>().maas = 4500;

        Açýklama : Eðer Hierarcy'de Player Tag'ýna(ETiketine) SAhip birden fazla obje varsa ilk objeyi yakalar diðer objeleri yakalamayý GARANTÝ ETMEZ O  SEBEPLEDE FindWithTag metoduda ÇOK FAZLA  TERCÝH EDÝLMEZ.*/

        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion


        #region GameObject.FindGameObjectsWithTag Metodu
        /*Objeler = GameObject.FindGameObjectsWithTag("Player"); // Player Tag'ýna sahip BÜTÜN OBJELERiN BUL DEMÝÞ OLDUM.

          foreach (var item in Objeler)
          {
              item.GetComponent<ilkdosyam>().maas = 1000;
          }*/

        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        #endregion


        // disaridan.GetComponent<ilkdosyam>().yas = 11; // Dýþarýdan manuel olarak Objeyi sürüklediðim objenin ilkdosyam isimli scriptine(class'ýna) git onun yas  isimli property'sine 11 deðerini ata.


        #region GetComponent Typeof- FindObjectOfType-SetActive-activeSelf

        /*CapsuleCollider capsulum = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;

        CapsuleCollider capsulum = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider; // bi üstteki kodla ayný iþlevi görür

        capsulum.isTrigger = true;

        if(gameObject.GetComponent("CapsuleCollider") as CapsuleCollider)
        {
            gameObject.name = "Ben degistirdim";
        }*/


        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /*Camera cekimaracý = (Camera)FindObjectOfType(typeof(Camera));  // Hieracrhy'deki Camera objesinede bu  objenin baðlý olduðu script(YANÝ BU SCPRÝT) üzerinden ulaþabildik !!!

        if (cekimaracý)
        {
            Debug.Log("Evet Kamera var "+cekimaracý.name);
        }
        else
        {
            Debug.Log("Hayýr Kamera yok.");
        }


        Light isik = (Light)FindObjectOfType(typeof(Light)) as Light;

        if (isik)
        {
            Debug.Log("Evet Iþýk var."+isik.name);
        }
        else
        {
            Debug.Log("Hayýr ýþýk yok");
        }*/

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* gameObject.SetActive(true); // Bu objeyi aktifliðni pasifliðini ayarlayabiliyoruz.

         if (gameObject.activeSelf) // activeSelf obje  aktif mi pasif mi ona göre true ya da false deðerini döndürür
         {
             Debug.Log(gameObject.activeSelf);
         }*/
        #endregion


        #region CompareTag - AddComponent

        /* if (gameObject.CompareTag("Dusman")) // objenin tag'ý Dusman'sa bana þu iþlemleri yap.
         {
             Debug.Log("Evet doðru");
         }
         else
         {
             Debug.Log("Hayýr");
         }*/

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* Rigidbody ekledim =  gameObject.AddComponent<Rigidbody>() as Rigidbody;
           ekledim.isKinematic = true;

           CapsuleCollider ekledim =  gameObject.AddComponent(typeof(CapsuleCollider)) as CapsuleCollider;
           ekledim.isTrigger = true;*/
        #endregion


    }


}
