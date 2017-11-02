using UnityEngine;
using System.Collections;
public class rotate : MonoBehaviour
{

    // Use this for initialization
    public GameObject colaCan;
    public Camera firstPersonCamera;
    private bool firsttime = true;
    Rigidbody rb;

    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject my = collision.contacts[0].thisCollider.gameObject;
        Destroy(my);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount > 0)
        {
            RaycastHit myHit;
            Touch myTouch = Input.GetTouch(0);
            Ray ray = firstPersonCamera.ScreenPointToRay(myTouch.position);
            if(Physics.Raycast(ray,out myHit, Mathf.Infinity))
            if (firsttime)
            {

                colaCan = Instantiate(colaCan,myHit.point,Quaternion.identity);

            }
            colaCan.AddComponent<Rigidbody>();
            colaCan.AddComponent<BoxCollider>();
            
            rb = colaCan.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;
            rb.AddForce(transform.forward * 1,ForceMode.Impulse);
        }

    }
}