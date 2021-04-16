using System.Collections;
using System.Collections.Generic;
using UnityEngine;




#region [AddComponentMenu()] Kullanýmý
/*
 
//[AddComponentMenu("Event/BenOlusturdum")] // Unity kýsmýnda AddCOmponent'e týkladýðýmýzda ordaki Event'in içine BenOlusturdum isimli BÝR SCRÝPT EKLEMÝÞ OLDUM.
// Yani Artýk Unity ' FARKLI BÝR OBJE EKLEDÝÐÝMDE AddComponent ' týklayýp Event'in içinden Benolusturdum isimli bu SCRÝPTÝ sürükle býrak olmadan YAPABÝLÝRÝM.

[AddComponentMenu("Mika/BenimScriptim")] // Gördügün gibi Unity kýsmýnda AddComponent'e týkladýðýmýzda Mika isimli bir Menu oluþturup bunun içine BenimScriptim isimli bu Scriptimi atayabilirim.

*/
#endregion


#region [RequireComponent()] Kullanýmý
/*
 
[RequireComponent(typeof(Rigidbody))] // Herhangi bir obje oluþtur.Bu objeye bu Scripti Sürüklediðin AN BU SCRÝPTLE BERABER RÝGÝDBODY componentide OTOMATÝK OLARAK GELMÝÞ OLACAKTIR.
*/

#endregion

public class hideflags : MonoBehaviour // Bu SCRÝPT BenimObjem  ve küpBenim isimli objelere AÝTTÝR.
{
    #region     [Range()] Kullanýmý
    /*
     
    [Range(2, 7)] // Range metodunda minimum ve maksimum deðerlerini belirttikten sonra altýna yazdýðýn kod Unity kýsmýnda bu minimum ve maksimum deðerleri arasýnda  kendimiz manuel olarak ayarlayabiliriz.
    public int degerim;

    */
    #endregion

    #region    [HideInInspector] Kullanýmý
    /*
     
    [HideInInspector] // Bunu Yazdýðýn zaman bu kodun altýndaki yazan kod Unity'de Inspector 'da GÖRÜNMEZ.
    public string isim; // Yani isim deðiþkeni public olmasýna raðmen üstteki kod sayesinde Inspector'da GÖRÜNMEZ !

    */
    #endregion

    #region    [Min()] Kullanýmý
    /*
    [Min(5)]             // bir deðerin en az kaç olmasý gerektiðini burda söleriz
    public int degerim; // deðerim deðiþkeni en az 5 olabilir.
    */

    #endregion

    #region [Multiline()] Kullanýmý
    /*
      
    [Multiline(7)]  // Altýnda yazýlan olan Text alanýnýn 7 satýrlýk olmasýný saðladýk.Bunu uzun metinler yazmamýz gereken durumlarda kullanýrýz ! ! ! 
    public string isim;

    */
    #endregion

    #region [Tooltip()] Kullanýmý

    /*
      
    [Tooltip("Bu benim notum açýk mý kapalý ayarý buradan yapýlýr.")]  // bunun altýna yazdýðýn deðiþkene Unity tarafýnda AÇIKLAMASINI yapan bir string yazý yazýyoruz ! ! !
    public bool durum;

    */
    #endregion

    #region [Header()] Kullanýmý

    // Çok fazla deðiþken olduðunda bu deðiþkenleri KATEGORÝZE etmemizi saðlar.

    /*
      
    [Header("Burasý karakter ayarlarý")]
    public string saglik;
    public string para;
    public string renk;

    [Header("Burasý düþman ayarlarý")]
    public string dusman_saglik;
    public string dusman_para;
    public string dusman_renk;

    */
    #endregion

    #region [ContextMenu()] Kullanýmý
    /*
     
    [ContextMenu("Benim Menum")] // Bu Scriptin baðlý olduðu  Unity yerinde ... olan yere sað týkladýðýnda Benim Menum yazýsý gözükür ve aþaðýda yazdýðýn metotta yazdýrmak istedigin þeyi yazdýrabilirsin ! ! !

    void BenimMenum()
    {
        print("Ben ayarlardan geliyorum.");
    }

    */

    /*
     
    [ContextMenu("Benim Menüm",false,1)] // Bu  Menünün en  üstte gözükmesini saðlamýþ oldum.
    [ContextMenu("Benim Menüm2",false,2)] // Bu  Menünün 2'inci sýrada gözükmesini saðlamýþ oldum.
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
                                                           Oyunu çalýþtýrýp sahnede BenimObjemi herhangi bir yönde hareket ettirdikten sonra BenimObjem bir deðiþiklik olmaz  Oyunu kapattýgýnda Benimobjemin
                                                           konumunu deðiþtirdiðin yerde kopya bir BenimObjem Oluþmuþtur.
                                                           Kopyalanan  BenimObjemin herhangi bir componentini alýp ANA BenimObjem 'de KULLANABÝLÝRÝM. 
       */

        //  gameObject.hideFlags = HideFlags.NotEditable;        // BenimObjemin Inspectorunda herhangi bir ayarý   deðiþtirmemi ENGELLER ! ! ! 

        //  gameObject.hideFlags = HideFlags.HideInInspector;    // hideflags Scriptimin baðlý olduðu BenimObjem oyun baþladýðýnda SAHNEDE VARDIR AMA  Inspector'u  GÖRÜNMEZ !!!

        //  gameObject.hideFlags = HideFlags.HideInHierarchy;    // hideflags Scriptimin baðlý olduðu BenimObjem oyun baþladýðýnda SAHNEDE VARDIR AMA  Hierarchy 'de GÖRÜNMEZ !!!

    }

}
