using UnityEngine;
using System.Collections;

public class ControleDeMovimento : MonoBehaviour {

	public float Velocidade = 6.0f;
	public float Velocidade_Pulo = 8.0f;
	public float Gravidade = 20.0f;


	public Vector3 _direcaoDeMovimento = Vector3.zero;
	public Animator _animacao;
	// Use this for initialization
	void Start () {
		_animacao = gameObject.GetComponent<Animator> ();
	}

	
	// Update is called once per frame
	void Update () {

		CharacterController Controlador = GetComponent<CharacterController> ();
		if (Controlador.isGrounded) {
			_direcaoDeMovimento = new Vector3(0, Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
			_direcaoDeMovimento = transform.TransformDirection (_direcaoDeMovimento);
			_direcaoDeMovimento *= Velocidade;
			if (Input.GetButton ("Jump")/* && _animacao.GetBool ("Andando")*/) {
				_direcaoDeMovimento.y = Velocidade_Pulo;
				_animacao.SetTrigger ("Pulando_Andando");

			}
		}
		_direcaoDeMovimento.y -= Gravidade * Time.deltaTime;
		Controlador.Move (_direcaoDeMovimento * Time.deltaTime);
		ExecutaAnimacaoDeAndar (_direcaoDeMovimento.x);
	}

	void ExecutaAnimacaoDeAndar (float x){
		bool _andando = x != 0f;
		_animacao.SetBool ("Andando", _andando);
	}
}
