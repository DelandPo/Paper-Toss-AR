using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdater : MonoBehaviour { 

    private int Count = 0;
    public Text myText;
    public AudioSource mySource;
	// Use this for initialization
	void Start () {
        mySource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        Count++;
        myText.text = string.Format("Score : {0}",Count.ToString());
        mySource.Play();
    }
}
