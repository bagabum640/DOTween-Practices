using DG.Tweening;
using UnityEngine;

public class ObjectMover : ObjectController
{
    [SerializeField] private float PositionX = -3f;

    private void Start()
    {
        StartTween();
    }

    protected override void StartTween()
    {
        transform.DOMoveX(PositionX, _duration)
                        .SetEase(Ease.Linear)
                        .SetLoops(InfiniteLoops, LoopType.Yoyo);
    }
}