using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ornekObjem : MonoBehaviour // BU SCRÝPT YedekObjem isimli Objeye AÝTTÝR !!!!!!!!!!!!!!!!
{
    private void Start()
    {
        // YedekObjemin Instantiate CLASS'INDA(SPRÝTÝNDE) 2 saniye aralýklarla sürekli doðmasýný saðlamýþtýk.ÞÝMDÝDE BURDA BELLÝ BÝR SANÝYE SONRA  OLUÞAN BU YedekObjelerin YOK OLMASINI SAÐLAYALIM  : 

        Destroy(gameObject, 3f); // YedekObje 3 saniye sonra YOK OLSUN DEMÝÞ OLDUK !
    }


    void Update()
    {
        transform.Translate(Vector3.forward); // YedekObjem SAhnede doðdugu anda ileriye gitsin demiþ oldum.
    }
}
