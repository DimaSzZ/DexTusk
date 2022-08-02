using System.Xml.Serialization;

namespace Task20_Serialization
{
    [Serializable]
    public class ListFigure
    {
        public List<Figure> AllFig = new();

        public void AddFig(Figure fig)
        {
            AllFig.Add(fig);
            fig.lstFigure = this;
        }
    }
}
