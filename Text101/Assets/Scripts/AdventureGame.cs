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
		
		for (int i = 0; i<nextStates.Length; i++)
		{
			if(Input.GetKeyDown(KeyCode.Alpha1 + i) || Input.GetKeyDown(KeyCode.Keypad1 + i))
			{
				SetCurrentState(nextStates[i]);			
			}
		}
	}
	
	public void SetCurrentState(State stateToSet)
	{
		this.state = stateToSet;
        textComponent.text = state.GetStateStory();
	}
}
