using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTheCharacter : MonoBehaviour
{
    Animator animatorum;
    void Start()
    {
        animatorum = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animatorum.SetBool("yurusun_mu", true);
            //animatorum.Play("NormalKos");

        }

        if (Input.GetKeyUp(KeyCode.A)) //  GetKeyUp = Tu�a basmay� BIRAKTI�IMIZDA.Yani A tu�una basmay� b�rakt���mda ne yapmas�n� istiyosan onu yap.
        {
            animatorum.SetBool("yurusun_mu", false); // A tu�una basmay� b�rakt���m�zda Tekrar bekleme durumuna ge�sin.
        }


        if (Input.GetKeyDown(KeyCode.B))
        {
            animatorum.SetBool("normalkossun_mu", true);
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            animatorum.SetBool("normalkossun_mu", false);
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            animatorum.SetBool("hizlikossun_mu", true);
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            animatorum.SetBool("hizlikossun_mu", false);
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            animatorum.SetTrigger("ziplasin_mi");
        }

       
    }
}
