using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginState : IStateBase
{

    private StateManager manager;
    private float futureTime = 0;//countdown
    private float countDown = 0;//countdown
    private float screenDuration = 8;//countdown

    public BeginState(StateManager managerRef)
    {
        manager = managerRef;
        Debug.Log("Constructing BeginState");
        futureTime = screenDuration + Time.realtimeSinceStartup;//counter code
        //Time.timeScale = 0;//pause the game

    }

    public void StateUpdate()
    {
        float rightNow = Time.realtimeSinceStartup;
        countDown = (int)futureTime - (int)rightNow;
        if (Input.GetKeyUp(KeyCode.Space) || countDown <= 0)
        {
            Switch();
        }

            
    }


    public void ShowIt()
    {
        if (GUI.Button(new Rect(12, 12, 150, 100), "Press Play"))
        {
            Switch();
            
        }
        GUI.Box(new Rect(Screen.width - 60, 10, 50, 25), countDown.ToString());
    }


    private void Switch()
    {
        //Time.timeScale = 1;//continue the game
       // Application.LoadLevel("SampleScene");
        SceneManager.LoadScene(1);
        manager.SwitchState(new PlayState(manager));
    }
}