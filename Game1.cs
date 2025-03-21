using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Slut_projekt_1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    
    Texture2D[] bilar = new Texture2D[11];
    /*int choise;*/
    private Texture2D bBild1;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        bilar [0] = Content.Load<Texture2D>("v90-cross-country-b6-awd-large-1");
        bilar [1] = Content.Load<Texture2D>("v70-00-2");
        bilar [2] = Content.Load<Texture2D>("truck-isolated-on-transparent-background-3d-rendering-illustration-free-png");
        bilar [3] = Content.Load<Texture2D>("red-ferrari-side-profile-t0lvgph9x1j99qk7");
        bilar [4] = Content.Load<Texture2D>("polisbil");
        bilar [5] = Content.Load<Texture2D>("pngimg.com - mercedes_PNG1828");
        bilar [6] = Content.Load<Texture2D>("pngimg.com - koenigsegg_PNG21");
        bilar [7] = Content.Load<Texture2D>("ferrari-96052_1280");
        bilar [8] = Content.Load<Texture2D>("cosy");
        bilar [9] = Content.Load<Texture2D>("190-1906306_beauty4-breaking-bad-rv-side-view-hd-png");
        bilar [10] = Content.Load<Texture2D>("81d44a9e26630f6fe426c816cbb34a32");
        bBild1 = Content.Load<Texture2D>("24233918-vag-och-berg-se-landskap-tecknad-serie-vektor-gratis-vector");


        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        _spriteBatch.Begin();
        _spriteBatch.Draw(bBild1, new Rectangle(0, 0, 720, 480), Color.White);
        _spriteBatch.End();        

        base.Draw(gameTime);
    }
}
