using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Health Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var scaleX = Health.hp / 5f;
        transform.localScale = new Vector3(scaleX, 1, 1);
    }
}
