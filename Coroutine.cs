using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{


    //void Start()
    //{
    //   // StartCoroutine(Denemem()); // Oyun baþlar baþlamaz Denemem isimli Coroutine 'nu çalýþtýr demiþ oldum. 
    //}




    // ÖNEMLÝ  : Coroutine 'lar istediðimiz Frame de yani istediðimiz zamanda çalýþan metotlardýr : 

    //IEnumerator Denemem()  // Bu Coroutine'larýn durdurulmasý veya temizlenmesi de mümkündür bu sebeple sýklýkla kullanýrýz ! ( Yönetimi tamamen bize aittir )
    //{
    //    // Burada kodlarýmýz 

    //    // Burada bekleme zamaný 

    //    // Ýstenirse diðer kodlar 

    //    //  Not : Son olarak Coroutine'lar ÇAÐRILMASI GEREKÝR AKSÝ TAKDÝRDE HÝÇBÝR HÜKMÜ YOKTUR. [ Coroutine 'lar Start Metotu ile tetiklenmezlerse çalýþmazlar. ]

    //  ----------------------------------------------------------------- 2.ÖRNEK ------------------------------------------------------------------------------------

    //    //  Debug.Log("1.yazdýrma");

    //    // yield return null;        // [ 1 Frame(kare) bekle demektir ] Coroutine'larda bir þeyi geri döndürmek için yield parametresi kullanýlýr.
    //    //  Debug.Log("2.yazdýrma");

    //            // AÇIKLAMA : Öncelikle 1.yazdýrma yazýsýný yazacak sonra 1 Frame(kare) bekleyecek sonra 2.yazdýrmayý yazdýrcak sonra olayý BÝTÝRCEK.

    //    Debug.Log("1.yazýlým");
    //    yield return new WaitForSeconds(3);
    //    Debug.Log(" 2.yazýlým");

    //          //  AÇIKLAMA :  Öncelikle 1.yazýlým yazýsýný yazacak sonra  3 saniye bekleyecek sonra 2.yazýlým yazýsýný yazdýracak.

    //}

    //  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //private void Start()
    //{
    //    StartCoroutine(Denemem(3)); 
    //}
    //IEnumerator Denemem(float saniye)
    //{
    //    Debug.Log("1.yazýlým");
    //    yield return new WaitForSeconds(saniye);
    //    Debug.Log(" 2.yazýlým");

    //    // AÇIKLAMA  : 1.yazýlým yazýsýný yazacak daha sonra 3 saniye bekleyecek sonra 2. yazýlým yazýsýný yazacak ve YAZMA ÝÞLEMÝNÝ BÝTÝRECEK.
    //}

    //  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    // Peki 1.yazýlým ve 2.yazýlým yazýlarýný 3 er saniye aralýklarla 1 defa yazýp ve bitirdi daha sonrasýnda ben bunun SÜREKLÝ yazmasýný istersem SÖYLE YAPARIZ : 

    //private IEnumerator birinciCoroutine; //  Coroutine  türünde  bir deðiþken(nesne) oluþturduk.

    //private void Start()
    //{
    //    //StartCoroutine(Denemem(3));

    //    birinciCoroutine = Denemem(2);
    //    StartCoroutine(birinciCoroutine);

    //}
    //IEnumerator Denemem(float saniye)
    //{
    //    while (true) // While :  Verilmiþ koþul true olduðu sürece  sonsuz bir þekilde dönecektir.
    //    {
    //        Debug.Log("1.yazýlým");
    //        yield return new WaitForSeconds(saniye);
    //        Debug.Log(" 2.yazýlým");
    //    }
    //}
    //IEnumerator Denemem2(float saniye)
    //{
    //    while (true) // While :  Verilmiþ koþul true olduðu sürece  sonsuz bir þekilde dönecektir.
    //    {
    //        Debug.Log("2.deneme");
    //        yield return new WaitForSeconds(saniye);
    //        Debug.Log(" 2.deneme devamý");
    //    }
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown("space"))
    //    {
    //        StopCoroutine(birinciCoroutine); // boþluk tuþuna basýldýðýnda Coroutine'nun durmasýný saðlamýþ olduk.
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
    //        Debug.Log("1.tekrar baþladý");
    //        yield return new WaitForSeconds(saniye);
    //        Debug.Log("2.tekrar baþladý");
    //    }
    //}
    //IEnumerator tekrar2(float saniyem)
    //{

    //    while (true)
    //    {
    //        Debug.Log("2.tekrar baþladý");
    //        yield return new WaitForSeconds(saniyem);
    //        

    //        Debug.Log("2.tekrar  devam ediyor");
    //    }
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown("space"))
    //    {
    //        StopAllCoroutines();   // 10 - 15 tane Coroutine'larý durdurmak istediðimde bu metotu kullanýrýz.
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
            Debug.Log("1.tekrar baþladý");
            yield return new WaitForSeconds(saniye);

            // yield return new WaitForFixedUpdate();   // BÜTÜN SCRÝPTLERDEKÝ FixedUpdate metotlarýnýn bittikten sonra çalýþmasýný saðlar.

            yield return StartCoroutine(SonradanOlmak()); // tekrar1 Coroutine 'nu çalýþacak daha sonra  Sonradanolmak Coroutine'nu çalýþacak(1 saniye sürecek) daha sonra bu 2 Coroutine sürekli bu þartlar altýnda çalýþmýþ olacak !!!!!!

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
