using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Velentr.AbstractShapes;
using Velentr.Debugging;

using Point = Microsoft.Xna.Framework.Point;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace CoreDev
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private FpsTracker _frameCounter = new FpsTracker(10);
        private PerformanceTracker _performance = new PerformanceTracker(10, enableFpsTracker: true);
        private string _baseTitle = "Velentr.AbstractShapes.DevEnv";
        private string _decimals = "0.000";

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            _baseTitle = $"{_baseTitle} | FPS: {{0:{_decimals}}} | TPS: {{1:{_decimals}}} | CPU: {{2:{_decimals}}}% | Memory: {{3:{_decimals}}} MB";

            var rectangleA = new Rectangle(0, 0, 1, 1);

            var rectangleA1 = rectangleA.ToVelentrRectangle();
            var rectangleA2 = rectangleA.ToVelentrRectangleD();

            var rectangleA1A = rectangleA1.ToXnaRectangle();
            var rectangleA2A = rectangleA2.ToXnaRectangle();




            var pointA = new Point(0, 0);
            var pointA1 = pointA.ToVelentrPoint();
            var pointA2 = pointA.ToVelentrPointI();
            var circle = pointA.ToCircle();
            
            var pointA1A = pointA1.ToXnaPoint();
            var pointA2A = pointA2.ToXnaPoint();

            var pointA1Av = pointA1.ToVector2();
            var pointA2Av = pointA2.ToVector2();

            var pointA1Avc = pointA1Av.ToCircle();
            var pointA1Avp = pointA1Av.ToVelentrPoint();
            var pointA1Avpi = pointA1Av.ToVelentrPointI();

            var pointA2Avc = pointA2Av.ToCircle();
            var pointA2Avp = pointA2Av.ToVelentrPoint();
            var pointA2Avpi = pointA2Av.ToVelentrPointI();



        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            _performance.Update(gameTime.ElapsedGameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _frameCounter.Update(gameTime.ElapsedGameTime);
            Window.Title = string.Format(_baseTitle, _frameCounter.AverageFramesPerSecond, _performance.FpsTracker.AverageFramesPerSecond, _performance.CpuTracker.CpuPercent, _performance.MemoryTracker.MemoryUsageMb);

            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}