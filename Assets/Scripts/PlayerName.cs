using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerName : MonoBehaviour
{
    [SerializeField] TMP_Text _enterField;
    [SerializeField] TMP_Text _playerName;

    void FixedUpdate()
    {
        _playerName.text = _enterField.text;
    }
}
