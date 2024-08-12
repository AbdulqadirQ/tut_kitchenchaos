using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Have commented this CreateAssetMenu() after creating a RecipeSO ScriptableObejct so that there's only 1 created
// This is just a safety precaution
// [CreateAssetMenu()]
public class RecipeSO : ScriptableObject {

    public List<KitchenObjectSO> kitchenObjectSOList;
    public string recipeName;

}
