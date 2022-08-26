using JoostenProductions;
using UnityEngine;

public class TrailTrackController : BaseController
{
    private readonly ResourcePath _viewPath = new ResourcePath { PathResource = "Prefabs/TrailRenderer" };
    private TrailTrackView _trailView;

    public TrailTrackController()
    {
        _trailView = LoadView();
        _trailView.Init();
    }

    private TrailTrackView LoadView()
    {
        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
        AddGameObjects(objectView);
        return objectView.GetComponent<TrailTrackView>();
    }
}

