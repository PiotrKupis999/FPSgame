using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    float sensitivity = 2f;
    float yaw = 0f;
    float pitch = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;

        yaw += sensitivity * Input.GetAxis("Mouse X");
        pitch -= sensitivity * Input.GetAxis("Mouse Y");

        Debug.Log(gameObject.transform.localRotation);

        transform.eulerAngles = new Vector3(pitch,yaw,0);


    }
}
