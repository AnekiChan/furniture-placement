using UnityEngine;

public interface IFurniture
{
    string Name { get; }
    Sprite UIIcon { get; }

    GameObject Pref {  get; }
}
