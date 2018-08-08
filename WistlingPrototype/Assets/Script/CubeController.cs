using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// ADD SCRIPT SUMMARY
///</summary>

public class CubeController : MonoBehaviour {

    //=================================================================================
    //Private Variables Members
    //=================================================================================
    [SerializeField]
    private CubeSelector CubeSelector;



	//=================================================================================
	//Public Variables Members
	//=================================================================================




	//=================================================================================
	//Accessors
	//=================================================================================




	//=================================================================================
	//UNITY'S METHODS
	//=================================================================================

	void Start () {
		
	}
	


	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
            RotateSelectable(Vector3.left);
        else if (Input.GetKeyDown(KeyCode.D))
            RotateSelectable(Vector3.right);
        else if (Input.GetKeyDown(KeyCode.W))
            RotateSelectable(Vector3.forward);
        else if (Input.GetKeyDown(KeyCode.S))
            RotateSelectable(Vector3.down);
    }



    //=================================================================================
    //Private Functions
    //=================================================================================
    private void RotateSelectable(Vector3 Direction)
    {
        Transform Selected = CubeSelector.GetCurrentlySelected();
    }



	//=================================================================================
	//Public Functions
	//=================================================================================
}
