public class FasterFireRateBoost : PlayerBoost
{
	public override float modifyFireRate(float fireRate)
	{
		return fireRate / 2.0f;
	}

	public override int modifyGunCount(int gunCount)
	{
		return gunCount;
	}
}