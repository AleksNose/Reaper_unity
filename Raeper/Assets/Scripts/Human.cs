using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public enum TypeHuman {Older, Middle};
    public TypeHuman typeHuman;

    public Human(TypeHuman newTypeHuman){
        typeHuman = newTypeHuman;
    }
}
