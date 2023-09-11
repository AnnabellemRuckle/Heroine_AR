using UnityEngine;

public class LeftState : PlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;

    public float moveSpeed = 5.0f; // Adjust the speed as needed

    public void Enter(Player player)
    {
        Debug.Log("Entering State: Left");
        rbPlayer = player.GetComponent<Rigidbody>();
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        Debug.Log("Executing State: Left");

        // Move the character to the left when 'A' is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 leftMovement = Vector3.left * moveSpeed * Time.deltaTime;
            rbPlayer.MovePosition(rbPlayer.position + leftMovement);
        }

        if (Physics.Raycast(rbPlayer.transform.position, Vector3.down, 0.55f))
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
