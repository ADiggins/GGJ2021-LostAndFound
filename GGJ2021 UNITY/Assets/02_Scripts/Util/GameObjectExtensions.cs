using UnityEngine;

public static class GameObjectExtensions
{
    public static bool IsPlayer(this GameObject gameObject)
    {
        return gameObject.tag == "Player";
    }
}
