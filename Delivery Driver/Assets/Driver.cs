using System.Collections;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float carSpeed = 15f;
    [SerializeField] float decreasedSpeed = 10f;
    [SerializeField] float increasedSpeed = 25f;
    string boostTag = "Boost";

    void Update() {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        carSpeed = decreasedSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == boostTag){
            carSpeed = increasedSpeed;
        }
    }
}
