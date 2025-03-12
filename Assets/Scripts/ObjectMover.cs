using DG.Tweening;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float XPosition = -3f;
    [SerializeField] private float _duration = 3f;

    private void Start()
    {
        transform.DOMoveX(XPosition, _duration)
                 .SetEase(Ease.Linear)
                 .SetLoops(-1,LoopType.Yoyo);
    }
}