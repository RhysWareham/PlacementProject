﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : EnemyMovementState
{
    public EnemyAttackState(Enemy enemy, EnemyStateMachine stateMachine, EnemyData enemyData, string animBoolName) : base(enemy, stateMachine, enemyData, animBoolName)
    {
    }


    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();

        //enemy.CurrentClipInfo = enemy.Anim.GetCurrentAnimatorClipInfo(1);
        //enemy.CurrentClipLength = enemy.CurrentClipInfo[0].clip.length;
        //Debug.Log(enemy.CurrentClipLength);
        enemy.animStartTime = Time.time;

        Debug.Log("ATTACK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    }

    public override void Exit()
    {
        base.Exit();
        enemy.IsAttacking = false;
        enemy.LastAttackTime = Time.time;
        
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        //If the time is later than the animStartTime + currentClipLength
        if(Time.time >= enemy.animStartTime + enemy.attackTime)
        {
            //Change to idle state
            stateMachine.ChangeState(enemy.IdleState);
        }
        

    }
}
