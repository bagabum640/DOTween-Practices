using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimations : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _delay = 1f;

    private void Start()
    {
        CreateTextAnimationSequence();
    }

    private void CreateTextAnimationSequence()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("1111", _duration))
            .AppendInterval(_delay)
            .Append(_text.DOText("2222", _duration).SetRelative())
            .AppendInterval(_delay)
            .Append(_text.DOText("3333", _duration));

        sequence.SetLoops(-1);
    }
}