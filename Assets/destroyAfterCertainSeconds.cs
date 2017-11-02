using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfterCertainSeconds : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(destroyAutomatically());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator destroyAutomatically()
    {
        yield return new WaitForSeconds(5);
        Debug.Log(gameObject.name);
        Destroy(gameObject);
    }
}
