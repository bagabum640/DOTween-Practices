using DG.Tweening;
using UnityEngine;

public class ObjectRotator : ObjectController
{
    [SerializeField] private Vector3 rotationVector = new (0, 360, 0);

    private void Start()
    {
        StartTween();
    }

    protected override void StartTween()
    {
        transform.DORotate(rotationVector, _duration, RotateMode.FastBeyond360)
                 .SetEase(Ease.Linear)
                 .SetLoops(InfiniteLoops);
    }
}