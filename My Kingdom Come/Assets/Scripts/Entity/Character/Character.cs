﻿using UnityEngine;
using System.Collections;

public class Character : Entity, IKillable, IDamageable<float> {

	//================================================================================================
	//[Character Variables]//
	//================================================================================================
	[HideInInspector] public string characterName;
	//================================================================================================



	//================================================================================================
	//[Awake]// --- Called before Start, used to initialise variables before game
	//================================================================================================
	protected override void Awake () {
		base.Awake ();
	}
	//================================================================================================



	//================================================================================================
	//[Start]// --- Called before Update, used to pass any information after all initialisation
	//================================================================================================
	protected override void Start () {
		base.Start ();
		curHealth = baseHealth;

		characterName = "";

		characterName += GameHelper.GlobalVariables.CHARACTER_FIRST_NAMES [
			Random.Range (0, GameHelper.GlobalVariables.CHARACTER_FIRST_NAMES.Length)
		];

		characterName += " " + GameHelper.GlobalVariables.CHARACTER_LAST_NAMES [
			Random.Range (0, GameHelper.GlobalVariables.CHARACTER_LAST_NAMES.Length)
		];
	}
	//================================================================================================



	//================================================================================================
	//[Update]// --- Called every frame to implement game behaviour
	//================================================================================================
	protected override void Update () {
		base.Update ();
	}
	//================================================================================================



	//================================================================================================
	//[Kill]// ---
	//================================================================================================
	public void Kill(){

	}
	//================================================================================================



	//================================================================================================
	//[TakeDamage]// ---
	//================================================================================================
	public void TakeDamage(float damage){

	}
	//================================================================================================

}
