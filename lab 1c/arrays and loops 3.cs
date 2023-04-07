using System;

public class Program
{
    public static void Main()
    {
        weapon[] weaponObjs = {new weapon(), new weapon(), new weapon()};
        weaponsObjs[1].weaponName = "Sword";
        weaponsObjs[2].weaponName = "Hammer";

        for(var item in weaponsObjs) {
            weaponsObjs[i].powerLevel = 2;
        }

        foreach(var item in weaponsObjs){
            Console.WriteLine(item.weaponName);
            COnsole.WriteLine(item.powerLevel);
        }
    }
}

public class weapon {
    public string weaponName = "Axe";
    public int powerLevel = 1;
}