using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tornado : MonoBehaviour
{
	// private float _speed = 2f;
	// [SerializeField]
	// private Button _launch;
	private bool _isMoving = false;


	private void Start() 
	{
		this.GetComponent<Rigidbody>().velocity = (ptB.transform.position - transform.position).normalized * speed;
	}

	void Update()
	{
	}

	// void OnLaunch()
	// {
	// 	transform.Translate ( Vector3.up * _speed * Time.deltaTime );
	// 	_isMoving = true;
	// }

}