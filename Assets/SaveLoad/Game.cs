using UnityEngine;
using System.Collections;

[System.Serializable]
public class _Game 
{ //don't need ": Monobehaviour" because we are not attaching it to a game object

	public static _Game current;
	public _Character knight;
	public _Character rogue;
	public _Character wizard;

	public _Game () 
    {
		knight = new _Character();
		rogue = new _Character();
		wizard = new _Character();
	}
		
}
