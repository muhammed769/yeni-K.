using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour // BU SCR�PT BEN�M OBJEM �S�ML� OBJEYE A�TT�R.    [ Instantiate = OBJE OLU�TURMA, �RNEKLEME]
{
   
    public GameObject orneklenecekObje;

    private float zaman;
    void Start()
    {
        //  Instantiate(orneklenecekObje); // Objeyi sahneye �rnekledik.( orneklecekObjenin Prefab'� hangi konumdaysa  orda olu�acakt�r ve BenimObjemden BA�IMSIZ B�R OBJE OLU�ACAKTIR. )

        //  Instantiate(orneklenecekObje, transform);  // (orneklecekObje BenimObjemin child'�(�ocugu) OLACAKTIR.

        //  Instantiate(orneklenecekObje, transform.position, transform.rotation); // (OrneklenecekObje BenimObjemin pozisyonunda ve d�nme y�n�nde OLU�ACAK.)

        //  Instantiate(orneklenecekObje, transform.position, Quaternion.identity); // ( OrneklenecekObje BenimObjemin pozisyonunda do�sun ama bir d�nmesi OLMASIN )

        //  Instantiate(orneklenecekObje, new Vector3(1f, 5f, 6f), Quaternion.identity); // (OrneklenecekObje sahnede 1f,5f,6f KOORD�NATLARINDA OLU�SUN ve d�nmesi OLMASIN. )

        //  Instantiate(orneklenecekObje, new Vector3(transform.position.x, 2f, 5f), Quaternion.identity); // (OrneklenecekObjenin x koordinat� BenimObjemin x koordinat� olsun, y koordinat� 2f z koordinat� 5f olsun diyoruz ve d�nmesi OLMASIN. )


   // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

   /*
        GameObject ornekObje = Instantiate(orneklenecekObje, new Vector3(transform.position.y, 2f, 6f), Quaternion.identity);
        ornekObje.GetComponent<BoxCollider>().enabled = false;
        // Sahneye ornekledigim(kod taraf�ndan sonradan eklemi� oldu�um) objelerin  componentlerine ula��p �zelliklerini DE���T�REB�L�R�M BU �EK�LDE !!!!!!!!!!!!


        // YedekObjeme bir SCR�PT ekle ornekObjem isimli bir SCPR�T EKLED�K.
   */
     // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        zaman=0;

    }


    void Update()
    {
        // 2 saniye aral�klarla orneklenecekObjemi yani YedekObjemi sahneye EKLEEYECEK.[YAN� 2 SAN�YE ARALIKLA SAHNEYE S�REKL� OBJE EKLENM�� OLACAK !!! ]
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
