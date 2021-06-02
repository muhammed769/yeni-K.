using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDurumları : StateMachineBehaviour
{
    //  ÖNEMLİ : İlgili State'de İşimizin bitip bitmediğini anlamak için bu SCripti oluşturur ve gerekli kodları yazarız ! ! ! 


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) // O State'e geçtiğinde şu işlemleri yap : 
    {
        Debug.Log("İçeri girdim");
        // Debug.Log(stateInfo.speed);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) // O State'de kaldığım sürece : 
    {
        Debug.Log("İçerdeyim hala ");
    }


    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) // O State'den çıktığım zaman bana şu işlemleri yap  : 
    {
    Debug.Log("İçeriden çıktım");
    }

    // OnStateMove is called right after Animator.OnAnimatorMove() // OnAnimatorMove() Metodu  objemin YÖNÜNÜ  ayarladığımız bir fonksiyondur.OnAnimatorMove() Metodundan

                                                                  //  sonra OnStateMove Metodu çalışır.OnAnimatorMove Metodunu AnimationOperation SCRİPTİNE YAZMAN GEREKİYO !

    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("DEĞİŞİM OLUYOR");
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}

