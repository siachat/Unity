using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed, timer;
    public int damage;

    
    void Update()
    {
        transform.position+=transform.forward*speed*Time.deltaTime;
 

    }

   private void OnCollisionEnter(Collision collision)
    {  
       GameObject.Destroy(gameObject);
    
    }


    //bullet diarection and speed->enemy
    public void InitBullet(Vector3 dir, float spd, int dmg)
    {    
        
        transform.forward=dir;
        speed=spd;
        damage=dmg;
    }
}
