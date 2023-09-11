using UnityEngine;

public class SprintingState : PlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;
    public float sprintSpeed = 10.0f; // Adjust the sprint speed as needed

    public void Enter(Player player)
    {
        Debug.Log("Entering State: Sprinting");
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.W))
        {
            // When the 'W' key is released, transition to another state (e.g., StandingState)
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

        // Check for 'W' key to sprint forward
        if (Input.GetKey(KeyCode.W))
        {
            // Move the player forward
            Vector3 forwardMovement = player.transform.forward * sprintSpeed * Time.deltaTime;
            player.transform.Translate(forwardMovement);
        }
    }
}
