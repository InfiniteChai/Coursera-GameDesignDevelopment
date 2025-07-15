using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRespawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var pickup in GetComponentsInChildren<Pickup>(true))
        {
            if (pickup.needsRespawn)
            {
                pickup.timeToRespawn -= Time.deltaTime;
                if (pickup.timeToRespawn < 0)
                {
                    pickup.needsRespawn = false;
                    pickup.gameObject.SetActive(true);
                }
            }
        }
    }
}
