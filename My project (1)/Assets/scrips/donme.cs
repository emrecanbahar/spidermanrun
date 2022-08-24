using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donme : MonoBehaviour
{
    string isim;

    
    void Start()
    {
        isim = gameObject.tag;
    }

    
    void Update()
    {
        if( isim== "mýkantýs")
        {
            transform.Rotate(1, 0, 0, Space.World);
        }
        if (isim == "spider")
        {
            transform.Rotate(0, 1, 0, Space.World);
        }
    }
    
}
