using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.UI;

public class SolarSystemController : MonoBehaviour {

	public static SolarSystemController Instance { get; private set; }
	public float secondsPerEarthDay = 1.0f;
	
	private void Awake()
	{
		// If there is an instance, and it's not me, delete myself.

		if (Instance != null && Instance != this)
		{
			Destroy(this);
		}
		else
		{
			Instance = this;
		}
	}	

	public void SetSystemSpeed(float speed)
	{
		secondsPerEarthDay = 1 / speed;
	}
}
