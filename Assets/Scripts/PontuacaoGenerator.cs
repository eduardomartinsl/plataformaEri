using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PontuacaoGenerator : MonoBehaviour {

	public int PontuacaoPorEstrela = 10;
	public int PontuacaoTotal = 0;

	public Text ContadorDePontuacao;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ContadorDePontuacao.text = ("Pontuação total: " + PontuacaoTotal);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Estrela")){
			other.gameObject.SetActive (false);
			PontuacaoTotal += PontuacaoPorEstrela;
		}
	}
}
