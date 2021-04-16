using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizikYakalama : MonoBehaviour
{

    /*
     
     Her objede �arp��malar�(etkile�imleri) yakalamak i�in  Collider ZORUNLUDUR.
     Ama her objede RigidBody olmas� ZORUNLU DE��LD�R ! 

     Fiziksel bir i�lem ger�ekle�ecekse ben bunu 2  farkl� tarzla yakalayabilirim.Bunlar : 

     1- En az 1 Rigidbody ile Fiziksel yakalamalar(OnCollision Methodlar� kullan�l�r.)
     2- Collider'lardaki Tetiklemeler sayesinde Fiziksel yakalamalar.( OnTriigger Methodlar� kullan�l�r ) [ Rigidbody olmas�na GEREK YOKTUR ! ! ! ]

    */



    #region 1 - Rigidbody SAYES�NDE F�Z�KSEL YAKALAMALAR

    /* �arp��ma(etkile�im) ger�ekle�ecek 2 objeden  SADECE B�R�NDE R�G�DBODY OLMASI YETERL�D�R.

     collision parametresi Etkile�ime giren(�arp��an) b�t�n objeleri YAKALAYAN B�R PARAMETRED�R !



    
    private void OnCollisionEnter(Collision collision)  // Yani bu Scriptin ba�l� oldu�u obje ba�ka bir obje ile etkile�ime girdiginde  yap�lmas�n� istedi�imiz i�lemleri buraya yazar�z.
    {
        // Debug.Log("Etkile�im(�arp��ma) var");

        if (collision.gameObject.name == "2") // Benim FizikYakalama Scriptine sahip  bu objeyle etkile�ime giren (�arp��an)  objenin  ismi e�er 2 ise bana �u i�lemleri yap demektir ! ! !
        {
            Debug.Log("Etkile�im var");
        }
    }

    private void OnCollisionStay(Collision collision) // �arp��ma(etkile�im) ger�ekle�ti�i s�rece olmas�n� istedi�in i�lemleri buraya yazar�z.
    {
        //Debug.Log("Etkile�im s�r�yor."); 

        if (collision.gameObject.name=="2")
        {
            Debug.Log("Etkile�im s�r�yor.");
        }
    }
    private void OnCollisionExit(Collision collision) // �arp��ma(etkile�im) bitti�inde olmas�n� istedi�in i�lemleri buraya yazar�z.
    {
        // Debug.Log("Etkile�im bitti.");

        if (collision.gameObject.name=="2")
        {
            Debug.Log("Etkile�im bitti.");
        }
    }

    */
    #endregion


    #region 2 - Collider'lardaki Tetiklemeler sayesinde F�Z�KSEL YAKALAMALAR

    /*
     
      OnCollision Metotlar�n�n AYNI �ZELL�KLER�N� ta��yan Trigger Methodlar�n� kullan�r�z.
      Bu methodla Fiziksel Yakalama i�lemini yapacaksak ETK�LE��ME G�RECEK OLAN 2 OBJEDEN HERHANG� B�R�N�N �S TR�GGER �ZELL�G� AKT�F OLMASI ZORUNLUDUR ! ! !

      �NEML� NOT :  BU Y�NTEMDE R�G�DBODY OLMASINA GEREK YOK DED�K AMA E�ER OBJELERDE E�ER YER�EK�M�, K�TLE ,VS.. G�B� �ZELL�KLER� KULLANACAKSAK R�G�DBODY TAB�K� EKLENMEL�D�R. 

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkile�im var.");

            // Destroy(gameObject); // BU scriptimin ba�l� oldu�u objeyi yok et.
            // Destroy(other.gameObject); // Bu  sefer scriptimin ba�l� oldu�u objeye �arpan obje yok olur.
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkile�im s�r�yor.");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkile�im bitti.");
        }
    }


    */
    #endregion

}
