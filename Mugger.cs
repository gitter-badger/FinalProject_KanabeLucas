using System;

namespace Eureka
{
	public class Mugger
	{
		public int muggerHealth = 8;
		public string muggerWeapon = "Knife";
		public int muggerAttack = 1;

		public Mugger ()
		{
		}

		public void muggerBeserk ()
		{
			muggerAttack = muggerAttack + 2;
		}
		public void resetAttack ()
		{
			muggerAttack = 1;
		}
		public void muggerIsHit (int hit)
		{
			muggerHealth = muggerHealth - hit;
		}

	}
}

