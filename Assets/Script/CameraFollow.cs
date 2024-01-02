using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 2f, -5f);
    public float followSpeed = 5f;
    public float rotationSpeed = 3f;

    private float currentRotationY = 0f;



    void Start()
    {

        // Cursor.lockState = CursorLockMode.Locked; 



    }

    void LateUpdate()
    {

        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;

        currentRotationY += mouseX;

        Quaternion rotation = Quaternion.Euler(0f, currentRotationY, 0f);
        transform.position = target.position + rotation * offset;

         target.rotation = Quaternion.Euler(0f, currentRotationY, 0f);






        transform.LookAt(target);

    }

}
