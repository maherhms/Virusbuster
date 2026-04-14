using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VirusBuster.Base;
using VirusBuster.Utility;

namespace VirusBuster.Enemies;

public abstract class RectangularEnemy : Enemy
{
    protected int _width;
    protected int _height;
    protected Texture2D _texture;
    public Rectangle Hitbox => new Rectangle ((int)_position.X , (int)_position.Y, _width , _height);
    protected RectangularEnemy(Vector2 position, Color color , float health , float speed, int width , int height) : base(position, color , health , speed)
    {
        _width = width;
        _height = height;
    }
    public override void LoadEnemyContent()
    {
        _texture = GeometryFactory.CreateFilledTexture(
            GameCore.GraphicsDevice,
            _width,
            _height,
            _color
        );
    }
}