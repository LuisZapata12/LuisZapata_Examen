using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject 
{
    void attach(IObserver observer);
    void detach(IObserver observer);
    void notify();
}
