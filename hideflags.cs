using System.Collections;
using System.Collections.Generic;
using UnityEngine;




#region [AddComponentMenu()] Kullan�m�
/*
 
//[AddComponentMenu("Event/BenOlusturdum")] // Unity k�sm�nda AddCOmponent'e t�klad���m�zda ordaki Event'in i�ine BenOlusturdum isimli B�R SCR�PT EKLEM�� OLDUM.
// Yani Art�k Unity ' FARKLI B�R OBJE EKLED���MDE AddComponent ' t�klay�p Event'in i�inden Benolusturdum isimli bu SCR�PT� s�r�kle b�rak olmadan YAPAB�L�R�M.

[AddComponentMenu("Mika/BenimScriptim")] // G�rd�g�n gibi Unity k�sm�nda AddComponent'e t�klad���m�zda Mika isimli bir Menu olu�turup bunun i�ine BenimScriptim isimli bu Scriptimi atayabilirim.

*/
#endregion


#region [RequireComponent()] Kullan�m�
/*
 
[RequireComponent(typeof(Rigidbody))] // Herhangi bir obje olu�tur.Bu objeye bu Scripti S�r�kledi�in AN BU SCR�PTLE BERABER R�G�DBODY componentide OTOMAT�K OLARAK GELM�� OLACAKTIR.
*/

#endregion

public class hideflags : MonoBehaviour // Bu SCR�PT BenimObjem  ve k�pBenim isimli objelere A�TT�R.
{
    #region     [Range()] Kullan�m�
    /*
     
    [Range(2, 7)] // Range metodunda minimum ve maksimum de�erlerini belirttikten sonra alt�na yazd���n kod Unity k�sm�nda bu minimum ve maksimum de�erleri aras�nda  kendimiz manuel olarak ayarlayabiliriz.
    public int degerim;

    */
    #endregion

    #region    [HideInInspector] Kullan�m�
    /*
     
    [HideInInspector] // Bunu Yazd���n zaman bu kodun alt�ndaki yazan kod Unity'de Inspector 'da G�R�NMEZ.
    public string isim; // Yani isim de�i�keni public olmas�na ra�men �stteki kod sayesinde Inspector'da G�R�NMEZ !

    */
    #endregion

    #region    [Min()] Kullan�m�
    /*
    [Min(5)]             // bir de�erin en az ka� olmas� gerekti�ini burda s�leriz
    public int degerim; // de�erim de�i�keni en az 5 olabilir.
    */

    #endregion

    #region [Multiline()] Kullan�m�
    /*
      
    [Multiline(7)]  // Alt�nda yaz�lan olan Text alan�n�n 7 sat�rl�k olmas�n� sa�lad�k.Bunu uzun metinler yazmam�z gereken durumlarda kullan�r�z ! ! ! 
    public string isim;

    */
    #endregion

    #region [Tooltip()] Kullan�m�

    /*
      
    [Tooltip("Bu benim notum a��k m� kapal� ayar� buradan yap�l�r.")]  // bunun alt�na yazd���n de�i�kene Unity taraf�nda A�IKLAMASINI yapan bir string yaz� yaz�yoruz ! ! !
    public bool durum;

    */
    #endregion

    #region [Header()] Kullan�m�

    // �ok fazla de�i�ken oldu�unda bu de�i�kenleri KATEGOR�ZE etmemizi sa�lar.

    /*
      
    [Header("Buras� karakter ayarlar�")]
    public string saglik;
    public string para;
    public string renk;

    [Header("Buras� d��man ayarlar�")]
    public string dusman_saglik;
    public string dusman_para;
    public string dusman_renk;

    */
    #endregion

    #region [ContextMenu()] Kullan�m�
    /*
     
    [ContextMenu("Benim Menum")] // Bu Scriptin ba�l� oldu�u  Unity yerinde ... olan yere sa� t�klad���nda Benim Menum yaz�s� g�z�k�r ve a�a��da yazd���n metotta yazd�rmak istedigin �eyi yazd�rabilirsin ! ! !

    void BenimMenum()
    {
        print("Ben ayarlardan geliyorum.");
    }

    */

    /*
     
    [ContextMenu("Benim Men�m",false,1)] // Bu  Men�n�n en  �stte g�z�kmesini sa�lam�� oldum.
    [ContextMenu("Benim Men�m2",false,2)] // Bu  Men�n�n 2'inci s�rada g�z�kmesini sa�lam�� oldum.
    void BenimMenum()
    {
        print("Ben ayarlardan geliyorum.");
    }
    
   */ 
    
    #endregion


    void Start()
    {

        /*
         
           gameObject.hideFlags = HideFlags.DontSave;      
                                                           Oyunu �al��t�r�p sahnede BenimObjemi herhangi bir y�nde hareket ettirdikten sonra BenimObjem bir de�i�iklik olmaz  Oyunu kapatt�g�nda Benimobjemin
                                                           konumunu de�i�tirdi�in yerde kopya bir BenimObjem Olu�mu�tur.
                                                           Kopyalanan  BenimObjemin herhangi bir componentini al�p ANA BenimObjem 'de KULLANAB�L�R�M. 
       */

        //  gameObject.hideFlags = HideFlags.NotEditable;        // BenimObjemin Inspectorunda herhangi bir ayar�   de�i�tirmemi ENGELLER ! ! ! 

        //  gameObject.hideFlags = HideFlags.HideInInspector;    // hideflags Scriptimin ba�l� oldu�u BenimObjem oyun ba�lad���nda SAHNEDE VARDIR AMA  Inspector'u  G�R�NMEZ !!!

        //  gameObject.hideFlags = HideFlags.HideInHierarchy;    // hideflags Scriptimin ba�l� oldu�u BenimObjem oyun ba�lad���nda SAHNEDE VARDIR AMA  Hierarchy 'de G�R�NMEZ !!!

    }

}
