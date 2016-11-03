﻿using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	//================================================================================================
	//[HUD Variables]//
	//================================================================================================
	Player player;

	public string str = "none";

	[HideInInspector] private static float TOP_BAR_HEIGHT = 32f;
	[HideInInspector] private static float BOTTOM_BAR_HEIGHT = 96f;
	//================================================================================================



	//================================================================================================
	//[Awake]// --- Called before Start, used to initialise variables before game
	//================================================================================================
	protected virtual void Awake () {

	}
	//================================================================================================



	//================================================================================================
	//[Start]// --- Called before Update, used to pass any information after all initialisation
	//================================================================================================
	protected virtual void Start () {
		player = transform.GetComponentInParent<Player> ();
	}
	//================================================================================================



	//================================================================================================
	//[OnGUI]// --- Called for GUI implementation (Update should not be used for GUI)
	//================================================================================================
	protected virtual void OnGUI () {
		if (player.isHuman) {
			if (player.isInDirectMode) {
				DrawDirectModeHUD ();
			} else {
				DrawRTSModeHUD ();
			}
		}
	}
	//================================================================================================


	//================================================================================================
	//[DrawDirectModeHUD]//
	//================================================================================================
	private void DrawDirectModeHUD () {
		
	}
	//================================================================================================



	//================================================================================================
	//[DrawDirectModeHUD]//
	//================================================================================================
	private void DrawRTSModeHUD () {

		GUI.BeginGroup (new Rect(0, 0, Screen.width, Screen.height));

		GUI.Box (new Rect (0, 0, Screen.width, TOP_BAR_HEIGHT), "");
		GUI.Label (new Rect (4, 4, 128, 24), str);

		GUI.Box (new Rect (0, Screen.height - BOTTOM_BAR_HEIGHT, Screen.width, BOTTOM_BAR_HEIGHT), "");

		GUI.EndGroup();

	}
	//================================================================================================



	//================================================================================================
	//[MouseOutsideHUD]// --- Camera movement controls when in direct mode
	//================================================================================================
	public bool IsMouseOutsideHUD () {
		return (Input.mousePosition.y >= BOTTOM_BAR_HEIGHT && Input.mousePosition.y <= Screen.height - TOP_BAR_HEIGHT);
	}
	//================================================================================================


}
