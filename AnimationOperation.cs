using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOperation : MonoBehaviour
{
    Animator ClipManager;
    void Start()
    {
        ClipManager = GetComponent<Animator>();
    }

  
    void Update()
    {

        #region Video 1- 6 
        if (Input.GetKeyDown(KeyCode.A))
        {
            // ClipManager.SetTrigger("my_trigger"); // SetTrigger  metodu  Trigger türündeki parametreyi ismiyle beraber yaklayarak diðer State'e GEÇMEMÝZÝ SAÐLAR ! ! !

                                                  // Bu koddan sonra Unity tarafýnda belirlemiþ olduðun Transition'da Conditions 'da my_trigger'ý seçmeyi unutma ve orda
                                                  // gerekli ayarlamalarýda yapmayý UNUTMA ! ! ! 

                                                  // Yani A tuþuna bastýðýmda belirlemiþ olduðum Transiton sayesinde diðer State'e geçmiþ olacak.

            ClipManager.SetBool("my_bool", false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ClipManager.SetBool("my_bool", true); 
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ClipManager.ResetTrigger("ikincitetik");
            ClipManager.SetTrigger("my_trigger");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ClipManager.ResetTrigger("my_trigger");
            ClipManager.SetTrigger("ikincitetik");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
             /* ClipManager.SetInteger("my_int", 2);  Burda 2 yazdýn ama Unity  tarafýnda Greater seçili ve 3 yazarsan diðer State'e geçemez.
                                                       Çünkü sen Unity tarafýnda 3 den büyükse diðer State'e geç demiþsin ! ! ! */
          
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // ClipManager.SetTrigger("ucuncutetik"); 

            ClipManager.SetFloat("my_float", 4);
        }


        if (Input.GetKeyDown(KeyCode.O))
        {
            ClipManager.SetTrigger("dorduncutetik");
        }

        #endregion

    }

    public void Selamla(int deger)
    {
        //  Debug.Log("Merhaba Çocuk");

        Debug.Log("Mika " + deger);
    }


    private void OnAnimatorMove() // Animasyon Cliplerini DEVRE DIÞI BIRAKABÝLÝR ! ! !
    {
        Vector3 Position = transform.position;
        Position.x += ClipManager.GetFloat("my_trigger")* Time.deltaTime; // MEVCUT DEÐERÝ ALMAK ÝSTÝYORSAN Set yerine Get'i kullanýrýz ! ! ! 
        transform.position = Position;
    }
}
