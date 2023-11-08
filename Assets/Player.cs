using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform topLimit;
    public Transform botLimit;

    public float speed; 
    public int id; 
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {   
        float playerInput;
        if(id==1) 
        {
            playerInput = Input.GetAxis("Vertical");  
        }    
        else
        {
            playerInput = Input.GetAxis("Horizontal");  
        }
        
        Vector3 newPosition = transform.position + (Vector3.up * speed * playerInput);
        float newY = Mathf.Clamp(value: newPosition.y,
                        min: botLimit.position.y, max: topLimit.position.y);
        newPosition.y = newY;
        transform.position = newPosition;
    }
}
