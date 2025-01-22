using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{


    public GameObject[] pipes;
    public float pipeSpeed = 10f;

    

    private void Update()
    {
        foreach (GameObject pipe in pipes)
        {
            pipe.transform.position -= Vector3.up * pipeSpeed * Time.deltaTime;

            if (pipe.transform.position.y <= -10f)
            {

                pipe.transform.position = new Vector3(pipe.transform.position.x, 10f, pipe.transform.position.z);
            }
        }

        // pipes[0].transform.position -= Vector3.up * pipeSpeed * Time.deltaTime;
        // pipes[1].transform.position -= Vector3.up * pipeSpeed * Time.deltaTime;

    }
   
  
}
