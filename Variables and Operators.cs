using System;
					
public class Program
{
	public Weapon miniGun;
	public PowerUp weaponPowerUp;
		
	public void Main()
	{
		miniGun = new Weapon(); 
		weaponPowerUp = new PowerUp();
		
		miniGun.ammoCount ++;
		miniGun.firepower += weaponPowerUp.powerLevel;
		Console.WriteLine(miniGun.weaponName + " has an ammo count of " + miniGun.ammoCount + ".");
		Console.WriteLine(" The fire power of is now " + miniGun.firepower + " has increased." );
	
	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Mini Gun";
	public float firepower = 11.5f;
}

public class PowerUp {
	public float powerLevel = 2.5f;
}