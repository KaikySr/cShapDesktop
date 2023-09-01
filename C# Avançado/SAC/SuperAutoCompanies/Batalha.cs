using SuperAutoCompanies.Companies;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SuperAutoCompanies;

public partial class Game : App
{
    List<Company> companies;
    public bool Batalha()
    {
        DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "CNC");
        return true;
    }
}