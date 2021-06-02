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
            // ClipManager.SetTrigger("my_trigger"); // SetTrigger  metodu  Trigger t�r�ndeki parametreyi ismiyle beraber yaklayarak di�er State'e GE�MEM�Z� SA�LAR ! ! !

                                                  // Bu koddan sonra Unity taraf�nda belirlemi� oldu�un Transition'da Conditions 'da my_trigger'� se�meyi unutma ve orda
                                                  // gerekli ayarlamalar�da yapmay� UNUTMA ! ! ! 

                                                  // Yani A tu�una bast���mda belirlemi� oldu�um Transiton sayesinde di�er State'e ge�mi� olacak.

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
             /* ClipManager.SetInteger("my_int", 2);  Burda 2 yazd�n ama Unity  taraf�nda Greater se�ili ve 3 yazarsan di�er State'e ge�emez.
                                                       ��nk� sen Unity taraf�nda 3 den b�y�kse di�er State'e ge� demi�sin ! ! ! */
          
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
        //  Debug.Log("Merhaba �ocuk");

        Debug.Log("Mika " + deger);
    }


    private void OnAnimatorMove() // Animasyon Cliplerini DEVRE DI�I BIRAKAB�L�R ! ! !
    {
        Vector3 Position = transform.position;
        Position.x += ClipManager.GetFloat("my_trigger")* Time.deltaTime; // MEVCUT DE�ER� ALMAK �ST�YORSAN Set yerine Get'i kullan�r�z ! ! ! 
        transform.position = Position;
    }
}
