using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody myRigid;
    

    public GameObject Car;

    public float speed = 1f;
    
    
    

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        
        
        
        
        
        
        
        Vector3 carPosition = Car.transform.position;
        
        float horizontal = Input.GetAxis("Horizontal"); // 좌우 방향 입력
        float vertical = Input.GetAxis("Vertical");     // 상하 방향 입력
        
        Vector3 movementInput = new Vector3(horizontal, vertical, 0);
        Vector3 dirNmd = movementInput.normalized;

        float DecSpeed = Mathf.Min(movementInput.magnitude, 1.0f) * speed;
        
        carPosition += dirNmd * DecSpeed * Time.deltaTime;
        
        transform.position = carPosition;
        
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     
        //
        //     myRigid.AddForce(Vector2.up * flyPower, ForceMode.Impulse);
        //
        //     if (myRigid.velocity.y >= limitPower)
        //     {
        //         myRigid.velocity = new Vector2(myRigid.velocity.x, limitPower);
        //     }
        // }
        // // var playerEulerAngle = transform.eulerAngles;
        // // playerEulerAngle.z = myRigid.velocity.y * 5f;
        // //
        // // transform.eulerAngles = playerEulerAngle;
        //
        // if (bird_01.transform.position.y <= -5f)
        // {
        //     transform.position = new Vector3(transform.position.x, 2.4f, transform.position.z);
        // }
    }
}
