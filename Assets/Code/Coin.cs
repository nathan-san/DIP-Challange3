using UnityEngine;
using System.Collections;

public class Coin : Pickup//inherit van pickup
{
    //override = je maakt een extensie van die functie
    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
		_GO.m_score ++;
		Debug.Log (_GO.m_score);
        //voeg hier code toe zo dat de speler zijn score omhoog gaat
    }
}
