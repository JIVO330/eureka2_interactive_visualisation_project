using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urlmanager : MonoBehaviour {

    public string web1;
    public string web2;
    public string web3;

    // Use this for initialization
    void Start () {
		
	}
    public void I ()
    {
        Application.OpenURL (web1);
    }

    public void History ()
    {
        Application.OpenURL (web2);
    }

    public void Philosophy ()
    {
        Application.OpenURL (web3);
    }

    }
