using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMotor : MonoBehaviour
{
    Transform lookAt;
    Vector3 startOffset;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        lookAt=GameObject.player.transform;
        startOffset=transform.position-lookAt.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=lookAt.position+startOffset;
        
    }
}
