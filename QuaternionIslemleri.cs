using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionIslemleri : MonoBehaviour //  Bu SCRÝPT BEnimObjem isimli Objeye aittir.
{
    public Transform Hedef;
    void Start()
    {

        #region Euler() Metodu
        /*   
                   transform.rotation= Quaternion.Euler(90,0,0); // x ekseni etrafýnda x derece, Y ekseni etrafýnda y derece z ekseni etrafýnda z derece döndürür. [ Euler() MEtodu döndürme iþlemini SADECE  1 KERE UYGULAR YANÝ Update() metodu içerisinde
                                                                 // kendini SÜREKLÝ GÜNCELLEYEMEZ !!!!!!
        */

        #endregion

    /*
            Vector3 bizimpozisyon = new Vector3(140, 50, 65);
            Quaternion yenipozisyon = Quaternion.Euler(bizimpozisyon);
            transform.rotation = yenipozisyon;

    */
        #region Ýdentity Property'si

         // Ýdentity() MEtodunu yazmýþ olduðumuz anda o objenin Rotation'nunu 0'lamýþ oluyoruz.[Yani DÖNÜÞ ÝÞLEMÝ VARSA ONU YOK EDER DÖNDÜRMEZ HÝÇBÝR ÞEKÝLDE.]

        transform.rotation=Quaternion.identity;

        #endregion

    }

    void Update()
    {

        #region FromtoRotation() Metodu
    /*
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward); // Objenin kendi ekseni etrafýnda dönmesini istiyorsak bu metodu kullanýrýz  [üst yönden ileri yöne doðru dönüþ yaparýz.]
    */
        #endregion


        #region LookRotation() Metodu
    /*
                Vector3 fark = Hedef.position - transform.position;

                transform.rotation = Quaternion.LookRotation(fark, Vector3.up); // BenimObjem Hedef objesinin durumuna göre kendi üst tarafýný etrafýnda dönerek takibini yapar.
                                                                                // LookRotation 'nun LookAt metodundan farký Quaternion DAHA DOÐRU SONUÇLAR VERDÝÐÝ ÝÇÝN  BU YÖNTEM DAHA SIKLIKLA TERCÝH EDÝLÝR.
    */
        #endregion


        #region Angle() Metodu
        /*
                float angle = Quaternion.Angle(transform.rotation,Hedef.rotation);   // Angle() Metodu : 2 vektör arasýndaki açýyý Derece olarak bize verir.
                print(angle);
        */

        #endregion

        #region Inverse() Metodu

        //transform.rotation =  Quaternion.Inverse(Hedef.rotation); // Hedef objesinin dönüþ yönünün TAM TERSÝNÝ alýr BenimObjeme uygular.
        #endregion
    }

}
