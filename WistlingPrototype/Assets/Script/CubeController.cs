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
    Transform SelectedCube;

    [SerializeField] private AnimationCurve RotatingCurve;
    [SerializeField] private float RotationDuration;
    Quaternion TargetRotation;
    Quaternion StartRotation;
    float RotationTimer;
    bool IsRotating = false;



	//=================================================================================
	//Public Variables Members
	//=================================================================================




	//=================================================================================
	//Accessors
	//=================================================================================




	//=================================================================================
	//UNITY'S METHODS
	//=================================================================================

	void Awake () {

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


        if (IsRotating)
        {
            RotationTimer += Time.deltaTime;

            if (RotationTimer < RotationDuration)
            {
                float RotationPercentage = RotatingCurve.Evaluate(RotationTimer / RotationDuration);
                SelectedCube.rotation = Quaternion.Lerp(StartRotation, TargetRotation, RotationPercentage);
            }
            else
            {
                IsRotating = false;
                SelectedCube.rotation = TargetRotation;
            }
        }
    }



    //=================================================================================
    //Private Functions
    //=================================================================================
    private void RotateSelectable(Vector3 Direction)
    {
        if (!CubeSelector.HasCurrentlySelected()) { return; }

        SelectedCube = CubeSelector.GetCurrentlySelected();

        IsRotating = true;
        RotationTimer = 0.0f;
        StartRotation = SelectedCube.rotation;
        TargetRotation = StartRotation * Quaternion.Euler(Direction * 90.0f);
    }



	//=================================================================================
	//Public Functions
	//=================================================================================
}
