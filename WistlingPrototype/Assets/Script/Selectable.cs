using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

///<summary>
/// ADD SCRIPT SUMMARY
///</summary>

[RequireComponent(typeof(MeshRenderer))]
public class Selectable : MonoBehaviour {

    //=================================================================================
    //Private Variables Members
    //=================================================================================
    [SerializeField]
    private Material HighLightMaterial;
    private Material DefaultMaterial;
    private MeshRenderer MeshRenderer;


    //=================================================================================
    //Public Variables Members
    //=================================================================================
    public event UnityAction OnSelected;
    public event UnityAction OnDeselected;



	//=================================================================================
	//Accessors
	//=================================================================================




	//=================================================================================
	//UNITY'S METHODS
	//=================================================================================

	void Awake () {

        MeshRenderer = GetComponent<MeshRenderer>();
        DefaultMaterial = MeshRenderer.material;
	}
	


	void Update () {
		
	}


    private void OnEnable()
    {
        OnSelected += HighLightSelectable;
        OnDeselected += RestoreSelectable;
    }


    private void OnDisable()
    {
        OnSelected -= HighLightSelectable;
        OnDeselected -= RestoreSelectable;
    }



    //=================================================================================
    //Private Functions
    //=================================================================================
    public void Select()
    {
        if (OnSelected != null)
            OnSelected();
    }

    public void Deselect()
    {
        if (OnDeselected != null)
            OnDeselected();
    }


    private void HighLightSelectable()
    {
        MeshRenderer.material = HighLightMaterial;
    }


    private void RestoreSelectable()
    {
        MeshRenderer.material = DefaultMaterial;
    }


    //=================================================================================
    //Public Functions
    //=================================================================================
}
