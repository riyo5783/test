using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ノーツ君 : MonoBehaviour
{
    int NoteSpeed = 5;
    
    // Update is called once per frame
    void Update()
    {
       transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
    }
}
