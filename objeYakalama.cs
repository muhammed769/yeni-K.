using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeYakalama : MonoBehaviour                                                   // Bu Script (Class)  BenimObjem isimli Objeye aittir !!!!!!!
{

     GameObject yakalad�g�mObje;

     GameObject[] Objeler;

    public GameObject disaridan;
    
    void Start()
    {

        #region GameObject.Find Metodu
        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* GameObject.Find("Ana").GetComponent<ilkdosyam>().maas = 1600;  // Hierarchy'de Ana isimli objeyi arad� ve Ana isimli objenin ilkdosyam isimli component'deki metot, property 'lerine ula�t�k.

           GameObject.Find("Ana/cocuk").GetComponent<ilkdosyam>().yas = 9; // Ana Objesinin cocugu olan cocuk objesinin ba�l� oldu�u class'daki(scriptteki) yas property'sine de�er atad�k.

           GameObject.Find("Ana/cocuk/Torun").GetComponent<ilkdosyam>().ad = "M�kerrrem";


          A��klama :  Find  metodu oyunda bulunan b�t�n sahneler aras�nda  arama yapar  yani �ok fazla kullanmas� PERFORMANSI OLUMSUZ Y�NDE ETK�LEMEKTED�R.
                       �zellikle Find metodunu Update metodunun i�erisine yaz�lmas� KES�NL�KLE VE KES�NL�KLE TAVS�YE ED�LMEZ ! E�er illa oyunda kullanacak de�i�kene tan�mlayarak  Find metodunu kullan�r�z ! 



          yakalad�g�mObje = GameObject.Find("Ana");

          yakalad�g�mObje.GetComponent<ilkdosyam>().yas = 18; */


        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        #endregion GameObject.FindWithTag Metodu


        #region GameObject.FindWithTag Metodu
        /*  yakalad�g�mObje = GameObject.FindWithTag("Player"); // Objeyi Tag'�na(Etiketine) g�re bulmaya �al��.

            yakalad�g�mObje.GetComponent<ilkdosyam>().maas = 4500;

        A��klama : E�er Hierarcy'de Player Tag'�na(ETiketine) SAhip birden fazla obje varsa ilk objeyi yakalar di�er objeleri yakalamay� GARANT� ETMEZ O  SEBEPLEDE FindWithTag metoduda �OK FAZLA  TERC�H ED�LMEZ.*/

        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion


        #region GameObject.FindGameObjectsWithTag Metodu
        /*Objeler = GameObject.FindGameObjectsWithTag("Player"); // Player Tag'�na sahip B�T�N OBJELERiN BUL DEM�� OLDUM.

          foreach (var item in Objeler)
          {
              item.GetComponent<ilkdosyam>().maas = 1000;
          }*/

        //  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        #endregion


        // disaridan.GetComponent<ilkdosyam>().yas = 11; // D��ar�dan manuel olarak Objeyi s�r�kledi�im objenin ilkdosyam isimli scriptine(class'�na) git onun yas  isimli property'sine 11 de�erini ata.


        #region GetComponent Typeof- FindObjectOfType-SetActive-activeSelf

        /*CapsuleCollider capsulum = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;

        CapsuleCollider capsulum = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider; // bi �stteki kodla ayn� i�levi g�r�r

        capsulum.isTrigger = true;

        if(gameObject.GetComponent("CapsuleCollider") as CapsuleCollider)
        {
            gameObject.name = "Ben degistirdim";
        }*/


        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /*Camera cekimarac� = (Camera)FindObjectOfType(typeof(Camera));  // Hieracrhy'deki Camera objesinede bu  objenin ba�l� oldu�u script(YAN� BU SCPR�T) �zerinden ula�abildik !!!

        if (cekimarac�)
        {
            Debug.Log("Evet Kamera var "+cekimarac�.name);
        }
        else
        {
            Debug.Log("Hay�r Kamera yok.");
        }


        Light isik = (Light)FindObjectOfType(typeof(Light)) as Light;

        if (isik)
        {
            Debug.Log("Evet I��k var."+isik.name);
        }
        else
        {
            Debug.Log("Hay�r ���k yok");
        }*/

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* gameObject.SetActive(true); // Bu objeyi aktifli�ni pasifli�ini ayarlayabiliyoruz.

         if (gameObject.activeSelf) // activeSelf obje  aktif mi pasif mi ona g�re true ya da false de�erini d�nd�r�r
         {
             Debug.Log(gameObject.activeSelf);
         }*/
        #endregion


        #region CompareTag - AddComponent

        /* if (gameObject.CompareTag("Dusman")) // objenin tag'� Dusman'sa bana �u i�lemleri yap.
         {
             Debug.Log("Evet do�ru");
         }
         else
         {
             Debug.Log("Hay�r");
         }*/

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* Rigidbody ekledim =  gameObject.AddComponent<Rigidbody>() as Rigidbody;
           ekledim.isKinematic = true;

           CapsuleCollider ekledim =  gameObject.AddComponent(typeof(CapsuleCollider)) as CapsuleCollider;
           ekledim.isTrigger = true;*/
        #endregion


    }


}
