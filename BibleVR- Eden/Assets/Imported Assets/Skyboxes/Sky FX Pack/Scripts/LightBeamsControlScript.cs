using UnityEngine;
using System.Collections;

public class LightBeamsControlScript : MonoBehaviour
{
    public GameObject SourceObject, TargetObject, RayPrefab;
    public Color RayColor;
    public Vector3 PositionRange = Vector3.zero;
    public float WidthA = 1.0f, WidthB = 1.0f, RadiusA = 1.0f, RadiusB = 1.0f, FadeSpeed = 1.0f;
    public int NumRays = 10;
    private int Spawned = 0;
    private float TimeToSpawnAll = 3.0f, spawnInterval = 1.0f, currentCountdown = 0f;
    private RayBehavior[] rays;

    void SetRayValues(RayBehavior ray)
    {
        ray.PositionRange = PositionRange;
        ray.BeginLocation = SourceObject;
        ray.EndLocation = TargetObject;
        ray.startColor = RayColor;
        ray.endColor = RayColor;
        ray.WidthA = WidthA;
        ray.WidthB = WidthB;
        ray.RadiusA = RadiusA;
        ray.RadiusB = RadiusB;
        ray.FadeSpeed = FadeSpeed;
        ray.ResetRay();
    }

    void SpawnRay()
    {
        if (this.Spawned < this.NumRays)
        {
            this.rays[this.Spawned] = (GameObject.Instantiate(this.RayPrefab) as GameObject).GetComponent<RayBehavior>();
            this.SetRayValues(this.rays[this.Spawned]);
        }
        this.Spawned += 1;
        this.currentCountdown = this.spawnInterval;
    }

	void Start () 
    {
        this.spawnInterval = this.TimeToSpawnAll / this.NumRays;
        this.rays = new RayBehavior[this.NumRays];
        this.SpawnRay();
	}

	void Update () 
    {
        if (this.Spawned < this.NumRays)
        {
            if (this.currentCountdown <= 0)
            {
                this.SpawnRay();
            }
            this.currentCountdown -= Time.deltaTime;
        }
	}
}//class
