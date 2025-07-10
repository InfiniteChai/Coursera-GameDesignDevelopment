using UnityEngine;
using System.Collections;

public class YearRotation : MonoBehaviour {
    
    [Tooltip("This is the speed at which the object rotates, in Earth Years")]
	public float earthDays; // the speed of rotation	
	[Tooltip("The gameObject that represents the celestial body to rotate around")]
	public Transform pivot; // the object to rotate around

	// Update is called once per frame
	void Update () {		
		transform.RotateAround(this.pivot.position, this.pivot.up, Time.deltaTime * 360.0f / earthDays / SolarSystemController.Instance.secondsPerEarthDay);
	}
}
