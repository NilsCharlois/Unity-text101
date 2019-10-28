using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
	[SerializeField] Text textComponent;
	[SerializeField] State startingState;
		
	State state;
	
    // Start is called before the first frame update
    void Start()
    {
		SetCurrentState(startingState);
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
	
	public void ManageState()
	{
		var nextStates = state.GetNextStates();
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
		{
			SetCurrentState(nextStates[0]);			
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
		{
			SetCurrentState(nextStates[1]);						
		}
	}
	public void SetCurrentState(State stateToSet)
	{
		this.state = stateToSet;
        textComponent.text = state.GetStateStory();
	}
}
