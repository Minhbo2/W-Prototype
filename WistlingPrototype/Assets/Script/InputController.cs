﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// ADD SCRIPT SUMMARY
///</summary>

public class InputController : MonoBehaviour {

    //=================================================================================
    //Private Variables Members
    //=================================================================================
    [SerializeField]
    private LayerMask CubeMask;
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
        if (CubeSelector == null)
            print("Require reference to CubeSelector");
	}
	


	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Hit;
            Ray InputRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(InputRay, out Hit, float.PositiveInfinity, CubeMask))
            {
                if (Hit.transform.gameObject != null)
                    CubeSelector.Select(Hit.transform.GetComponent<Selectable>());
            }
        }
	}



	//=================================================================================
	//Private Functions
	//=================================================================================



	//=================================================================================
	//Public Functions
	//=================================================================================
}
