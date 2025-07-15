using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealthPickup : Pickup
{
	public override void DoOnPickup(Collider2D collision)
	{
		if (collision.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
		{
			Health playerHealth = collision.gameObject.GetComponent<Health>();
			if (playerHealth.currentHealth < playerHealth.maximumHealth)
			{
				playerHealth.ReceiveHealing(playerHealth.maximumHealth);
				base.DoOnPickup(collision);
			}
		}
	}
}
