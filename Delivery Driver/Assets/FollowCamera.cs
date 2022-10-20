using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    [SerializeField] GameObject car;
    int cameraDistance = -10;

    void LateUpdate() {
        transform.position = car.transform.position + new Vector3(0, 0, cameraDistance);
    }
}
