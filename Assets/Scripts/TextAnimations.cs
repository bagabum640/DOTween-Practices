using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimations : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration = 1.5f;
    [SerializeField] private float _delay = 2f;

    private WaitForSeconds _wait;

    private void Start()
    {
        _wait = new(_delay);

        StartCoroutine(WritingText());
    }

    private IEnumerator WritingText()
    {
        while (enabled)
        {
            ReplacementText();

            yield return _wait;

            AdditionText();

            yield return _wait;

            HackingText();

            yield return _wait;
        }
    }

    private void ReplacementText()
    {
        _text.DOText("1111", _duration);
    }

    private void AdditionText()
    {
        _text.DOText("2222", _duration).SetRelative();
    }

    private void HackingText()
    {
        _text.DOText("3333", _duration);
    }
}