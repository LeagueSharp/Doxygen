using \u003CCppImplementationDetails\u003E;
using LeagueSharp.Native;
using SharpDX;
using std;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public class GameObject
  {
    public bool IsValid
    {
      get
      {
	  }
    }

    public bool IsMe
    {
      get
      {
      }
    }

    public bool IsEnemy
    {
      get
      {
      }
    }

    public bool IsAlly
    {
      get
      {
      }
    }

    public int NetworkId
    {
      get
      {
      }
    }

    public BoundingBox BBox
    {
      get
      {
	  }
    }

    public int Flags
    {
      get
      {
      }
    }

    public GameObjectTeam Team
    {
      get
      {
      }
    }

    public bool IsDead
    {
      get
      {
      }
    }

    public bool IsVisible
    {
      get
      {
      }
    }

    public float BoundingRadius
    {
      get
      {
      }
    }

    public Vector3 Orientation
    {
      get
      {
      }
    }

    public Vector3 Position
    {
      get
      {
      }
    }

    public GameObjectType Type
    {
      get
      {
      }
    }

    public string Name
    {
      get
      {
      }
    }

    public static event GameObjectPropertyChange OnPropertyChange;

    public static event GameObjectDelete OnDelete;

    public static event GameObjectCreate OnCreate;

    static GameObject()
    {
    }

    public GameObject(ushort index, uint networkId)
    {
    }

    public GameObject()
    {
    }
	
    public override string ToString()
    {
    }
  }
}
