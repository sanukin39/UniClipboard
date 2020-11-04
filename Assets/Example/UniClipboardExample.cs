using UnityEngine;
using UnityEngine.UI;

public class UniClipboardExample : MonoBehaviour
{
    [SerializeField] private Button _getTextButton = null;
    [SerializeField] private Button _setTextButton = null;
    [SerializeField] private InputField _setTextInputField = null;
    [SerializeField] private Text _getText = null;

    private void Awake()
    {
        _getTextButton.onClick.AddListener(GetText);
        _setTextButton.onClick.AddListener(SetText);
    }

    void GetText()
    {
        _getText.text = UniClipboard.GetText();
    }

    void SetText()
    {
        var text = _setTextInputField.text;
        UniClipboard.SetText(text);
    }
}


