using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizikYakalama : MonoBehaviour
{

    /*
     
     Her objede çarpýþmalarý(etkileþimleri) yakalamak için  Collider ZORUNLUDUR.
     Ama her objede RigidBody olmasý ZORUNLU DEÐÝLDÝR ! 

     Fiziksel bir iþlem gerçekleþecekse ben bunu 2  farklý tarzla yakalayabilirim.Bunlar : 

     1- En az 1 Rigidbody ile Fiziksel yakalamalar(OnCollision Methodlarý kullanýlýr.)
     2- Collider'lardaki Tetiklemeler sayesinde Fiziksel yakalamalar.( OnTriigger Methodlarý kullanýlýr ) [ Rigidbody olmasýna GEREK YOKTUR ! ! ! ]

    */



    #region 1 - Rigidbody SAYESÝNDE FÝZÝKSEL YAKALAMALAR

    /* Çarpýþma(etkileþim) gerçekleþecek 2 objeden  SADECE BÝRÝNDE RÝGÝDBODY OLMASI YETERLÝDÝR.

     collision parametresi Etkileþime giren(çarpýþan) bütün objeleri YAKALAYAN BÝR PARAMETREDÝR !



    
    private void OnCollisionEnter(Collision collision)  // Yani bu Scriptin baðlý olduðu obje baþka bir obje ile etkileþime girdiginde  yapýlmasýný istediðimiz iþlemleri buraya yazarýz.
    {
        // Debug.Log("Etkileþim(çarpýþma) var");

        if (collision.gameObject.name == "2") // Benim FizikYakalama Scriptine sahip  bu objeyle etkileþime giren (çarpýþan)  objenin  ismi eðer 2 ise bana þu iþlemleri yap demektir ! ! !
        {
            Debug.Log("Etkileþim var");
        }
    }

    private void OnCollisionStay(Collision collision) // Çarpýþma(etkileþim) gerçekleþtiði sürece olmasýný istediðin iþlemleri buraya yazarýz.
    {
        //Debug.Log("Etkileþim sürüyor."); 

        if (collision.gameObject.name=="2")
        {
            Debug.Log("Etkileþim sürüyor.");
        }
    }
    private void OnCollisionExit(Collision collision) // Çarpýþma(etkileþim) bittiðinde olmasýný istediðin iþlemleri buraya yazarýz.
    {
        // Debug.Log("Etkileþim bitti.");

        if (collision.gameObject.name=="2")
        {
            Debug.Log("Etkileþim bitti.");
        }
    }

    */
    #endregion


    #region 2 - Collider'lardaki Tetiklemeler sayesinde FÝZÝKSEL YAKALAMALAR

    /*
     
      OnCollision Metotlarýnýn AYNI ÖZELLÝKLERÝNÝ taþýyan Trigger Methodlarýný kullanýrýz.
      Bu methodla Fiziksel Yakalama iþlemini yapacaksak ETKÝLEÞÝME GÝRECEK OLAN 2 OBJEDEN HERHANGÝ BÝRÝNÝN ÝS TRÝGGER ÖZELLÝGÝ AKTÝF OLMASI ZORUNLUDUR ! ! !

      ÖNEMLÝ NOT :  BU YÖNTEMDE RÝGÝDBODY OLMASINA GEREK YOK DEDÝK AMA EÐER OBJELERDE EÐER YERÇEKÝMÝ, KÜTLE ,VS.. GÝBÝ ÖZELLÝKLERÝ KULLANACAKSAK RÝGÝDBODY TABÝKÝ EKLENMELÝDÝR. 

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkileþim var.");

            // Destroy(gameObject); // BU scriptimin baðlý olduðu objeyi yok et.
            // Destroy(other.gameObject); // Bu  sefer scriptimin baðlý olduðu objeye çarpan obje yok olur.
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkileþim sürüyor.");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("Etkileþim bitti.");
        }
    }


    */
    #endregion

}
