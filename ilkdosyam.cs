using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkdosyam : MonoBehaviour
{
    public string ad;
    public int yas;
    public float maas;
    private string memleket;
    public bool arabaVarmi;

    public string[] cocuklar;
    public List<string> amcalar;

    // listeler ile diziler aras�nda ki fark Listelerin �ok daha kolay y�netiliyo olmas�d�r.

    CapsuleCollider benimcapsul;
    
    void Start()
    {

        #region Bilgi 1 
        //memleket = ad;
        //Debug.Log(ad);
        //Debug.Log(yas);
        //Debug.Log(maas);
        //Debug.Log(memleket);
        // Debug.Log(arabaVarmi);

        /*amcalar.Add("Burak");

        if (ad == "Nejat")
            arabaVarmi = true;
        else
            arabaVarmi = false;

        if (arabaVarmi)
            Debug.Log("Evet ad�m nejat  ");
        else
            Debug.Log("Hay�r ad�m nejat  de�il");

      

        foreach (var item in cocuklar)
        {
            Debug.Log(item);
        }*/

        #endregion


        #region Bilgi 2

        /*Capsulum = GetComponent<CapsuleCollider>();
        Capsulum.enabled = false;
        Capsulum.isTrigger = true;
        Capsulum.height = 7;

        // Bir objenin i�erisinde AYNI component'den birden fazla olabilir o y�zden bunu COMPONENTS ' i kullan�r�z. Bunu  ��yle kullan�r�z : 
        CapsuleCollider[] Capsullerim = GetComponents<CapsuleCollider>();

        for (int i = 0; i < Capsullerim.Length; i++) // Capsulllerim dizinin eleman� kadar d�nmek istiyorum.
        {
            Capsullerim[i].isTrigger = true;
        }*/

        #endregion


        #region Bilgi 3 

        /* Unity k�sm�nda objenin alt�nda child objeler ekledi�inde onlarla alakal� i�lemler i�in �u metotlar� kullan�r�z.
        
     
        ve Ana ve Cocuk'un ilkdosyam scriptini pasifle�tirdik.

                     // �STTEK� A�LE YAPILARININ ELEMANLARINI YAKALARIZ.

        GetComponentInParent<AudioSource>().mute = true; // Torun'un �st�ndeki aile �yelerinin componentlerine ula��p onlar�n property'lerini de�i�tirebiliriz !!!
        GetComponentInParent<Rigidbody>().mass = 2f; // Torun'un �st�ndeki aile �yelerinin componentlerine ula��p onlar�n property'lerini de�i�tirebiliriz !!!

        */

        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* Anan�n �lkdosyom scriptini aktifle�tirdik �ocuk ve torunun ilk dosyam scriptlerini pasifle�tirdik ! 

        // ALTTAK� A�LE YAPILARININ ELEMANLARINI YAKALAR VE �ZELL�KLER�N� DE���T�REB�L�R�Z.

        GetComponentInChildren<AudioSource>().mute = false;
        GetComponentInChildren<CapsuleCollider>().isTrigger = true;

        // GetComponentsInChildren
        // GetComponentsInParent */
        #endregion


        #region Bu k�sma kadar yap�lanlar�n TEKRARI

        /*benimcapsul = GetComponent<CapsuleCollider>();

        // benimcapsul.height = 2f;

        CapsuleCollider[] Capsullerim = GetComponents<CapsuleCollider>();

        for (int i = 0; i < Capsullerim.Length; i++)
        {
            Capsullerim[i].isTrigger = true;
        }
        -----------------------------------------------------------------------------------------

        GetComponentInChildren<BoxCollider>().isTrigger = true;
        GetComponentInChildren<CapsuleCollider>().isTrigger = true;


        GetComponentInParent<Rigidbody>().mass = 2;
        GetComponentInParent<CapsuleCollider>().height = 5f;    */
        #endregion

      //  transform.Find("cocuk").GetComponent<AudioSource>().mute = true;  // A��klama : transform.Find metodunda arayacak oldu�um cocuklar�n isimlerini yaz ve yapmak istedi�in kodlar� yaz.

    }
    void Update()
    {
        
    }
}
