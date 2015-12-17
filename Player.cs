using System;

namespace Eureka
{
	public class Player
	{
		//Every player starts with this
		public int Health = 15;
		public string Weapon = "Unarmed";
		public int Level = 0;
		public int Score = 0;
		public string Name = "unknown";
		public string Sex = "unknown";
		public int attackPower = 1;

		public Player ()
		{
		}
			
		public void ChosenSex (string noSex)
		{
			Sex = noSex;
		}
		public void changeWeapon (string wep)
		{
			Weapon = wep;
		}
		public void takeDamage (int damage)
		{
			Health = Health - damage;
		}
		public void gainLevel (int exp)
		{
			Level = Level + exp;
		}
		public void scoreIncrease (int points)
		{
			Score = Score + points;
		}
		public void foundKnife ()
		{
			Weapon = "Knife";
			attackPower = attackPower + 1;
			Score = Score + 50;
		}
		public void foundKatana()
		{
			Weapon = "Katana";
			attackPower = attackPower + 3;
			Score = Score + 100;
		}
		public void foundBodyArmour()
		{
			Health = Health + 5;
		}
		public void foundLeatherGloves()
		{
			Health = Health + 2;
		}
		public void defeatMugger ()
		{
			Level = Level + 1;
			Score = Score + 100;
		}
		public void defeatAssassin ()
		{
			Level = Level + 2;
			Score = Score + 250;
		}

	}
}

