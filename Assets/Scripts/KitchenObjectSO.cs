using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {

    // is public because ScriptableObject fields are used to be read-only
    public Transform prefab;
    public Sprite sprite;
    public string objectName;

}
