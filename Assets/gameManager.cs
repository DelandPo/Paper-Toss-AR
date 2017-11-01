using UnityEngine;
using System.Collections;
public class gameManager : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            transform.Translate(Vector3.right * Time.deltaTime);

        }

    }
}