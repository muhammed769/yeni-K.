using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionIslemleri : MonoBehaviour //  Bu SCR�PT BEnimObjem isimli Objeye aittir.
{
    public Transform Hedef;
    void Start()
    {

        #region Euler() Metodu
        /*   
                   transform.rotation= Quaternion.Euler(90,0,0); // x ekseni etraf�nda x derece, Y ekseni etraf�nda y derece z ekseni etraf�nda z derece d�nd�r�r. [ Euler() MEtodu d�nd�rme i�lemini SADECE  1 KERE UYGULAR YAN� Update() metodu i�erisinde
                                                                 // kendini S�REKL� G�NCELLEYEMEZ !!!!!!
        */

        #endregion

    /*
            Vector3 bizimpozisyon = new Vector3(140, 50, 65);
            Quaternion yenipozisyon = Quaternion.Euler(bizimpozisyon);
            transform.rotation = yenipozisyon;

    */
        #region �dentity Property'si

         // �dentity() MEtodunu yazm�� oldu�umuz anda o objenin Rotation'nunu 0'lam�� oluyoruz.[Yani D�N�� ��LEM� VARSA ONU YOK EDER D�ND�RMEZ H��B�R �EK�LDE.]

        transform.rotation=Quaternion.identity;

        #endregion

    }

    void Update()
    {

        #region FromtoRotation() Metodu
    /*
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward); // Objenin kendi ekseni etraf�nda d�nmesini istiyorsak bu metodu kullan�r�z  [�st y�nden ileri y�ne do�ru d�n�� yapar�z.]
    */
        #endregion


        #region LookRotation() Metodu
    /*
                Vector3 fark = Hedef.position - transform.position;

                transform.rotation = Quaternion.LookRotation(fark, Vector3.up); // BenimObjem Hedef objesinin durumuna g�re kendi �st taraf�n� etraf�nda d�nerek takibini yapar.
                                                                                // LookRotation 'nun LookAt metodundan fark� Quaternion DAHA DO�RU SONU�LAR VERD��� ���N  BU Y�NTEM DAHA SIKLIKLA TERC�H ED�L�R.
    */
        #endregion


        #region Angle() Metodu
        /*
                float angle = Quaternion.Angle(transform.rotation,Hedef.rotation);   // Angle() Metodu : 2 vekt�r aras�ndaki a��y� Derece olarak bize verir.
                print(angle);
        */

        #endregion

        #region Inverse() Metodu

        //transform.rotation =  Quaternion.Inverse(Hedef.rotation); // Hedef objesinin d�n�� y�n�n�n TAM TERS�N� al�r BenimObjeme uygular.
        #endregion
    }

}
