using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour {
    bool dragging = false;
    float distance;
    public float ThrowSpeed;
    public float Spin;
    public float Speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void OnMouseDown () {
        distance = Vector3.Distance (transform.position, Camera.main.transform.position);
        dragging = true;
    }

    public void OnMouseUp () {
        rb = GetComponent<Rigidbody> ();
        rb.AddForce (new Vector3 (9.8f * 25f, 9.8f * 25f));
        dragging = false;
    }

    // Update is called once per frame
    void Update () {
        CalculateMovement ();
    }

    void CalculateMovement () {
        if (transform.position.z <= .5f) {
            transform.position = new Vector3 (transform.position.x, transform.position.y, 0.6f);
        }
        if (transform.position.y <= 3f)
        {
            transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
        }
        if (transform.position.x >= 5.4f) {
            transform.position = new Vector3 (5.4f, transform.position.y, transform.position.z);
        } else if (transform.position.x <= -5.4f) {
            transform.position = new Vector3 (-5.4f, transform.position.y, transform.position.z);
        }

        if (dragging) {
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint (distance);
            transform.position = Vector3.Lerp (this.transform.position, rayPoint, Speed * Time.deltaTime);
        }
    }
}