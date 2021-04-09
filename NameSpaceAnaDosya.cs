using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyControl;
using EnemyControl2;


public class NameSpaceAnaDosya : MonoBehaviour
{
    EnemyFire EnemyFire = new EnemyFire();
    EnemyFire2 EnemyFire2 = new EnemyFire2();
   
     
    void Start()
    {
        EnemyFire.WarOf("Mika");
        EnemyFire2.WarOf2("Desen");
    }

   
}
