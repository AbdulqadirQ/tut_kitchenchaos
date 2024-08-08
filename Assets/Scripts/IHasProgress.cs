using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHasProgress {

    public event EventHandler<OnProgresChangedEventArgs> OnProgressChanged;
    // EventArgs to send the current progress amount
    public class OnProgresChangedEventArgs : EventArgs {
        public float progressNormalized;
    }
}
