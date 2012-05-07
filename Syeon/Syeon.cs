using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Syeon
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Syeon : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D spriteTexture;
        IntPtr simDrawSurface;

        public Syeon(IntPtr simDrawSurface)
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.simDrawSurface = simDrawSurface;
            graphics.PreparingDeviceSettings += new EventHandler<PreparingDeviceSettingsEventArgs>(graphics_PreparingDeviceSettings);
            System.Windows.Forms.Control.FromHandle((this.Window.Handle)).VisibleChanged += new EventHandler(Syeon_VisibleChanged); 
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Use this.Content to load simulation sprites.
            //spriteTexture = this.Content.Load<Texture2D>("PaperPlane");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            //spriteBatch.Draw(spriteTexture, new Vector2(100, 100), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Event capturing the construction of a draw surface and makes sure this gets redirected to
        /// a predesignated draw surface marked by pointer drawSurface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
                e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = simDrawSurface;
        }

        /// <summary>
        /// Occurs when the original game windows' visibility changes and makes sure it stays invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Syeon_VisibleChanged(object sender, EventArgs e)
        {
                if (System.Windows.Forms.Control.FromHandle((this.Window.Handle)).Visible == true)
                    System.Windows.Forms.Control.FromHandle((this.Window.Handle)).Visible = false;
        }
 
    }
}
