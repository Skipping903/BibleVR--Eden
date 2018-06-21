using UnityEngine;
using System.Collections;

public class RayBehavior : MonoBehaviour
{
    public GameObject BeginLocation, EndLocation;
    public Color startColor = Color.white, endColor = Color.white;
    public Vector3 PositionRange;
    public float WidthA = 1.0f, WidthB = 1.0f, RadiusA = 1.0f, RadiusB = 1.0f, AlphaCurve, FadeSpeed = 1.0f;
    private LineRenderer Line;
    private Animation Anim;
    private bool changed = true;
    private Vector3 Offset;

    public void ResetRay()
    {
        this.Offset = new Vector3
       (Random.Range(-PositionRange.x, PositionRange.x),
        Random.Range(-PositionRange.y, PositionRange.y),
        Random.Range(-PositionRange.z, PositionRange.z));
        this.changed = true;
    }

    public void UpdateLineData()
    {
        AnimationCurve curve = new AnimationCurve();
        this.Line.SetPosition(0, BeginLocation.transform.position + (Offset * RadiusA));
        this.Line.SetPosition(1, EndLocation.transform.position + (Offset * RadiusB));
        curve.AddKey(0, WidthA);
        curve.AddKey(1, WidthB);
        this.Line.widthCurve = curve;
    }

    void Start()
    {
        this.Line = GetComponent<LineRenderer>();
        this.Anim = GetComponent<Animation>();
        this.Anim["RayAlphaCurve"].speed = FadeSpeed;
    }

    void Update()
    {
        if (this.changed)
        {
            this.changed = false;
            this.UpdateLineData();
        }
        this.Line.startColor = new Color(startColor.r, startColor.g, startColor.b, AlphaCurve);
        this.Line.endColor= new Color(endColor.r, endColor.g, endColor.b, AlphaCurve);
    }
}//class
