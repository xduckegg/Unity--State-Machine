using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostState : IStateBase
{
    StateManager manager;
    public LostState(StateManager managerRef)
    {
        manager = managerRef;
        Debug.Log("Constructing LostState");
    }
    public void ShowIt()
    {
        //throw new System.NotImplementedException();
    }

    public void StateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            manager.SwitchState(new BeginState(manager));
            Application.LoadLevel("BeginingState");
            SceneManager.LoadScene(0);
        }
    }
}
