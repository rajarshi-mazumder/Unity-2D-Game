using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreComponent : MonoBehaviour
{
    protected Core core; 
    public bool debugMode = true;

    public virtual void Init(Core core)
    {
        this.core = core;
    }
    protected virtual void Awake()
    {
        core = transform.parent.GetComponent<Core>();

        if(core == null) { Debug.LogError("There is no core on the parent"); }
    }

    public void Log(string message)
    {
        if (debugMode)
        {
            Debug.Log(message);
        }
    }
    public virtual void LogicUpdate()
    {

    }

}
