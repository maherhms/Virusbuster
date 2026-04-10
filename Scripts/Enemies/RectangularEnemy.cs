using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VirusBuster.Enemies;

public abstract class RectangularEnemy : Enemy
{
    protected RectangularEnemy(Vector2 position, Color color) : base(position, color)
    {
    }
}