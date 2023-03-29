using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	int kadri = 0;	
	// Use this for initialization
	void Start () {
		Debug.Log ("Programma tika starteta");	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Kadrs: "+kadri);
		kadri++;
		if (kadri==10) {
			Debug.Log ("Tu sasniedzi 10.kadru");
	}
}
	public string teksts;

	public GameObject ievadesLauks;

	public GameObject tekstaAttelosana;
	private string[] varianti = { "Sveiki", "Labdien", "DIIIIIIIIIIIIIIIIIIIRSA"};
	int nejausais;
	public void NolasitTekstu(){
		teksts = ievadesLauks.GetComponent<Text>().text;	
		nejausais = Random.Range (0, varianti.Length);
		tekstaAttelosana.GetComponent<Text> ().text =
			varianti [nejausais] + teksts.ToUpper () + "!";
}
}