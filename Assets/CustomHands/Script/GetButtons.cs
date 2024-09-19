using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetButtons : MonoBehaviour
{
    public TMP_Text _boolTxt;
    XRHandController _HandController;

    
    private void Update()
    {
        if (_HandController._primaryButtonValue)
        {
            //_boolTxt = _HandController._primaryButtonValue.ToString(TMP_Text);
        }
    }
}
