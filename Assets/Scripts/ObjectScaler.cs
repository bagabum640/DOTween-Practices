using DG.Tweening;
using UnityEngine;

public class ObjectScaler : ObjectController
{
    [SerializeField] private Vector3 _targetScale = new(0.75f, 0.75f, 0.75f);

    private void Start()
    {
        StartTween();
    }

    protected override void StartTween()
    {
        transform.DOScale(_targetScale, _duration)
                 .SetEase(Ease.Linear)
                 .SetLoops(InfiniteLoops, LoopType.Yoyo);
    }
}