using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float turnSpeed=90f;
    void OnTriggerEnter(Collider other)
    {
       

        if(other.gameObject.name!="Player")
        {
            
            Destroy(gameObject);
            GameManager.inst.IncrementScore();
            return;
        }
         if(other.gameObject.GetComponent<Obstacle>()!=null)
        {
            Destroy(gameObject);
            

            return;
        }
        //check that the object we collided with is the player
        
        //add to the player's score

        //destroy the coin object
        
    }
        
        
        
        
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,turnSpeed*Time.deltaTime);
    }
}
