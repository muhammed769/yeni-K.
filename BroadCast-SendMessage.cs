using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesaj1 : MonoBehaviour
{
    
    void Start()
    {

        #region BroadcastMessage - SendMessage ( �nemli bir Konu)

        // SendMessage : SADECE ba�l� oldu�u objeye bir mesaj g�nderir
         // gameObject.SendMessage("ekranaYaz",18); 

        // gameObject.SendMessage("ekranaYazsfesd", 18, SendMessageOptions.DontRequireReceiver); // DontRequireReceiver al�c� olmas� zorunlu de�il yani Metot ismi yanl�� olsa sistemi �al��t�rd���nda hata almazs�n ama Merhaba 18 yaz�s�n�da g�remezsin !

     //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // BroadcastMessage metodunun SendMEssage metodundan fark� :  BroadCastMessage alt�nda bulunan child objelere hepsine mesaj� YAYAR.[mesaj2 scriptinde ekranaYaz2 metodunu �ag�bilirsin ne daha bir�ok mesaj2 scriptine
        // sahip child objelere mesaj�n� yay�nlayabilirsin ! 

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
