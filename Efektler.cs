using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efektler : MonoBehaviour
{

    #region Trail Renderer 
    /*
    public int hiz;
    TrailRenderer TrailEfektim;



    void Start()
    {
        TrailEfektim = GetComponentInChildren<TrailRenderer>();
        hiz = 3;
    }
    void Update()
    { 
        
        if (hiz <= 5)
        {
            TrailEfektim.alignment = LineAlignment.TransformZ;
            TrailEfektim.time =.7f;

            TrailEfektim.startColor = Color.blue;
            TrailEfektim.endColor = Color.red;
            transform.Translate(Vector3.left * hiz * Time.deltaTime);
        }
        else
        {
            TrailEfektim.shadowBias = 2;
            TrailEfektim.time = 0.3f;

            //TrailEfektim.startColor = Color.green;
            //TrailEfektim.endColor = Color.white;

            TrailEfektim.startColor = new Color(.93f, 1f, .47f);
            TrailEfektim.endColor = new Color(.46f, 1f, .65f);

            transform.Translate(Vector3.left * 4 * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up * 15f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down * 15f * Time.deltaTime);
        }
        
    }
    */
    #endregion

    #region

    /* Sahnede 2 tane obje arasýnda  efekt oluþmasýný istiyorum ve 2 objeden biri
       hareket ettiðinde aralarýndaki efekt(bað) bozulmucak.                    
    */   

    LineRenderer lineEffect;
    public Transform hedef;

    private void Start()
    {
        lineEffect = GetComponent<LineRenderer>();
       
    }
    private void Update()
    {
       
         
        lineEffect.SetPosition(0, transform.position);
                  // Efekt senin  ÝLK pozisyonun kendi pozisyonun.

        lineEffect.SetPosition(1, hedef.position);
        // Efekt senin SON  pozisyonun hedefin pozisyonudur.

        

        /*Transform sen = hedef;
        if (sen.position.x == 5f)
        {
            lineEffect.loop = true;
        }*/
      
        
                 
    }

    #endregion


}
