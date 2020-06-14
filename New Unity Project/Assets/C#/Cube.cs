using UnityEngine;

public class Cube : Shape
{
    private void Start()
    {
        print(gameObject + "體積" + GetVolume());
    }
}
