using UnityEngine;

public abstract class PlayerBoost : MonoBehaviour
{
	public abstract float modifyFireRate(float fireRate);

	public abstract int modifyGunCount(int gunCount);
}