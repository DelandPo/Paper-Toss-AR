using UnityEngine;
using System.Collections;
public class rotate : MonoBehaviour
{

    // Use this for initialization
    private GameObject colaCan;
    public Camera firstPersonCamera;
    private bool firsttime = true;
    public float timeLeft = 5;
    public GameObject Can;
    Rigidbody rb;

    void Start()
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        GameObject my = collision.contacts[0].thisCollider.gameObject;
        Destroy(my);
    }
    */
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (Input.touchCount > 0 && timeLeft < 0)
        {
            timeLeft = 5;
            RaycastHit myHit;
            Touch myTouch = Input.GetTouch(0);
            Ray ray = firstPersonCamera.ScreenPointToRay(myTouch.position);
            if(Physics.Raycast(ray,out myHit, Mathf.Infinity))
            if (firsttime)
            {

                colaCan = Instantiate(Can,myHit.point,Quaternion.identity);
                colaCan.AddComponent<Rigidbody>();
                colaCan.AddComponent<BoxCollider>();
                colaCan.AddComponent<destroyAfterCertainSeconds>();

                rb = colaCan.GetComponent<Rigidbody>();
                rb.useGravity = true;
                rb.isKinematic = false;

                rb.AddForce(transform.forward * 1, ForceMode.Impulse);

                }
            
          
        }

    }
}