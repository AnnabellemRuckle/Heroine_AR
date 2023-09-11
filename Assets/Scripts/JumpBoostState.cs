using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostState : PlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;
    float launchTime;

    public void Enter(Player player)
    {
        Debug.Log("Entering State: Rocket");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.velocity = new Vector3(0, 30, 0);
        launchTime = Time.time;
        player.mCurrentState = this;

    }

    public void Execute(Player player)
    {
        if (Physics.Raycast(rbPlayer.transform.position, Vector3.down, 0.55f) && (Time.time - launchTime > 0.5f))
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            DivingState divingState = new DivingState();
            divingState.Enter(player);
        }
    }
}