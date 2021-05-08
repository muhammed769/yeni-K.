using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{

     ParticleSystem particleSystem;



    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();

    }

    private void OnParticleCollision(GameObject other)
    {
        if ( !other.CompareTag("Partag"))
        {
            // Debug.Log(other.gameObject.name);
            Destroy(other.gameObject);
        }       
    }

    private void OnParticleTrigger()
    {
        Debug.Log("�arp��ma ger�ekle�ti.");
    }

    private void OnParticleSystemStopped() // StopAction => CallBack
    {
        Debug.Log("Par�ac�klar yani efektler hareket etmiyor art�k bilgin olsun");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            particleSystem.Stop(); 
        }
    }
}
