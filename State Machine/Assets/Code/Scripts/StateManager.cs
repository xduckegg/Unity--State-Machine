using System;
using UnityEngine;

public class StateManager: MonoBehaviour
{
    private IStateBase activeState;
    private static StateManager instanceRef;
    private void Awake()
    {
        if (instanceRef == null)
        {
            instanceRef = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }

    }
    void Start()
    {
        activeState = new BeginState(this);
        //print("This object of type: " + activeState);
    }

     void Update()
    {
        
        if (activeState!=null)
        {
            activeState.StateUpdate();
        }
        
    }

     public void SwitchState(IStateBase newState)
    {
        activeState = newState;   
    }
    private void OnGUI()
    {
        if (activeState != null)
            activeState.ShowIt();
    }
}