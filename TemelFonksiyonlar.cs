using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemelFonksiyonlar : MonoBehaviour

{
    // ÖNEMLÝ  NOT : Eðer bu aþaðýda yazacaðýmýz Fonksiyonlarý hepsini kullanmamýz gerekiyorsa  HÝERARCHY  bu þekilde olmalýdýr ! ! ! ! ! ! ! ! ! ! !

    //-------------------------------------------------------------------------------------------------------------------------------------------------

    // Awake, OnEnable ve Start Fonksiyonlarý OYUN BAÞLADIÐINDA SADECE BÝR KERE ÇALIÞIR.
    private void Awake()
    {
        Debug.Log("Awake çalýþtý"); // unity'de ilk olarak Awake metodu çalýþýr.
    }

    private void OnEnable() // Bu metot þu iþe yarar : Bu dosyaya ait olan OBJE AKTÝF olduðunda çalýþýr.
    {
        Debug.Log("OnEnable çalýþtý");
    }


    void Start()
    {
        Debug.Log("Start çalýþtý");
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------

    // Güncelleme  Fonksiyonlarýnýn Sýrasý : 

    private void FixedUpdate()
    {
        Debug.Log("Ben FixedUpdate ile sürekli geliyorum ");
        // TAHMÝNÝ OLARAK 1 SANÝYEDE BÝR ÇALIÞIR AMA BÝZ BUNU UNITY ARA YÜZÜNDEN KENDÝMÝZ AYARLAYABÝLÝRÝZ ! ! ! 
        // ÞÖYLE AYARLIYORUZ : PROJECTSETTÝNGS = TÝME = FÝXED TÝMESTEP KISMINDA BU 0.02 SANÝYEYÝ AYARLAYABÝLÝRSÝN ! ! !
    }

    void Update()
    {
        Debug.Log("Ben Update ile sürekli geliyorum ");
        // Tahmini olarak 1 SANÝYEDE BÝR ÇALIÞIR AMA BÝZ BUNU UNITY ARA YÜZÜNDEN KENDÝMÝZ AYARLAYABÝLÝRÝZ  ! ! ! 
        // ÞÖYLE AYARLIYORUZ : PROJECTSETTÝNGS = TÝME = TÝME SCALE KISMINDA BU 1 SANÝYEYÝ AYARLAYABÝLÝRSÝN ! ! !
    }

    private void LateUpdate()
    {
        Debug.Log("Ben LateUpdate ile sürekli geliyorum ");
        // Sahnede olan objelerde bütün Update metotlarý çalýþtýktan sonra  LateUpdate metotu çalýþýr.
    }
    private void OnDisable() // Bu metot þu iþe yarar : Bu dosyaya ait olan OBJE PASÝF olduðunda çalýþýr.
    {
        Debug.Log("Ben OnDisable ile geldim");
    }
}
