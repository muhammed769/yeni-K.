using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformIslemi2 : MonoBehaviour // Bu Script BenimObjem isimli objeye AÝTTÝR !!!!!!!!!!!!!!!!!!!!!!!!!
{

    #region Deðiþken Tanýmlarý 1 
    /*    public Transform hedef;
          public Transform hedef2;
    */
    #endregion


    #region Deðiþken Tanýmlarý 2
    /*
       public Transform Parent;
       public Transform Child;
    */
    #endregion

  

    void Start()
    {

        #region Baþlangýç Kýsmý

        // transform.position = new Vector3(3f, 2f, 6f);
        // transform.position = new Vector3(transform.position.x, 5f, transform.position.z);

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /*  print(hedef.transform.localPosition);
                    print(hedef.transform.localRotation); // Rotation sonuçlarýný alamayýz çünkü Rotation kýsýmlarý Quartenion sýnýfýyla kontrol edilir !!!!!!
                    print(hedef.transform.localScale);   
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /*
                    GameObject aramasonucu = GameObject.Find("GameObject").gameObject; // BenimObjem isimli objemin içerisinde  GameObject isimli objeyi arayacak.
                    aramasonucu.name="Ben deðiþtirdim.";
                    GameObject aramasonucu = GameObject.Find("GameObject/Cylinder");
                    Debug.Log(aramasonucu);
                    aramasonucu.name = "Ben deðiþtirdim2.";

                    Debug.Log(transform.childCount);       BenimObjem isimli objemin altýnda ne kadar çocuk obje varsa onun sayýsýný ekranda bana göster.
                    Debug.Log(transform.hierarchyCount);   Ana ve çocuk objelerinin toplam sayýsýný bize gösterir.
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion


        #region GetChild() Metodu
        /*    for (int i = 0; i < transform.childCount; i++) // BenimObjem isimli objemin çocuklarýnýn  sayýsý kadar döngüye gir.
                {
                    // Debug.Log(transform.GetChild(0).name);     // Birinci çocugu ekranda bana kim olduðunu  göster.
                    Debug.Log(transform.GetChild(i).name);    // Çocuk objelerinin hepsini ekrana yazdýr.

                    /*  if (i == 1)
                         {
                            transform.GetChild(i).GetComponent<BoxCollider>().isTrigger = true;    // 2'inci cocuk objesi olan Cube'ün sen git BoxCollider Component'i al ve bunun isTrigger özelliðini aktifleþtir.
                         }
                    ------------------------------------------

                    if (transform.GetChild(i).name == "Mika")
                    {
                        transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                    }
                }

        */
        #endregion


        #region SetParent() Metodu : Bir Objeyi Baþka bir  objenin çocugu yapar.

        // Child.transform.SetParent(Parent); // çocuk obje Ailesinin altýna geçtiði için bulunduðu konumu ailesinin konumuna göre OTOMATÝK OLARAK DEÐÝÞTÝRÝLÝR.

        // Eðer ben çocuk objesinin bir ailenin altýna geçtiginde bulunduðu konumu KAYBETMEMESÝNÝ ÝSTERSE ÞU KODU YAZMAM GEREKÝR : 

        // Child.transform.SetParent(Parent,false); 

        #endregion

    }


    void Update()
    {

        #region LookAt Metodu (Bir objenin bir objeyi takip etmesini saðlar.)

                               // Örneðin oyunda bir güvenlik kamerasý olabilir bu güvenlik kamerasý bizim objemizi takip edebilir.

        // hedef2.transform.LookAt(hedef);
        // hedef2.transform.LookAt(hedef,Vector3.left); // Takip eden hedef2 objesi artýk kendi soluna göre takip eder.Yani artýk bir World gibi deðil Self gibi takip eder.

        #endregion


        #region Rotate Metodu
        /* transform.Rotate(new Vector3(1f, 3f, 4f)); // objem vemiþ olduðum  koordinatlarda sürekli döner.
         transform.Rotate(new Vector3(1f, 2f, 3f) * Time.deltaTime * 10f);

          transform.Rotate(new Vector3(2f, 4f, 3f), Space.World);                                      // DÜnya ekseninde döner.[Boþlukta dönüyomuþ gibi döner ]
          transform.Rotate(new Vector3(2f, 4f, 3f), Space.Self);                                      // Kendi ekseninde döner. [Kendi durumuna göre döner, Yani kendini referans alýr.]

         hedef.transform.Rotate(1f, 3f, 2f, Space.Self);    // Hedef kýsmýna sürüklediðim objenin Rotasyonunu ayarlýyoruz.
         hedef2.transform.Rotate(2f, 3f, 1f, Space.World);*/
        #endregion

        // transform.Translate(transform.forward * Time.deltaTime * 1f); // Objeyi sürekli ileri götürür.
    }
}
