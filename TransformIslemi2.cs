using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformIslemi2 : MonoBehaviour // Bu Script BenimObjem isimli objeye A�TT�R !!!!!!!!!!!!!!!!!!!!!!!!!
{

    #region De�i�ken Tan�mlar� 1 
    /*    public Transform hedef;
          public Transform hedef2;
    */
    #endregion


    #region De�i�ken Tan�mlar� 2
    /*
       public Transform Parent;
       public Transform Child;
    */
    #endregion

  

    void Start()
    {

        #region Ba�lang�� K�sm�

        // transform.position = new Vector3(3f, 2f, 6f);
        // transform.position = new Vector3(transform.position.x, 5f, transform.position.z);

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /*  print(hedef.transform.localPosition);
                    print(hedef.transform.localRotation); // Rotation sonu�lar�n� alamay�z ��nk� Rotation k�s�mlar� Quartenion s�n�f�yla kontrol edilir !!!!!!
                    print(hedef.transform.localScale);   
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /*
                    GameObject aramasonucu = GameObject.Find("GameObject").gameObject; // BenimObjem isimli objemin i�erisinde  GameObject isimli objeyi arayacak.
                    aramasonucu.name="Ben de�i�tirdim.";
                    GameObject aramasonucu = GameObject.Find("GameObject/Cylinder");
                    Debug.Log(aramasonucu);
                    aramasonucu.name = "Ben de�i�tirdim2.";

                    Debug.Log(transform.childCount);       BenimObjem isimli objemin alt�nda ne kadar �ocuk obje varsa onun say�s�n� ekranda bana g�ster.
                    Debug.Log(transform.hierarchyCount);   Ana ve �ocuk objelerinin toplam say�s�n� bize g�sterir.
        */

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion


        #region GetChild() Metodu
        /*    for (int i = 0; i < transform.childCount; i++) // BenimObjem isimli objemin �ocuklar�n�n  say�s� kadar d�ng�ye gir.
                {
                    // Debug.Log(transform.GetChild(0).name);     // Birinci �ocugu ekranda bana kim oldu�unu  g�ster.
                    Debug.Log(transform.GetChild(i).name);    // �ocuk objelerinin hepsini ekrana yazd�r.

                    /*  if (i == 1)
                         {
                            transform.GetChild(i).GetComponent<BoxCollider>().isTrigger = true;    // 2'inci cocuk objesi olan Cube'�n sen git BoxCollider Component'i al ve bunun isTrigger �zelli�ini aktifle�tir.
                         }
                    ------------------------------------------

                    if (transform.GetChild(i).name == "Mika")
                    {
                        transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
                    }
                }

        */
        #endregion


        #region SetParent() Metodu : Bir Objeyi Ba�ka bir  objenin �ocugu yapar.

        // Child.transform.SetParent(Parent); // �ocuk obje Ailesinin alt�na ge�ti�i i�in bulundu�u konumu ailesinin konumuna g�re OTOMAT�K OLARAK DE���T�R�L�R.

        // E�er ben �ocuk objesinin bir ailenin alt�na ge�tiginde bulundu�u konumu KAYBETMEMES�N� �STERSE �U KODU YAZMAM GEREK�R : 

        // Child.transform.SetParent(Parent,false); 

        #endregion

    }


    void Update()
    {

        #region LookAt Metodu (Bir objenin bir objeyi takip etmesini sa�lar.)

                               // �rne�in oyunda bir g�venlik kameras� olabilir bu g�venlik kameras� bizim objemizi takip edebilir.

        // hedef2.transform.LookAt(hedef);
        // hedef2.transform.LookAt(hedef,Vector3.left); // Takip eden hedef2 objesi art�k kendi soluna g�re takip eder.Yani art�k bir World gibi de�il Self gibi takip eder.

        #endregion


        #region Rotate Metodu
        /* transform.Rotate(new Vector3(1f, 3f, 4f)); // objem vemi� oldu�um  koordinatlarda s�rekli d�ner.
         transform.Rotate(new Vector3(1f, 2f, 3f) * Time.deltaTime * 10f);

          transform.Rotate(new Vector3(2f, 4f, 3f), Space.World);                                      // D�nya ekseninde d�ner.[Bo�lukta d�n�yomu� gibi d�ner ]
          transform.Rotate(new Vector3(2f, 4f, 3f), Space.Self);                                      // Kendi ekseninde d�ner. [Kendi durumuna g�re d�ner, Yani kendini referans al�r.]

         hedef.transform.Rotate(1f, 3f, 2f, Space.Self);    // Hedef k�sm�na s�r�kledi�im objenin Rotasyonunu ayarl�yoruz.
         hedef2.transform.Rotate(2f, 3f, 1f, Space.World);*/
        #endregion

        // transform.Translate(transform.forward * Time.deltaTime * 1f); // Objeyi s�rekli ileri g�t�r�r.
    }
}
