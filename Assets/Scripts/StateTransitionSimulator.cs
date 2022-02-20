using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 실험자 상태들
public enum SubjectStates
{
    TaskNotStartedYet,
    Idle,
    Calibrating,
    WorkingOn,
    TaskFinished
}

public class StateTransitionSimulator : MonoBehaviour
{
    public SubjectStates State { get; private set; } = SubjectStates.TaskNotStartedYet;
    [SerializeField]
    private ScriptManager _scriptManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
