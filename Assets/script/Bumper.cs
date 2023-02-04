using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    //variables to manipulate
    [SerializeField] float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 direction;
        switch(tag)
        {
            case "Round":
                //get direction from center of bumper to ball
                direction = collision.gameObject.transform.position - transform.position;
                //apply force to the ball in the direction previously calculated
                collision.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * force);
                break;
            case "Edge":
                //get direction from center of bumper to ball
                direction = collision.gameObject.GetComponentInParent<Transform>().position - transform.position;
                //apply force to the ball in the direction previously calculated
                collision.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * force);
                break;
            default:
                break;
        }
        
    }
}
