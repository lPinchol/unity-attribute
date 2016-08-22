using UnityEngine;
using System.Collections;

public class MyDecorator : MonoBehaviour {

    [SerializeField]
    private string myName = "Need Name";

    [HideInInspector]
    public string desc = "Here is a public string that I wnat to hide in the inspector.";

    [TextArea]
    public string editBox = "";

    [Multiline(10)]
    public string editBox2 = "";

    public const float minHealth = 0f;
    public const float maxHealth = 200f;

    [Range(minHealth,maxHealth)]
    public int health;

    [Header("Currency")]
    public int gold;
    public int silver;
    public int copper;

    [Header("Stats")]
    public int strength;
    public int dexterity;
    public int constitution;

    [Space(10)]
    public string race;
    public int age;

    [Space(10)]
    [Tooltip("This is a objects position in the game world")]
    public Vector3 vec3;

    [Space(10)]
    [IntRangeAttribute(0,10)]
    public IntRange randomInt;

    private void Update()
    {
        int num = randomInt;
        Debug.Log(num);
    }
}
