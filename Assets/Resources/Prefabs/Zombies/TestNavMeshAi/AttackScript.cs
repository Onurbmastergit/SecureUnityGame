using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class AttackScript : MonoBehaviour
{
    public bool build =  false;
    public bool player = false;
    public bool zombie = false;

    public int dano;

    public DetectionCollider collider1;
   void OnTriggerEnter(Collider collider)
   {
        if(build)
        {
            if(collider.CompareTag("Build"))
            {
                collider.GetComponent<ObjectStatus>().ReceberDano(dano);
            }
            else
            {
                collider1.Attack = false;
            }
        }
        if(player)
        {
            if(collider.CompareTag("Player"))
            {
                collider.GetComponent<PlayerStatus>().ReceberDano(dano);
            }
        }
        if(zombie)
        {
            if(collider.CompareTag("Zombie"))
            {
                collider.GetComponent<EnemyStatus>().ReceberDano(dano);
            }
        }
   }
}
