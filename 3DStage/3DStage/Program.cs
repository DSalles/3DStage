using System;

namespace ThreeDStage
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (StageOne game = new StageOne())
            {
                game.Run();
            }
        }
    }
#endif
}

