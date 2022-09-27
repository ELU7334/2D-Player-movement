using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
        public GameObject objecToFollow;

        private Vector3 _offset = new Vector3(0, 0, -0.5f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objecToFollow.transform.position + _offset;
    }
}
