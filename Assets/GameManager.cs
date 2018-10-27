using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour {

	void Start()
	{
		Advertisement.Initialize ("1723177");
	}
	public void OnshowAdsButtonClick()
	{
		if (Advertisement.IsReady ()) {
			Advertisement.Show ();
		}
	}
}
