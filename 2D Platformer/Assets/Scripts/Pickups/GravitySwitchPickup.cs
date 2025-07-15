using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pickup-derived component which addes to the player's score when collected
/// </summary>
public class GravitySwitchPickup : Pickup
{    
    /// <summary>
    /// Description:
    /// When picked up, adds to the player's score
    /// Input:
    /// Collider2D collision
    /// Returns:
    /// void (no return)
    /// </summary>
    /// <param name="collision">The collision that touched the pickup</param>
    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player" && collision.gameObject.GetComponent<Rigidbody2D>() != null)
        {
            var rigidBody = collision.gameObject.GetComponent<Rigidbody2D>();
            rigidBody.gravityScale *= -1;
            collision.gameObject.transform.Rotate(new Vector3(0, 180, 180));            
		}

		base.DoOnPickup(collision);
	}

   
}
