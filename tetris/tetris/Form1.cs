namespace tetris
{
    public partial class Form1 : Form
    {
        //struct PointXY { int x, y; }
        //BrickPatOrg[7][4][4] = {
        //  { {0,0,1,0,2,0,-1,0},		{0,0,0,1,0,-1,0,-2},	{0,0,1,0,2,0,-1,0},		{0,0,0,1,0,-1,0,-2}		},
        //  { {0,0,1,0,0,1,1,1},		{0,0,1,0,0,1,1,1},		{0,0,1,0,0,1,1,1},		{0,0,1,0,0,1,1,1}		},
        //  { {0,0,-1,0,0,-1,1,-1},	{0,0,0,1,-1,0,-1,-1},	{0,0,-1,0,0,-1,1,-1},	{0,0,0,1,-1,0,-1,-1}	},
        //  { {0,0,-1,-1,0,-1,1,0},	{0,0,-1,0,-1,1,0,-1},	{0,0,-1,-1,0,-1,1,0},	{0,0,-1,0,-1,1,0,-1}	},
        //  { {0,0,-1,0,1,0,-1,-1},	{0,0,0,-1,0,1,-1,1},	{0,0,-1,0,1,0,1,1},		{0,0,0,-1,0,1,1,-1}		},
        //  { {0,0,1,0,-1,0,1,-1},		{0,0,0,1,0,-1,-1,-1},	{0,0,1,0,-1,0,-1,1},	{0,0,0,-1,0,1,1,1}		},
        //  { {0,0,-1,0,1,0,0,1},		{0,0,0,-1,0,1,1,0},		{0,0,-1,0,1,0,0,-1},	{0,0,-1,0,0,-1,0,1}		},
        //};



        static int CS = 30;
        static int BW = 10;
        static int BH = 20;
        Rectangle playRt = new Rectangle(0, 0, CS * BW, CS * BH);
        Rectangle[] ImgRt = new Rectangle[7];
        static public Bitmap BackBit, PlayBit, ImgBit;
        Cell[,] m_cell = new Cell[BH, BW];
        Point ORG = new Point(50, 50);
        Point m_CurPos;
        int m_PatNo, m_RotNo;
        List<Cell> DrawList, EraseListp;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int m_lastSetY = BH;
        int m_Score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++) {
                ImgRt[i] = new Rectangle(i * CS, 0, CS, CS);
            }
            BackBit = new Bitmap(playRt.Width, playRt.Height);
            PlayBit = new Bitmap(playRt.Width, playRt.Height);
            ImgBit = new Bitmap(Cell.CS * 7, Cell.CS);

            Load_Image(ImgBit,playRt, "테트리스블럭.jpg");

            for (int y = 0; y < BH; y++)
                for (int x = 0; x < BW; x++)
                {
                    m_cell[y, x].init(x, y);
                }
        }

        private void Load_Image(Bitmap bit, Rectangle rt, Image img)
        {
            Graphics g = Graphics.FromImage(bit);
            g.DrawImage(img, 0, 0, rt.Width, rt.Height);
        }
        

    }
}
