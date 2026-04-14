using Microsoft.Xna.Framework;

namespace VirusBuster.Enemies;

public abstract class RectangularEnemy : Enemy
{
    protected int _width;
    protected int _height;
    public Rectangle Hitbox => new Rectangle ((int)_position.X , (int)_position.Y, _width , _height);
    protected RectangularEnemy(Vector2 position, int width , int height, Color color) : base(position, color)
    {
        _width = width;
        _height = height;
    }
}