using Mirror;
using UnityEngine;

public static class EntityViewExtensions
{
    public static void InstantiateView(this EntityRW entity, EntityViewBase prefabView)
    {
        var view = Object.Instantiate(prefabView);
        view.Init(entity);

        NetworkServer.Spawn(view.gameObject);
    }
}