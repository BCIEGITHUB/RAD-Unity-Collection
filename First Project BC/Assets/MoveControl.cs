using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
//The following Code was aquired here:https://forum.unity.com/threads/how-to-make-camera-move-in-a-way-similar-to-editor-scene.524645/
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] float sensitivity = 1.0f;

    Camera cam;
    Vector3 anchorPoint;
    Quaternion anchorRot;
    private void Awake()
    {
        cam = GetComponent<Camera>();
    }
    // End of used Code Part 1
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //The following Code was aquired here:https://forum.unity.com/threads/how-to-make-camera-move-in-a-way-similar-to-editor-scene.524645/
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
            move += Vector3.forward * speed;
        if (Input.GetKey(KeyCode.S))
            move -= Vector3.forward * speed;
        if (Input.GetKey(KeyCode.D))
            move += Vector3.right * speed;
        if (Input.GetKey(KeyCode.A))
            move -= Vector3.right * speed;
        transform.Translate(move);

        if (Input.GetMouseButtonDown(1))
        {
            anchorPoint = new Vector3(Input.mousePosition.y, -Input.mousePosition.x);
            anchorRot = transform.rotation;
        }
        if (Input.GetMouseButton(1))
        {
            Quaternion rot = anchorRot;
            Vector3 dif = anchorPoint - new Vector3(Input.mousePosition.y, -Input.mousePosition.x);
            rot.eulerAngles += dif * sensitivity;
            transform.rotation = rot;



        }// End of the Code that was taken elsewhere
    }
    
}






