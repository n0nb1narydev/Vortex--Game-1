using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tornado : MonoBehaviour
{
	[SerializeField]
	private float _speed = 2f;
	[SerializeField]
	private Button _launch;
	private bool _isMoving = false;

	private void Start() 
	{

	}

	void Update()
	{
		transform.Translate ( Vector3.up * _speed * Time.deltaTime );
	}



	void MoveUp()
	{

		_isMoving = true;
	}
}