using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeMethot : MonoBehaviour
{

    // Invoke Methodu :  Bizim belirtmiþ olduðumuz metotu BELLÝ BÝR SÜREDEN SONRA ÇALIÞTIRMAYA YARAR.  Invoke baðlý yardýmcý metotlarda var bunlarýda görücez yakýn zamanda.



    private void Start()
    {
       // Invoke("birseySole",3f);
        InvokeRepeating("birseySole",3f,4f); // balangýçta 3 saniye sonra birseySole metodu çalýþýr ve 4 saniye sonra tekrar çalýþýr .
    }

    void birseySole()
    {
        Debug.Log("Ben fonksiyondan geliyorum");
    }
    private void Update()
    {
        if (IsInvoking("birseySole")) // Çalýþan bir Invoke metodu var mý yok mu diye bakýyor.[ birseysole Invoke baðlantýlý metot çalýþýyor mu bunu kontrol ediyor.]      
        {
            Debug.Log("evet Invoke baðlantýlý birseySole metodu çalýþýyor");
            // Eðer IsInvoking(" olmayan bir metot ismi yazsaydýk") o zaman console'da  hayýr Invoke baðlantýlý bir metot çalýþmýyor yazýsýný sürekli görecektik.
        }
        else
            Debug.Log("hayýr Invoke baðlantýlý bir metot çalýþmýyor");


        if (Input.GetKeyDown("space"))
        {
            CancelInvoke(); // tekrar eden InvokeRepeating fonksiyonunu durdurur.
        }
    }
}
