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

    // listeler ile diziler arasýnda ki fark Listelerin çok daha kolay yönetiliyo olmasýdýr.

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
            Debug.Log("Evet adým nejat  ");
        else
            Debug.Log("Hayýr adým nejat  deðil");

      

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

        // Bir objenin içerisinde AYNI component'den birden fazla olabilir o yüzden bunu COMPONENTS ' i kullanýrýz. Bunu  þöyle kullanýrýz : 
        CapsuleCollider[] Capsullerim = GetComponents<CapsuleCollider>();

        for (int i = 0; i < Capsullerim.Length; i++) // Capsulllerim dizinin elemaný kadar dönmek istiyorum.
        {
            Capsullerim[i].isTrigger = true;
        }*/

        #endregion


        #region Bilgi 3 

        /* Unity kýsmýnda objenin altýnda child objeler eklediðinde onlarla alakalý iþlemler için þu metotlarý kullanýrýz.
        
     
        ve Ana ve Cocuk'un ilkdosyam scriptini pasifleþtirdik.

                     // ÜSTTEKÝ AÝLE YAPILARININ ELEMANLARINI YAKALARIZ.

        GetComponentInParent<AudioSource>().mute = true; // Torun'un üstündeki aile üyelerinin componentlerine ulaþýp onlarýn property'lerini deðiþtirebiliriz !!!
        GetComponentInParent<Rigidbody>().mass = 2f; // Torun'un üstündeki aile üyelerinin componentlerine ulaþýp onlarýn property'lerini deðiþtirebiliriz !!!

        */

        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /* Ananýn Ýlkdosyom scriptini aktifleþtirdik çocuk ve torunun ilk dosyam scriptlerini pasifleþtirdik ! 

        // ALTTAKÝ AÝLE YAPILARININ ELEMANLARINI YAKALAR VE ÖZELLÝKLERÝNÝ DEÐÝÞTÝREBÝLÝRÝZ.

        GetComponentInChildren<AudioSource>().mute = false;
        GetComponentInChildren<CapsuleCollider>().isTrigger = true;

        // GetComponentsInChildren
        // GetComponentsInParent */
        #endregion


        #region Bu kýsma kadar yapýlanlarýn TEKRARI

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

      //  transform.Find("cocuk").GetComponent<AudioSource>().mute = true;  // Açýklama : transform.Find metodunda arayacak olduðum cocuklarýn isimlerini yaz ve yapmak istediðin kodlarý yaz.

    }
    void Update()
    {
        
    }
}
