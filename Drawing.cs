using \u003CCppImplementationDetails\u003E;
using LeagueSharp.Native;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace LeagueSharp
{
  /// <summary>
  /// This class offers everything one needs to render ontop of the League of Legends window.
  /// 
  /// </summary>
  public sealed class Drawing
  {

    /// <summary>
    /// Game camera's view
    /// 
    /// </summary>
    public static Matrix View
    {
      get
      {
      }
    }

    /// <summary>
    /// Game camera's Projection
    /// 
    /// </summary>
    public static Matrix Projection
    {
      get
      {
      }
    }

    /// <summary>
    /// SharpDX DirectD3D9 Device
    /// 
    /// </summary>
    public static Device Direct3DDevice
    {
      get
      {

	  }
	}
    /// <summary>
    /// Screen height of the League of Legends window
    /// 
    /// </summary>
    public static int Height
    {
      get
      {
      }
    }

    /// <summary>
    /// Screen width of the League of Legends window
    /// 
    /// </summary>
    public static int Width
    {
      get
      {
      }
    }

    /// <summary>
    /// SetRenderTarget Event, called before D3D9.SetRenderTarget is called
    /// 
    /// </summary>
    public static event SetRenderTarget OnSetRenderTarget;

    /// <summary>
    /// Present Event, called before D3D9.Present is called
    /// 
    /// </summary>
    public static event Present OnPresent;

    /// <summary>
    /// PostReset Event, called after Reset is called.
    /// 
    /// </summary>
    public static event PostReset OnPostReset;

    /// <summary>
    /// PreReset Event, called before Reset is called.
    /// 
    /// </summary>
    public static event PreReset OnPreReset;

    /// <summary>
    /// EndScene Event, subscribe to this event for using DirectX rendering code
    /// 
    /// </summary>
    public static event EndScene OnEndScene;

    /// <summary>
    /// BeginScene Event
    /// 
    /// </summary>
    public static event BeginScene OnBeginScene;

    /// <summary>
    /// Subscribe to this event to make use of drawing functions.
    /// 
    /// </summary>
    public static event Draw OnDraw;

    static Drawing()
    {
    }

    /// <summary>
    /// Draws Text on the Screen.
    /// 
    /// </summary>
    public static void DrawText(float x, float y, System.Drawing.Color color, string format)
    {
    }

    /// <summary>
    /// Draws Text on the Screen.
    /// 
    /// </summary>
    public static void DrawText(float x, float y, System.Drawing.Color color, string format, params object[] @params)
    {
    }

    /// <summary>
    /// Draws a circle at the given 3D position with the given radius in the specified color.
    /// 
    /// </summary>
    public static void DrawCircle(Vector3 pos, float radius, System.Drawing.Color color)
    {
    }

    /// <summary>
    /// Draws a line on the screen with specified thickness and color
    /// 
    /// </summary>
    public static void DrawLine(Vector2 start, Vector2 end, float thickness, System.Drawing.Color color)
    {
    }

    /// <summary>
    /// Draws a line on the screen with specified thickness and color
    /// 
    /// </summary>
    public static void DrawLine(float x, float y, float x2, float y2, float thickness, System.Drawing.Color color)
    {
    }

    /// <summary>
    /// Retrieves the text extent
    /// 
    /// </summary>
    public static Size GetTextExtent(string text)
    {
    }

    /// <summary>
    /// Converts the given 3D world coordinates into minimap coordinates.
    /// 
    /// </summary>
    public static Vector2 WorldToMinimap(Vector3 worldCoord)
    {
    }

    /// <summary>
    /// Converts the given 3D world coordinates into screen coordinates.
    /// 
    /// </summary>
    [return: MarshalAs(UnmanagedType.U1)]
    public static bool WorldToScreen(Vector3 worldCoord, out Vector2 screenCoord)
    {
    }

    /// <summary>
    /// Converts the given 3D world coordinates into screen coordinates.
    /// 
    /// </summary>
    public static Vector2 WorldToScreen(Vector3 worldCoord)
    {
    }

    /// <summary>
    /// Converts the given screen coordinates into 3D world coordinates.
    /// 
    /// </summary>
    public static Vector3 ScreenToWorld(Vector2 pos)
    {
    }

    /// <summary>
    /// Converts the given screen coordinates into 3D world coordinates.
    /// 
    /// </summary>
    public static Vector3 ScreenToWorld(float x, float y)
    {
    }
  }
}
