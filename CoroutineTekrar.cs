using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTekrar : MonoBehaviour
{
    private IEnumerator Coroutine;
   // private IEnumerator Coroutine2;

    void Start()
    {
        Coroutine = Tiyatro(3);
       // Coroutine2 = Tiyatro2();

        StartCoroutine(Coroutine);
        //StartCoroutine(Coroutine2);
    }


    IEnumerator Tiyatro(float Saniye)
    {
        while (true)
        {
            Debug.Log("Birinci tiyatro oyuncumuz Nejat");
            yield return new WaitForSeconds(Saniye);
            yield return StartCoroutine(Tiyatro2(3));
        }
    }

    IEnumerator Tiyatro2(float saniyem)
    {
        while (true)
        {
            Debug.Log("Üçüncü tiyatro oyuncusu Sinem");
            yield return new WaitForSeconds(saniyem);
         
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StopAllCoroutines();         
        }
    }

}
