using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript3 : MonoBehaviour
{
  public int weapon = 0;
  // Start is called before the first frame update
  void Start()
  {
    weapon = Random.Range(1, 7);
    print("weapon = " + weapon);
    switch (weapon)
    {
      case 1:
        print("You found a sword!");
        break;
      case 2:
        print("You found an axe!");
        break;
      case 3:
        print("You found a dagger!");
        break;
      case 4:
        print("You found a bow!");
        break;
      default:
        print("You didn't find anything");
        break;
    }
  }

  // Update is called once per frame
  void Update()
  {
    // weapon = Random.Range(1, 7);
    // switch (weapon)
    // {
    //   case 1:
    //     print("You found a sword!");
    //     break;
    //   case 2:
    //     print("You found an axe!");
    //     break;
    //   case 3:
    //     print("You found a dagger!");
    //     break;
    //   case 4:
    //     print("You found a bow!");
    //     break;
    //   default:
    //     print("You didn't find anything");
    //     break;
    // }
  }
}
