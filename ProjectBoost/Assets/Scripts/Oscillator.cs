using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
     float movementFactor;
    [SerializeField] float period = 2f;
    void Start()
    {
        startingPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (period == 0){
            return;
        }
        float cycles = Time.time / period; // continually gwoing over time

        const float tau = Mathf.PI * 2;  // constanta value of 6.83
        float rawSinWave = Mathf.Sin(cycles * tau); // going from -1 to 1

       movementFactor = (rawSinWave + 1f) / 2f; //recalculate 

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
