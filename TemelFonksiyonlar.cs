using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemelFonksiyonlar : MonoBehaviour

{
    // �NEML�  NOT : E�er bu a�a��da yazaca��m�z Fonksiyonlar� hepsini kullanmam�z gerekiyorsa  H�ERARCHY  bu �ekilde olmal�d�r ! ! ! ! ! ! ! ! ! ! !

    //-------------------------------------------------------------------------------------------------------------------------------------------------

    // Awake, OnEnable ve Start Fonksiyonlar� OYUN BA�LADI�INDA SADECE B�R KERE �ALI�IR.
    private void Awake()
    {
        Debug.Log("Awake �al��t�"); // unity'de ilk olarak Awake metodu �al���r.
    }

    private void OnEnable() // Bu metot �u i�e yarar : Bu dosyaya ait olan OBJE AKT�F oldu�unda �al���r.
    {
        Debug.Log("OnEnable �al��t�");
    }


    void Start()
    {
        Debug.Log("Start �al��t�");
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------

    // G�ncelleme  Fonksiyonlar�n�n S�ras� : 

    private void FixedUpdate()
    {
        Debug.Log("Ben FixedUpdate ile s�rekli geliyorum ");
        // TAHM�N� OLARAK 1 SAN�YEDE B�R �ALI�IR AMA B�Z BUNU UNITY ARA Y�Z�NDEN KEND�M�Z AYARLAYAB�L�R�Z ! ! ! 
        // ��YLE AYARLIYORUZ : PROJECTSETT�NGS = T�ME = F�XED T�MESTEP KISMINDA BU 0.02 SAN�YEY� AYARLAYAB�L�RS�N ! ! !
    }

    void Update()
    {
        Debug.Log("Ben Update ile s�rekli geliyorum ");
        // Tahmini olarak 1 SAN�YEDE B�R �ALI�IR AMA B�Z BUNU UNITY ARA Y�Z�NDEN KEND�M�Z AYARLAYAB�L�R�Z  ! ! ! 
        // ��YLE AYARLIYORUZ : PROJECTSETT�NGS = T�ME = T�ME SCALE KISMINDA BU 1 SAN�YEY� AYARLAYAB�L�RS�N ! ! !
    }

    private void LateUpdate()
    {
        Debug.Log("Ben LateUpdate ile s�rekli geliyorum ");
        // Sahnede olan objelerde b�t�n Update metotlar� �al��t�ktan sonra  LateUpdate metotu �al���r.
    }
    private void OnDisable() // Bu metot �u i�e yarar : Bu dosyaya ait olan OBJE PAS�F oldu�unda �al���r.
    {
        Debug.Log("Ben OnDisable ile geldim");
    }
}
