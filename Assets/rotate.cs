using UnityEngine;
using System.Collections;
public class rotate : MonoBehaviour
{

    // Use this for initialization
    public GameObject colaCan;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount > 0)
        {
            Instantiate(colaCan, new Vector3(0, 20, -30), Quaternion.identity);

        }

    }
}