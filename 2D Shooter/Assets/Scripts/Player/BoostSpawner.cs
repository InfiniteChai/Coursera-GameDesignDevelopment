using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnDestroy()
	{
		GameManager.instance.PotentiallySpawnBoost(transform.position);
	}
}
