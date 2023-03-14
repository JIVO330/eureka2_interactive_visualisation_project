using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject fire;

	// Use this for initialization
	void Start ()
    {
        if (fire == null)
        {
            Debug.LogWarning ("fire variable cannot be empty!");
        }

        fire.SetActive(false);
	}
	
    void OnMouseDown()
    {
        fire.SetActive(!fire.activeSelf);
    }
    
}
