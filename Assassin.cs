using System;

namespace Eureka
{
	public class Assassin
	{
			public int assassinHealth = 10;
			public string assassinWeapon = "Katana";
			public int assassinAttack = 3;

			public Assassin ()
			{
			}

			public void assassinFocus ()
			{
				assassinAttack = assassinAttack + 1;
			}
			public void resetAttack ()
			{
				assassinAttack = 0;
			}
			public void assassinIsHit (int hit)
			{
				assassinHealth = assassinHealth - hit;
			}
		}
	}

