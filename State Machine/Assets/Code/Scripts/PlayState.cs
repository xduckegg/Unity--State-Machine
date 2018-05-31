using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : IStateBase
{
        StateManager manager;
    
    public PlayState(StateManager managerRef)
    {
        manager = managerRef;
        Debug.Log("Constructing PlayState");
    }
    public void ShowIt()
    {
      
    }

    public void StateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            manager.SwitchState(new WonState(manager));
        if (Input.GetKeyDown(KeyCode.C))
            manager.SwitchState(new LostState(manager));
    }
}
