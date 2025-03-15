using UnityEngine;

public abstract class ObjectController : MonoBehaviour
{
    protected const int InfiniteLoops = -1;

    [SerializeField] protected float _duration = 3f;

    protected abstract void StartTween();
}