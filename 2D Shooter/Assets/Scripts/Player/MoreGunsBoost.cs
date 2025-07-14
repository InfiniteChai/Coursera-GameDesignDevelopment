public class MoreGunsBoost : PlayerBoost
{
	public override float modifyFireRate(float fireRate)
	{
		return fireRate;
	}

	public override int modifyGunCount(int gunCount)
	{
		return gunCount + 2;
	}
}