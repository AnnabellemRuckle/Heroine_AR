using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingState : PlayerState
{
    Player mplayer;
    Rigidbody rbPlayer;
    
    public void Enter(Player player){
        Debug.Log("Entering Diving");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.AddForce(0, -10000 * Time.deltaTime, 0, ForceMode.VelocityChange);
        player.mCurrentState = this;
    }
    
    public void Execute(Player player)
    {
        if (Physics.Raycast(rbPlayer.transform.position, Vector3.down, 0.55f))
        {
            PlayerState nextState;
            if (Input.GetKey(KeyCode.S))
            {
                nextState = new DuckingState();
            }
            else
            {
                nextState = new StandingState();
            }
            nextState.Enter(player);
        }
    }
}