using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlames : MonoBehaviour {

	public GameObject fire1;
	public GameObject fire2;
	public GameObject fire3;
	public GameObject fire4;

	public bool isLit = false;

	//void Start ()
	//{
	//	fire1 = GetComponent<ParticleSystem>();
	//}
	
	void Start() {
		fire1.SetActive(isLit);
        fire2.SetActive(isLit);
        fire3.SetActive(isLit);
        fire4.SetActive(isLit);

	}

	void OnMouseDown() 
	{
		Debug.Log("torch 1pressed");
		isLit = !isLit;
		fire1.SetActive(isLit);
        fire2.SetActive(isLit);
        fire3.SetActive(isLit);
        fire4.SetActive(isLit);

	}
}
