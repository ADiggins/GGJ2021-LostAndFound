using UnityEngine;

public static class GameObjectExtensions
{
    public static bool IsPlayer(this GameObject gameObject)
    {
        Debug.Log(gameObject.tag);
        return gameObject.tag == "Player";
    }
}
