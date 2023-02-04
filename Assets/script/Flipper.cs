using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    //variables to change
    [SerializeField] int flipperSpeed;

    //game objects to manipulate the data of
    [SerializeField] GameObject flipperL;
    [SerializeField] GameObject flipperR;
    [SerializeField] GameObject pointL;
    [SerializeField] GameObject pointR;

    //data used for this script
    private Vector3 flipperLStartPos;
    private Quaternion flipperLStartRot;
    private Vector3 flipperRStartPos;
    private Quaternion flipperRStartRot;
    private bool moving;
    // Start is called before the first frame update
    void Start()
    {
        flipperLStartPos = flipperL.transform.position;
        flipperRStartPos = flipperR.transform.position;
        flipperLStartRot = flipperL.transform.rotation;
        flipperRStartRot = flipperR.transform.rotation;
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        //when you left click, the left flipper flips
        if (Input.GetMouseButton(0))
        {
            if(flipperL.transform.rotation.y < flipperLStartRot.y + 90)
            {
                flipperL.transform.RotateAround(pointL.transform.position, Vector3.down, flipperSpeed * Time.deltaTime);
                moving = true;
            }
            else
            {
                moving = false;
            }
        }
        else if(flipperL.transform.rotation != flipperLStartRot)
        {
            flipperL.transform.RotateAround(pointL.transform.position, Vector3.down, -flipperSpeed * Time.deltaTime);
            if(flipperL.transform.rotation.y > flipperLStartRot.y)
            {
                flipperL.transform.position = flipperLStartPos;
                flipperL.transform.rotation = flipperLStartRot;
            }
        }

        //when you right click, the right flipper flips
        if (Input.GetMouseButton(1))
        {
            if (flipperR.transform.rotation.y < flipperRStartRot.y + 90)
            {
                flipperR.transform.RotateAround(pointR.transform.position, Vector3.up, flipperSpeed * Time.deltaTime);
                moving = true;
            }
            else
            {
                moving = false;
            }
        }
        else if (flipperR.transform.rotation != flipperRStartRot)
        {
            flipperR.transform.RotateAround(pointR.transform.position, Vector3.up, -flipperSpeed * Time.deltaTime);
            if (flipperR.transform.rotation.y < flipperRStartRot.y)
            {
                flipperR.transform.position = flipperRStartPos;
                flipperR.transform.rotation = flipperRStartRot;
            }
        }
    }
}
