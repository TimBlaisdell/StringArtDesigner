using System.Drawing;

namespace StringArtDesigner {
    public interface IPanel {
        int Index { get; }
        Point Location { get; set; }
        Size Size { get; set; }
        string Title { get; }
        bool Visible { get; set; }
    }
}