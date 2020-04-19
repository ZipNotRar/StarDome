using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    //public Transform camTransform;
    public Camera cam;
    float currentX;
    float currentY;

    float rotationSpeed = 5;
    public Transform shoulder;
    public Transform cameraPivot;

    public float sensitivityX = 15F;
    public float sensitivityY = 15F;
    public float minimumX = -90F;
    public float maximumX = 90F;
    public float minimumY = -60F;
    public float maximumY = 60F;
    float rotationX;
    float rotationY;

    private void Start()
    {
        //camTransform = transform;
        cam = Camera.main;
    }
    private void Update()
    {
        cameraPivot.position = shoulder.position;

        currentX = Input.GetAxis("Mouse X") * rotationSpeed;
        rotationX -= Input.GetAxis("Mouse Y") * sensitivityX;
        currentY = Input.GetAxis("Mouse Y") * rotationSpeed;
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;

        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        cameraPivot.eulerAngles = new Vector3(rotationX, rotationY, 0);

        shoulder.rotation = cameraPivot.rotation;
    }
}
