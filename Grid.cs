namespace OpenTKTutorial
{
    public class Grid
    {
        public int Xsize;
        public int Ysize;
        public GridElement[,] GridData;

        public Grid(int xsize, int ysize)
        {
            Xsize = xsize;
            Ysize = ysize;
            GridData = new GridElement[Xsize, Ysize];
            for (int x = 0; x < Xsize; x++)
            {
                for (int y = 0; y < Ysize; y++)
                {
                    GridElement gridElement = new GridElement();
                    GridData[x,y] = gridElement;
                }
            }
        }
    }
}
