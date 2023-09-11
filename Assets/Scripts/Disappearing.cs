using UnityEngine;

public class DisappearingState : PlayerState
{

    Player mPlayer;
    Rigidbody rbPlayer;
    public void Enter(Player player)
    {
        Debug.Log("Entering State: Disappearing");
        player.GetComponent<Renderer>().enabled = false; // Disable the renderer to make the player disappear
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.D))
        {
            // When the 'D' key is released, transition to another state (e.g., StandingState)
            player.GetComponent<Renderer>().enabled = true; // Enable the renderer to make the player reappear
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
