using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : PlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entering State: Standing");
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        //Debug.Log("Executing State: Standing");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // transition to jump
            JumpingState jumpingState = new JumpingState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // transition to duck
            DuckingState duckingState = new DuckingState();
            duckingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            DisappearingState disappearingState = new DisappearingState();
            disappearingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SprintingState sprintingState = new SprintingState();
            sprintingState.Enter(player);
        }


    }
}