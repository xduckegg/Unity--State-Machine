using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonState : IStateBase
{
    StateManager manager;


    public WonState(StateManager manager)
    {
        this.manager = manager;
        Debug.Log("Constructing WonState");
    }
    public void ShowIt()
    {
       // throw new System.NotImplementedException();
    }

    public void StateUpdate()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {


            manager.SwitchState(new PlayState(manager));
        }
    }
}
