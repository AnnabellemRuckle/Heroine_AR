using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerState mCurrentState;

    private void Awake(){
        mCurrentState = new StandingState();
    }
    void Update(){
        mCurrentState.Execute(this);
    }
}