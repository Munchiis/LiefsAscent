﻿/*  Documentation:
 *  Intended use
 *      Manage the animations of an enemy unit 1
 *      
 *  Last Documentation Update: 2 May 2021
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit1 : MonoBehaviour
{
    /*              Variables for Animation
     * ------------------------------------------------------- */
    Animator anim;
    private GameObject thisUnit;

    // Initialization, grab current gameobject and the gameobjects animator
    void Start()
    {
        anim = GetComponent<Animator>();
        thisUnit = GameObject.Find("EvilWizard0");
    }

    // Activate animations of current unit related to corresponding STATES from TacticalManager script
    void Update()
    {
        //if in ENEMYTURN state, toggle isWalking to on
        if (TacticalManager.enemyMove == true && TacticalManager.selected == thisUnit && !anim.GetCurrentAnimatorStateInfo(0).IsName("Tactics_EvilWizard_Attack"))
        {
            anim.SetBool("isWalking", true);
        }
        else //if not, remain in idle animation
        {
            anim.SetBool("isWalking", false);
        }
        //if in ATTACK state, trigger attack
        if (TacticalManager.enemyAttack == true && TacticalManager.selected == thisUnit && !anim.GetCurrentAnimatorStateInfo(0).IsName("Tactics_EvilWizard_Attack"))
        {
            anim.SetBool("isWalking", false);
            anim.SetTrigger("attack");
        }
    }
}
