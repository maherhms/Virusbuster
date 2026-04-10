using VirusBuster.Player;

namespace VirusBuster.Base;

public class GameState
{
    public static GameState Instance { get; private set; }
    public PlayerStats PlayerStats { get; } = new PlayerStats();

    // private constructor — nobody outside can call new GameState()
    private GameState() { }

    public static void Initialize()
    {
        Instance = new GameState();
    }

}
