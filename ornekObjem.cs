using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ornekObjem : MonoBehaviour // BU SCR�PT YedekObjem isimli Objeye A�TT�R !!!!!!!!!!!!!!!!
{
    private void Start()
    {
        // YedekObjemin Instantiate CLASS'INDA(SPR�T�NDE) 2 saniye aral�klarla s�rekli do�mas�n� sa�lam��t�k.��MD�DE BURDA BELL� B�R SAN�YE SONRA  OLU�AN BU YedekObjelerin YOK OLMASINI SA�LAYALIM  : 

        Destroy(gameObject, 3f); // YedekObje 3 saniye sonra YOK OLSUN DEM�� OLDUK !
    }


    void Update()
    {
        transform.Translate(Vector3.forward); // YedekObjem SAhnede do�dugu anda ileriye gitsin demi� oldum.
    }
}
