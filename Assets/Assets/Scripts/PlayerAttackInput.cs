﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{
    private CharacterAnimations playerAnimation;

    public GameObject attackPoint;

    private PlayerShield shield;

    private CharacterSoundFX soundFX;


    void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimations>();
        shield = GetComponent<PlayerShield>();

        soundFX = GetComponentInChildren<CharacterSoundFX>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            playerAnimation.Defend(true);

            shield.ActivateShield(true);
        }

        if(Input.GetKeyUp(KeyCode.Y))
        {
            playerAnimation.UnFreezeAnimation();
            playerAnimation.Defend(false);

            shield.ActivateShield(false);
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            if(Random.Range(0, 2) > 0)
            {
                playerAnimation.Attack_1();
                soundFX.Attack_1();
            } else
            {
                playerAnimation.Attack_2();

                soundFX.Attack_2();
            }
        }
    }

    void Activate_AttackPoint()
    {
        attackPoint.SetActive(true);
    }

    void Deactivate_AttackPoint()
    {
        if(attackPoint.activeInHierarchy)
        {
            attackPoint.SetActive(false);
        }
        
    }
}

































