using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject {
    
    [SerializeField] private List<KitchenObjectSO> validKitchenObjectSOList;

    private List<KitchenObjectSO> kitchenObjectSOList;

    private void Awake() {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }

    // Current game design is a plate can only hold 1 type of each ingredient
    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO) {
        if (!validKitchenObjectSOList.Contains(kitchenObjectSO)) {
            // KitchenObject is not in valid list of what can be added to a plate
            return false;
        }
        if (kitchenObjectSOList.Contains(kitchenObjectSO)) {
            // Already has this type
            return false;
        } else {
            kitchenObjectSOList.Add(kitchenObjectSO);
            return true;
        }
    }

}
