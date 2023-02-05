using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    //variables to change
    [SerializeField] string inputAxis;
    [SerializeField] private float rotationTime;
    [SerializeField] private float startRotation;
    [SerializeField] private float endRotation;
	
    //data used for this script
    float targetRotation;
    float currentRotation;
    float currentRotationSpeed;

    //called when the object awakens
    private void Awake()
    {
        targetRotation = startRotation;
        currentRotation = startRotation;
        currentRotationSpeed = 0f;
        transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, currentRotation, 0);
    }

    // Update is called once per frame
    void Update()
    {
        bool activated = Input.GetButton(inputAxis);
        targetRotation = activated ? endRotation : startRotation;
        currentRotation = Mathf.SmoothDamp(currentRotation, targetRotation, ref currentRotationSpeed, rotationTime);
        transform.localRotation = Quaternion.Euler(0, currentRotation, 0);
    }

    public bool IsMoving()
    {
        return !Mathf.Approximately(targetRotation, currentRotation);
    }
}
