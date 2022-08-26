using JoostenProductions;
using UnityEngine;

public class TrailTrackView : MonoBehaviour
{
    [SerializeField] 
    private TrailRenderer _trailRenderer;

    public TrailRenderer TrailRenderer { get { return _trailRenderer; } }

    public void Init()
    {
        //UpdateManager.SubscribeToUpdate(OnUpdate);
    }

    private void Update()
    {
        OnUpdate();
    }

    private void OnUpdate()
    {
        CheckTouch();
    }

    private void CheckTouch()
    {
        if (Input.touchCount > 0)
        {
            FollowTouch();
        }
    }

    private void FollowTouch()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) + new Vector3(0,0,1);
    }

    protected void OnDestroy()
    {
        UpdateManager.UnsubscribeFromUpdate(OnUpdate);
    }
}