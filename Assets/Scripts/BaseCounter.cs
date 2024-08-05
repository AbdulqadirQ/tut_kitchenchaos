using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour {

    // the 'protected' accessor is visible to this class and any class inheriting it
    // 'virtual' allows the child class to implement in their own way
    // 'abstract' is an alternative to 'virtual' which forces all child classes to have their own implementation
    public virtual void Interact(Player player) {
        Debug.LogError("BaseCounter.Interact(); entered which shouldn't happen");
    }
}
