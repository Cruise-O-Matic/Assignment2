using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public GameObject target;

    private Transform rigTransform;

    void Start()
    {
        rigTransform = this.transform.parent;

    }

    // Update is called once per frame
   
    void FixedUpdate()
    {
        if (target == null)
        {
            return;
        }

        rigTransform.position = Vector3.Lerp(rigTransform.position, target.transform.position,
          Time.deltaTime * moveSpeed);
    }

}
