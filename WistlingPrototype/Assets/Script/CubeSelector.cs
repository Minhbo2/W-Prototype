using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// ADD SCRIPT SUMMARY
///</summary>

public class CubeSelector : MonoBehaviour {

    //=================================================================================
    //Private Variables Members
    //=================================================================================
    private Selectable CurrentlySelected;



    //=================================================================================
    //Public Variables Members
    //=================================================================================

    // we make sure to select 1 object at any given time
    public void Select(Selectable Selected)
    {
        if (CurrentlySelected != null)
            CurrentlySelected.Deselect();

        CurrentlySelected = Selected;
        CurrentlySelected.Select();
    }



	//=================================================================================
	//Accessors
	//=================================================================================




	//=================================================================================
	//UNITY'S METHODS
	//=================================================================================

	void Start () {
		
	}
	


	void Update () {
		
	}



    //=================================================================================
    //Private Functions
    //=================================================================================



    //=================================================================================
    //Public Functions
    //=================================================================================

    public Transform GetCurrentlySelected() { return CurrentlySelected.transform; }
}
