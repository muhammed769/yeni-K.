using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour // BU SCRÝPT BENÝM OBJEM ÝSÝMLÝ OBJEYE AÝTTÝR.    [ Instantiate = OBJE OLUÞTURMA, ÖRNEKLEME]
{
   
    public GameObject orneklenecekObje;

    private float zaman;
    void Start()
    {
        //  Instantiate(orneklenecekObje); // Objeyi sahneye örnekledik.( orneklecekObjenin Prefab'ý hangi konumdaysa  orda oluþacaktýr ve BenimObjemden BAÐIMSIZ BÝR OBJE OLUÞACAKTIR. )

        //  Instantiate(orneklenecekObje, transform);  // (orneklecekObje BenimObjemin child'ý(çocugu) OLACAKTIR.

        //  Instantiate(orneklenecekObje, transform.position, transform.rotation); // (OrneklenecekObje BenimObjemin pozisyonunda ve dönme yönünde OLUÞACAK.)

        //  Instantiate(orneklenecekObje, transform.position, Quaternion.identity); // ( OrneklenecekObje BenimObjemin pozisyonunda doðsun ama bir dönmesi OLMASIN )

        //  Instantiate(orneklenecekObje, new Vector3(1f, 5f, 6f), Quaternion.identity); // (OrneklenecekObje sahnede 1f,5f,6f KOORDÝNATLARINDA OLUÞSUN ve dönmesi OLMASIN. )

        //  Instantiate(orneklenecekObje, new Vector3(transform.position.x, 2f, 5f), Quaternion.identity); // (OrneklenecekObjenin x koordinatý BenimObjemin x koordinatý olsun, y koordinatý 2f z koordinatý 5f olsun diyoruz ve dönmesi OLMASIN. )


   // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

   /*
        GameObject ornekObje = Instantiate(orneklenecekObje, new Vector3(transform.position.y, 2f, 6f), Quaternion.identity);
        ornekObje.GetComponent<BoxCollider>().enabled = false;
        // Sahneye ornekledigim(kod tarafýndan sonradan eklemiþ olduðum) objelerin  componentlerine ulaþýp özelliklerini DEÐÝÞTÝREBÝLÝRÝM BU ÞEKÝLDE !!!!!!!!!!!!


        // YedekObjeme bir SCRÝPT ekle ornekObjem isimli bir SCPRÝT EKLEDÝK.
   */
     // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        zaman=0;

    }


    void Update()
    {
        // 2 saniye aralýklarla orneklenecekObjemi yani YedekObjemi sahneye EKLEEYECEK.[YANÝ 2 SANÝYE ARALIKLA SAHNEYE SÜREKLÝ OBJE EKLENMÝÞ OLACAK !!! ]
        if (zaman >= 2)
        {
            //Instantiate(orneklenecekObje, new Vector3(transform.position.x, 5f, 4f), Quaternion.identity);

            GameObject ornekOBje = Instantiate(orneklenecekObje, new Vector3(transform.position.y, 3f, 7f), Quaternion.identity);
            ornekOBje.GetComponent<BoxCollider>().enabled = false;

            zaman = 0;
        }
        else
        {
            // zaman =zaman+ Time.deltaTime;
               zaman += Time.deltaTime;
        }
    }
}
