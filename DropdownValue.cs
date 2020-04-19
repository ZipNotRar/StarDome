using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DropdownValue : MonoBehaviour
{
    private Dropdown list;
    public ScriptableString1 Value;
    void Awake()
    {
        list = GetComponent<Dropdown>();
        list.onValueChanged.AddListener(new UnityAction<int>(index =>
        {

            Value.Value = list.options[list.value].text;
        }));
    }
    // Start is called before the first frame update
    void Start()
    {
        list.value = PlayerPrefs.GetInt(Value.Value);
    }
}
