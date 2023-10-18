using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform camara;

    public float speedCam;

    float camRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        camara = transform.GetChild(0).GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
    
    }
    // Update is called once per frame
    void Update()
    {
        // Asignar movimiento de mouse
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(new Vector3(0, mouseX, 0) * speedCam * Time.deltaTime);
        camRotation -= mouseY * speedCam * Time.deltaTime;
        camRotation = Mathf.Clamp(camRotation, -80, 80);
        camara.localRotation = Quaternion.Euler(new Vector3(camRotation, 0, 0));


    }
}
