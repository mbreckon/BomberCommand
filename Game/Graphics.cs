namespace BomberCommand
{
    interface Graphics
    {
        void DrawBuilding(int zone, int height);
        void DrawGround();
        void DrawBomb(int range, int elevation);
        void DrawSky(System.Drawing.Color colour);
        void DrawExplosion(int range, int elevation, int frame);
        void DrawLandedPlane(int range, int elevation);
        void DrawFlyingPlane(int range, int elevation);
        void DrawSuccessMessage();
        void DrawFailMessage();
    }
}
