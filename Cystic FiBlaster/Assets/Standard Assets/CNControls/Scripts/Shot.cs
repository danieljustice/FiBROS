using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shot : ScriptableObject {

	public string shotName = "New Shot Type";
	//public Sprite shotSprite;
	public float abilityBaseCoolDown = 1.0f;

	public abstract void InitializeShot(GameObject obj);
	public abstract void TriggerShot ();
}
