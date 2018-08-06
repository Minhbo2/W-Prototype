using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// ADD SCRIPT SUMMARY
///</summary>

public class InputController : MonoBehaviour {


    //Private Variables Members
    [SerializeField]
    private LayerMask CubeMask;


	//Public Variables Members


	//Accessors


	//=================================================================================
	//UNITY'S METHODS

	void Start () {
		
	}
	

   
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Hit;
            Ray RayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayOrigin, out Hit, float.PositiveInfinity, CubeMask))
            {
                if (Hit.transform.gameObject != null)
                    Destroy(Hit.transform.gameObject);
            }
        }
	}



	//=================================================================================
	//Private Functions




	//=================================================================================
	//Public Functions
}
