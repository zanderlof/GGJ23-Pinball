using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    //variables to change
    [SerializeField] int flipperSpeed;
    [SerializeField] GameObject point;

    //data used for this script
    private Vector3 flipperStartPos;
    private Quaternion flipperStartRot;
    private bool moving;
    // Start is called before the first frame update
    void Start()
    {
        flipperStartPos = transform.position;
        flipperStartRot = transform.rotation;
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch(tag)
        {

            case "Left":
                //when you left click, the left flipper flips
                if (Input.GetMouseButton(0))
                {
                    if (transform.rotation.y < flipperStartRot.y + 90)
                    {
                        transform.RotateAround(point.transform.position, Vector3.down, flipperSpeed * Time.deltaTime);
                        moving = true;
                    }
                    else
                    {
                        moving = false;
                    }
                }
                else if (transform.rotation != flipperStartRot)
                {
                    transform.RotateAround(point.transform.position, Vector3.down, -flipperSpeed * Time.deltaTime);
                    if (transform.rotation.y > flipperStartRot.y)
                    {
                        transform.position = flipperStartPos;
                        transform.rotation = flipperStartRot;
                    }
                }
                break;
            case "Right":
                //when you right click, the right flipper flips
                if (Input.GetMouseButton(1))
                {
                    if (transform.rotation.y < flipperStartRot.y + 90)
                    {
                        transform.RotateAround(point.transform.position, Vector3.up, flipperSpeed * Time.deltaTime);
                        moving = true;
                    }
                    else
                    {
                        moving = false;
                    }
                }
                else if (transform.rotation != flipperStartRot)
                {
                    transform.RotateAround(point.transform.position, Vector3.up, -flipperSpeed * Time.deltaTime);
                    if (transform.rotation.y < flipperStartRot.y)
                    {
                        transform.position = flipperStartPos;
                        transform.rotation = flipperStartRot;
                    }
                }
                break;
            default:
                break;
        }
    }

    public bool IsMoving()
    {
        return moving;
    }
}
