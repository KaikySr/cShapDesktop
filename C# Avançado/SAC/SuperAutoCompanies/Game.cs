using System.Windows.Forms;
using System.Drawing;

namespace SuperAutoCompanies;

public partial class Game : App
{
    int playerLife = 5;

    bool fundiu = false;
    public override void OnFrame(bool isDown, PointF cursor)
    {
        if (!fundiu)
            Mercado();

        else
            Batalha();
    }
}