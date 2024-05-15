using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
   
   public float resizeSpeed = 0.1f; 
    private Vector3 originalScale; 
    private bool spaceBar = false; 

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            spaceBar= true;
        }
        else
        {
            
            if (spaceBar)
            {
                spaceBar = false;
                transform.localScale = originalScale;
            }
            return;
        }

        
        transform.localScale += Vector3.one * resizeSpeed * Time.deltaTime;
    }
    }

  
 
       

    
    

