using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    // Start is called before the first frame update
    const float MoveUnitsPerSecond = 50;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput  = Input.GetAxis("Vertical");
        Vector3 pos = transform.position;
        if(horizontalInput != 0 ){
            pos.x += horizontalInput * MoveUnitsPerSecond * Time.deltaTime;
        }
        if(verticalInput!=0){
            pos.y += verticalInput * MoveUnitsPerSecond * Time.deltaTime;
        }
        transform.position = pos;
    }
}
