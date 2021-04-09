using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeMethot : MonoBehaviour
{

    // Invoke Methodu :  Bizim belirtmi� oldu�umuz metotu BELL� B�R S�REDEN SONRA �ALI�TIRMAYA YARAR.  Invoke ba�l� yard�mc� metotlarda var bunlar�da g�r�cez yak�n zamanda.



    private void Start()
    {
       // Invoke("birseySole",3f);
        InvokeRepeating("birseySole",3f,4f); // balang��ta 3 saniye sonra birseySole metodu �al���r ve 4 saniye sonra tekrar �al���r .
    }

    void birseySole()
    {
        Debug.Log("Ben fonksiyondan geliyorum");
    }
    private void Update()
    {
        if (IsInvoking("birseySole")) // �al��an bir Invoke metodu var m� yok mu diye bak�yor.[ birseysole Invoke ba�lant�l� metot �al���yor mu bunu kontrol ediyor.]      
        {
            Debug.Log("evet Invoke ba�lant�l� birseySole metodu �al���yor");
            // E�er IsInvoking(" olmayan bir metot ismi yazsayd�k") o zaman console'da  hay�r Invoke ba�lant�l� bir metot �al��m�yor yaz�s�n� s�rekli g�recektik.
        }
        else
            Debug.Log("hay�r Invoke ba�lant�l� bir metot �al��m�yor");


        if (Input.GetKeyDown("space"))
        {
            CancelInvoke(); // tekrar eden InvokeRepeating fonksiyonunu durdurur.
        }
    }
}
