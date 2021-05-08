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
        Debug.Log("Çarpýþma gerçekleþti.");
    }

    private void OnParticleSystemStopped() // StopAction => CallBack
    {
        Debug.Log("Parçacýklar yani efektler hareket etmiyor artýk bilgin olsun");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            particleSystem.Stop(); 
        }
    }
}
