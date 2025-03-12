using DG.Tweening;
using UnityEngine;

public class ObjectScaleChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale = new(0.75f, 0.75f, 0.75f);
    [SerializeField] private float _duration = 3f;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration)
                 .SetEase(Ease.Linear)
                 .SetLoops(-1,LoopType.Yoyo);
    }
}