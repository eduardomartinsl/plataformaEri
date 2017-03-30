using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptDeStrela : MonoBehaviour {

	public int PontoPorEstrela = 10;
	public int PontuacaoTotal = 0;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(){
		this.gameObject.SetActive (false);
		PontuacaoTotal += PontoPorEstrela;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
