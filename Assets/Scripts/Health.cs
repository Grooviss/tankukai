using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public int particleCount;
    public GameObject particle;
    public bool autoDestroy = true;
    public void damage()
    
    {
        hp--;
        if (hp == 0) Die();
    }
  
    // Update is called once per frame
    public void Die()
    {
        if(autoDestroy)Destroy(gameObject);
        for (int i = 0; i < particleCount; i++)
        {
            var offset = Random.insideUnitSphere + Vector3.up;
            Instantiate(particle, transform.position + offset, transform.rotation);
        }
    }
}
