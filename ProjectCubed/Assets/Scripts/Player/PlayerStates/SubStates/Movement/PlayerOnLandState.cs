﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnLandState : PlayerMovementState
{
    public PlayerOnLandState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (!isExitingState)
        {
            if (xyInput.x != 0 || xyInput.y != 0)
            {
                stateMachine.ChangeState(player.MoveState);
            }
            else if (isAnimationFinished)
            {
                stateMachine.ChangeState(player.IdleState);
            }
        }

    }
}
