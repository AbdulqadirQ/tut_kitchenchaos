using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour {

    // It's personal preference whether to use type 'Transform' or 'GameObject' for when declaring a prefab
    [SerializeField] private Transform tomatoPrefab;
    [SerializeField] private Transform counterTopPoint;

    public void Interact() {
        Debug.Log("interact");
        Transform tomatoTransform = Instantiate(tomatoPrefab, counterTopPoint);
        tomatoTransform.localPosition = Vector3.zero;
    }
}
