using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{


    //void Start()
    //{
    //   // StartCoroutine(Denemem()); // Oyun ba�lar ba�lamaz Denemem isimli Coroutine 'nu �al��t�r demi� oldum. 
    //}




    // �NEML�  : Coroutine 'lar istedi�imiz Frame de yani istedi�imiz zamanda �al��an metotlard�r : 

    //IEnumerator Denemem()  // Bu Coroutine'lar�n durdurulmas� veya temizlenmesi de m�mk�nd�r bu sebeple s�kl�kla kullan�r�z ! ( Y�netimi tamamen bize aittir )
    //{
    //    // Burada kodlar�m�z 

    //    // Burada bekleme zaman� 

    //    // �stenirse di�er kodlar 

    //    //  Not : Son olarak Coroutine'lar �A�RILMASI GEREK�R AKS� TAKD�RDE H��B�R H�KM� YOKTUR. [ Coroutine 'lar Start Metotu ile tetiklenmezlerse �al��mazlar. ]

    //  ----------------------------------------------------------------- 2.�RNEK ------------------------------------------------------------------------------------

    //    //  Debug.Log("1.yazd�rma");

    //    // yield return null;        // [ 1 Frame(kare) bekle demektir ] Coroutine'larda bir �eyi geri d�nd�rmek i�in yield parametresi kullan�l�r.
    //    //  Debug.Log("2.yazd�rma");

    //            // A�IKLAMA : �ncelikle 1.yazd�rma yaz�s�n� yazacak sonra 1 Frame(kare) bekleyecek sonra 2.yazd�rmay� yazd�rcak sonra olay� B�T�RCEK.

    //    Debug.Log("1.yaz�l�m");
    //    yield return new WaitForSeconds(3);
    //    Debug.Log(" 2.yaz�l�m");

    //          //  A�IKLAMA :  �ncelikle 1.yaz�l�m yaz�s�n� yazacak sonra  3 saniye bekleyecek sonra 2.yaz�l�m yaz�s�n� yazd�racak.

    //}

    //  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //private void Start()
    //{
    //    StartCoroutine(Denemem(3)); 
    //}
    //IEnumerator Denemem(float saniye)
    //{
    //    Debug.Log("1.yaz�l�m");
    //    yield return new WaitForSeconds(saniye);
    //    Debug.Log(" 2.yaz�l�m");

    //    // A�IKLAMA  : 1.yaz�l�m yaz�s�n� yazacak daha sonra 3 saniye bekleyecek sonra 2. yaz�l�m yaz�s�n� yazacak ve YAZMA ��LEM�N� B�T�RECEK.
    //}

    //  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    // Peki 1.yaz�l�m ve 2.yaz�l�m yaz�lar�n� 3 er saniye aral�klarla 1 defa yaz�p ve bitirdi daha sonras�nda ben bunun S�REKL� yazmas�n� istersem S�YLE YAPARIZ : 

    //private IEnumerator birinciCoroutine; //  Coroutine  t�r�nde  bir de�i�ken(nesne) olu�turduk.

    //private void Start()
    //{
    //    //StartCoroutine(Denemem(3));

    //    birinciCoroutine = Denemem(2);
    //    StartCoroutine(birinciCoroutine);

    //}
    //IEnumerator Denemem(float saniye)
    //{
    //    while (true) // While :  Verilmi� ko�ul true oldu�u s�rece  sonsuz bir �ekilde d�necektir.
    //    {
    //        Debug.Log("1.yaz�l�m");
    //        yield return new WaitForSeconds(saniye);
    //        Debug.Log(" 2.yaz�l�m");
    //    }
    //}
    //IEnumerator Denemem2(float saniye)
    //{
    //    while (true) // While :  Verilmi� ko�ul true oldu�u s�rece  sonsuz bir �ekilde d�necektir.
    //    {
    //        Debug.Log("2.deneme");
    //        yield return new WaitForSeconds(saniye);
    //        Debug.Log(" 2.deneme devam�");
    //    }
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown("space"))
    //    {
    //        StopCoroutine(birinciCoroutine); // bo�luk tu�una bas�ld���nda Coroutine'nun durmas�n� sa�lam�� olduk.
    //    }
    //}


    //  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //private IEnumerator birinciCoroutine;
    //private IEnumerator ikinciCoroutine;


    //private void Start()
    //{
    //    birinciCoroutine = tekrar1(2);
    //    ikinciCoroutine = tekrar2(3);

    //    StartCoroutine(birinciCoroutine);
    //    StartCoroutine(ikinciCoroutine);
    //}

    //IEnumerator tekrar1(float saniye)
    //{

    //    while (true)
    //    {
    //        Debug.Log("1.tekrar ba�lad�");
    //        yield return new WaitForSeconds(saniye);
    //        Debug.Log("2.tekrar ba�lad�");
    //    }
    //}
    //IEnumerator tekrar2(float saniyem)
    //{

    //    while (true)
    //    {
    //        Debug.Log("2.tekrar ba�lad�");
    //        yield return new WaitForSeconds(saniyem);
    //        

    //        Debug.Log("2.tekrar  devam ediyor");
    //    }
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown("space"))
    //    {
    //        StopAllCoroutines();   // 10 - 15 tane Coroutine'lar� durdurmak istedi�imde bu metotu kullan�r�z.
    //    }       
    //}



    //  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    private IEnumerator birinciCoroutine;
   

    private void Start()
    {
        birinciCoroutine = tekrar1(2);
        StartCoroutine(birinciCoroutine);
        
    }
    

    IEnumerator SonradanOlmak()
    {

        while (true)
        {
            Debug.Log("Sonradan olan");
            yield return null;
        }
    }
    IEnumerator tekrar1(float saniye)
    {

        while (true)
        {
            Debug.Log("1.tekrar ba�lad�");
            yield return new WaitForSeconds(saniye);

            // yield return new WaitForFixedUpdate();   // B�T�N SCR�PTLERDEK� FixedUpdate metotlar�n�n bittikten sonra �al��mas�n� sa�lar.

            yield return StartCoroutine(SonradanOlmak()); // tekrar1 Coroutine 'nu �al��acak daha sonra  Sonradanolmak Coroutine'nu �al��acak(1 saniye s�recek) daha sonra bu 2 Coroutine s�rekli bu �artlar alt�nda �al��m�� olacak !!!!!!

        }
    }


    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StopAllCoroutines();
        }
    }




}
