using UnityEngine;
using System.Collections;
public class rotate : MonoBehaviour
{

    // Use this for initialization
    private GameObject colaCan;
    public Camera firstPersonCamera;
    private bool shootEnable = false;
    public float timeLeft = 3;
    public GameObject Can;
    Rigidbody rb;

    private Vector2 touchStart;
    private Vector2 touchEnd;
    private float canVelocity = 0;
    private float canSpeed = 0;
    private Vector3 worldAngle;
    private bool couldBeSwipe = false;
     

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
            RaycastHit myHit;
            Touch myTouch = Input.GetTouch(0);
            Ray ray = firstPersonCamera.ScreenPointToRay(myTouch.position);
            if(Physics.Raycast(ray,out myHit, Mathf.Infinity))
                    {
                timeLeft = 3;
                       
                print(myHit.point);
                print(myHit.point.y + 20);

                colaCan = Instantiate(Can,new Vector3(myHit.point.x,myHit.point.y+20,myHit.point.z), Quaternion.identity);
                colaCan.AddComponent<Rigidbody>();
                colaCan.AddComponent<BoxCollider>();
                colaCan.AddComponent<destroyAfterCertainSeconds>();

                rb = colaCan.GetComponent<Rigidbody>();
                rb.useGravity = true;
                rb.isKinematic = false;
                rb.mass = 0.1f;
                rb.AddForce(firstPersonCamera.transform.forward * 200, ForceMode.Acceleration);
            }
            /*
            colaCan = Instantiate(Can,myHit.point,Quaternion.identity);
            colaCan.AddComponent<Rigidbody>();
            colaCan.AddComponent<BoxCollider>();
            colaCan.AddComponent<destroyAfterCertainSeconds>();

            rb = colaCan.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;

            rb.AddForce(transform.forward * 1, ForceMode.Impulse);
            */




        }

    }

}