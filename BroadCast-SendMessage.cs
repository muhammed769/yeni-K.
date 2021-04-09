using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesaj1 : MonoBehaviour
{
    
    void Start()
    {

        #region BroadcastMessage - SendMessage ( Önemli bir Konu)

        // SendMessage : SADECE baðlý olduðu objeye bir mesaj gönderir
         // gameObject.SendMessage("ekranaYaz",18); 

        // gameObject.SendMessage("ekranaYazsfesd", 18, SendMessageOptions.DontRequireReceiver); // DontRequireReceiver alýcý olmasý zorunlu deðil yani Metot ismi yanlýþ olsa sistemi çalýþtýrdýðýnda hata almazsýn ama Merhaba 18 yazýsýnýda göremezsin !

     //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // BroadcastMessage metodunun SendMEssage metodundan farký :  BroadCastMessage altýnda bulunan child objelere hepsine mesajý YAYAR.[mesaj2 scriptinde ekranaYaz2 metodunu çagýbilirsin ne daha birçok mesaj2 scriptine
        // sahip child objelere mesajýný yayýnlayabilirsin ! 

        gameObject.BroadcastMessage("ekranaYaz2"); 


        #endregion

    }

   /* void ekranaYaz(int yas)
    {
        Debug.Log("Merhaba"+yas);
    }*/

    void ekranaYaz2()
    {
        Debug.Log(" ben ana objeden geliyorum" );
    }
}
