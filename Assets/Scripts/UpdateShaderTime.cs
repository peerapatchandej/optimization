using UnityEngine;

public class UpdateShaderTime : MonoBehaviour
{
  public float time = 10f;

  Renderer rend;
  void Start() { rend = GetComponent<Renderer>(); }

  void Update()
  {
    rend.material.SetFloat("_uTime", time * Time.time);
  }
}
