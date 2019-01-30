using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI storyText;

    [SerializeField]
    private State startingState;

    private State currentState;

    private void Start()
    {
        ChangeState(startingState);
    }

    private void Update()
    {
        ProcessState();
    }

    private void ChangeState(int nextState)
    {
        ChangeState(currentState.GetNextStates()[--nextState]);
    }

    private void ChangeState(State nextState)
    {
        currentState = nextState;
        storyText.text = currentState.GetStateStory();
    }

    private void ProcessState()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeState(1);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeState(2);
    }
}
