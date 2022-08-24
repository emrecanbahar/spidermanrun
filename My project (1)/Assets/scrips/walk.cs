using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{


    [SerializeField] float movemsped;
    [SerializeField] float harspeed;


    float har;



    void Update()
    {
        har = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(har * harspeed * Time.deltaTime, 0, movemsped * Time.deltaTime));
        Debug.Log("sasaddsd");
    }
}
